define("WordPrintableConverter", ["ext-base", "terrasoft", "FilterConverter", "FilterConverterConnector"], function() {
	Ext.define("Terrasoft.configuration.WordPrintableConverter", {
		extend: "Terrasoft.BaseObject",
		alternateClassName: "Terrasoft.WordPrintableConverter",
		singleton: true,

		_aggregationTypesMap: {
			"None": Terrasoft.AggregationType.NONE,
			"Count": Terrasoft.AggregationType.COUNT,
			"Sum": Terrasoft.AggregationType.SUM,
			"Avg": Terrasoft.AggregationType.AVG,
			"Min": Terrasoft.AggregationType.MIN,
			"Max": Terrasoft.AggregationType.MAX,
		},

		_getClientAggregationType: function(value) {
			const aggregationType = this._aggregationTypesMap[value];
			return aggregationType ? aggregationType : Terrasoft.AggregationType.NONE;
		},

		_getServerAggregationTypeName: function(aggregationType) {
			const aggregationTypeNames = Object.keys(this._aggregationTypesMap);
			for (let index in aggregationTypeNames) {
				const aggregationTypeName = aggregationTypeNames[index];
				if (this._aggregationTypesMap[aggregationTypeName] === aggregationType) {
					return aggregationTypeName;
				}
			}
			return "None";
		},

		_getClientDataValueType: function(serverDataValueTypeName) {
			return Terrasoft.ServerDataValueTypeName[serverDataValueTypeName];
		},

		_getServerDataValueTypeName: function(dataValueType) {
			const serverDataValueTypeNames = Object.keys(Terrasoft.ServerDataValueTypeName);
			for (let index in serverDataValueTypeNames) {
				const serverDataValueTypeName = serverDataValueTypeNames[index];
				if (Terrasoft.ServerDataValueTypeName[serverDataValueTypeName] === dataValueType) {
					return serverDataValueTypeName;
				}
			}
			return null;
		},

		_convertTo7xOrderDirection: function(orderDirection5x) {
			switch (orderDirection5x) {
				case "Ascending":
					return Terrasoft.OrderDirection.ASC;
				case "Descending":
					return Terrasoft.OrderDirection.DESC;
				default:
					return Terrasoft.OrderDirection.NONE;
			}
		},

		_convertTo5xOrderDirection: function(orderDirection7x) {
			switch (orderDirection7x) {
				case Terrasoft.OrderDirection.ASC:
					return "Ascending";
				case Terrasoft.OrderDirection.DESC:
					return "Descending";
				default:
					return undefined;
			}
		},

		_removeFilterKeys: function(filterGroup) {
			delete filterGroup.key;
			const clonedItems = filterGroup.getItems().concat([]);
			clonedItems.forEach(function(item) {
				if (item.filterType === Terrasoft.FilterType.FILTER_GROUP) {
					this._removeFilterKeys(item);
					return;
				}
				delete item.key;
				if (item.isAggregative && item.leftExpression.subFilters) {
					this._removeFilterKeys(item.leftExpression.subFilters);
				}
			}, this);
		},

		_convertFiltersFrom5x: function(filters, callback, scope) {
			const self = this;
			Terrasoft.FilterConverter.deserializeFilterEditData(filters, function(result) {
				self._removeFilterKeys(result.filterEditData);
				Ext.callback(callback, scope, [result.filterEditData]);
			}, this);
		},

		_convertFiltersTo5x: function(filters, callback, scope) {
			const deserializedFilters = Terrasoft.deserialize(filters);
			Terrasoft.FilterConverterConnector.convert(deserializedFilters, function(result) {
				Ext.callback(callback, scope, [result]);
			});
		},

		_convertMacrosListFiltersFrom5x: function(macrosList, callback, scope) {
			if (macrosList.length === 0) {
				Ext.callback(callback, scope, [macrosList]);
				return;
			}
			Terrasoft.chainForArray(macrosList, function(macros) {
				return function(next) {
					this._convertFiltersFrom5x(macros.subFilters, function(convertedFilters) {
						let serializationInfo = convertedFilters.getDefSerializationInfo();
						serializationInfo.serializeFilterManagerInfo = true;
						macros.subFilters = convertedFilters.serialize(serializationInfo);
						next();
					})
				};
			}, function() {
				Ext.callback(callback, scope, [macrosList]);
			}, this);
		},

		_convertMacrosListFiltersTo5x: function(macrosList, callback, scope) {
			if (macrosList.length === 0) {
				Ext.callback(callback, scope, [macrosList]);
				return;
			}
			Terrasoft.chainForArray(macrosList, function(macros) {
				return function(next) {
					this._convertFiltersTo5x(macros.subFilters, function(filters) {
						macros.subFilters = filters;
						next();
					})
				};
			}, function() {
				Ext.callback(callback, scope, [macrosList]);
			}, this);
		},

		_convertMacrosListFromAngularDto: function(value, callback, scope) {
			let macrosList = [];
			if (value) {
				macrosList = JSON5.parse(value);
				macrosList.forEach(function(macros) {
					macros.Id = Terrasoft.generateGUID();
					macros.dataValueType = this._getClientDataValueType(macros.dataValueType);
					macros.aggregationType = this._getClientAggregationType(macros.aggregationType);
					macros.sort = this._convertTo7xOrderDirection(macros.sort);
				}, this);
				this._convertMacrosListFiltersFrom5x(macrosList, callback, scope);
				return;
			}
			Ext.callback(callback, scope, [macrosList]);
		},

		_convertMacrosListToAngularDto: function(macrosListDto, callback, scope) {
			const macrosList = macrosListDto.map(function(macros) {
				const macrosDto = Terrasoft.deepClone(macros);
				macrosDto.dataValueType = this._getServerDataValueTypeName(macrosDto.dataValueType);
				macrosDto.aggregationType = this._getServerAggregationTypeName(macrosDto.aggregationType);
				macrosDto.sort = this._convertTo5xOrderDirection(macros.sort);
				delete macrosDto.Id;
				return macrosDto;
			}, this);
			this._convertMacrosListFiltersTo5x(macrosList, function(macrosList) {
				const angularMacrosListDto = JSON5.stringify(macrosList);
				Ext.callback(callback, scope, [angularMacrosListDto]);
			}, this);
		},

		_convertTablePartFromAngularDto: function(tablePart, callback, scope) {
			Terrasoft.chain(
				function(next) {
					this._convertMacrosListFromAngularDto(tablePart.macrosList, function(convertedMacrosList) {
						tablePart.macrosList = JSON.stringify(convertedMacrosList);
						next();
					}, this);
				},
				function() {
					this._convertFiltersFrom5x(tablePart.filter, function(convertedFilter) {
						tablePart.filter = convertedFilter.serialize({serializeFilterManagerInfo: true});
						callback.call(scope);
					});
				},
				this
			);
		},

		_convertTablePartToAngularDto: function(tablePart, callback, scope) {
			Terrasoft.chain(
				function(next) {
					const macrosList = JSON.parse(tablePart.macrosList);
					this._convertMacrosListToAngularDto(macrosList, function(convertedMacrosList) {
						tablePart.macrosList = convertedMacrosList;
						next();
					}, this);
				},
				function() {
					this._convertFiltersTo5x(tablePart.filter, function(convertedFilter) {
						tablePart.filter = convertedFilter;
						callback.call(scope);
					});
				},
				this
			);
		},

		_convertTablePartsFromAngularDto: function(angularTablePartsDto, callback, scope) {
			const tableParts = Terrasoft.deepClone(angularTablePartsDto);
			if (tableParts.length === 0) {
				Ext.callback(callback, scope, [tableParts]);
				return;
			}
			Terrasoft.chain(
				function(next) {
					Terrasoft.chainForArray(tableParts, function(tablePart) {
						return function(innerNext) {
							this._convertTablePartFromAngularDto(tablePart, innerNext, this);
						};
					}, next, this);
				},
				function() {
					Ext.callback(callback, scope, [tableParts]);
				},
				this
			);
		},

		_convertTablePartsToAngularDto: function(tablePartsDto, callback, scope) {
			if (tablePartsDto.length === 0) {
				Ext.callback(callback, scope, [tablePartsDto]);
				return;
			}
			Terrasoft.chain(
				function(next) {
					Terrasoft.chainForArray(tablePartsDto, function(tablePart) {
						return function(innerNext) {
							this._convertTablePartToAngularDto(tablePart, innerNext, this);
						};
					}, next, this);
				},
				function() {
					Ext.callback(callback, scope, [tablePartsDto]);
				},
				this
			);
		},

		convertFromAngularDto: function(isNew, dto, callback, scope) {
			Terrasoft.chain(
				function(next) {
					this._convertTablePartsFromAngularDto(dto.tableParts, function(tablePartsDto) {
						next({
							tablePartsDto: tablePartsDto
						});
					}, this);
				},
				function(next, convertedData) {
					this._convertMacrosListFromAngularDto(dto.macrosList, function(macrosListDto) {
						convertedData.macrosListDto = macrosListDto;
						next(convertedData);
					}, this);
				},
				function(next, convertedData) {
					const entityDto = {
						isNew: isNew,
						columnValues: {
							Id: dto.id,
							Caption: dto.caption,
							SysModule: dto.moduleId ? {value: dto.moduleId, displayValue: dto.moduleName} : null,
							ModuleSchemaName: dto.moduleSchemaName,
							Type: dto.typeId ? {value: dto.typeId, displayValue: dto.typeName} : null,
							ShowInSection: dto.showInSection,
							ShowInCard: dto.showInCard,
							ConvertInPDF: dto.convertInPDF,
							MacrosList: convertedData.macrosListDto,
							TableParts: convertedData.tablePartsDto
						}
					};
					Ext.callback(callback, scope, [entityDto]);
				},
				this
			);
		},

		convertToAngularDto: function(entityDto, callback, scope) {
			const columnValues = entityDto.columnValues;
			Terrasoft.chain(
				function(next) {
					this._convertTablePartsToAngularDto(columnValues.TableParts, function(tablePartsDto) {
						next({
							tablePartsDto: tablePartsDto
						});
					}, this);
				},
				function(next, convertedData) {
					this._convertMacrosListToAngularDto(columnValues.MacrosList, function(macrosListDto) {
						convertedData.macrosListDto = macrosListDto;
						next(convertedData);
					}, this);
				},
				function(next, convertedData) {
					const angularDto = {
						id: columnValues.Id,
						caption: columnValues.Caption,
						moduleId: columnValues.SysModule.value,
						moduleName: columnValues.SysModule.displayValue,
						typeId: columnValues.Type.value,
						typeName: columnValues.Type.displayValue,
						showInSection: columnValues.ShowInSection,
						showInCard: columnValues.ShowInCard,
						convertInPDF: columnValues.ConvertInPDF,
						macrosList: convertedData.macrosListDto,
						tableParts: convertedData.tablePartsDto
					};
					Ext.callback(callback, scope, [angularDto]);
				},
				this
			);
		},
	});

	return Terrasoft.WordPrintableConverter;
});
