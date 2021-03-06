﻿/**
 * @class Terrasoft.configuration.ProcessSchemaUserTaskUtilities
 * ProcessSchemaUserTaskUtilities class.
 */
define("ProcessSchemaUserTaskUtilities", ["ext-base", "terrasoft", "ProcessUserTaskConstants",
	"ProcessSchemaUserTaskUtilitiesResources"],
	function(Ext, Terrasoft, ProcessUserTaskConstants, resources) {
		const definedClass = Ext.ClassManager.get("Terrasoft.ProcessSchemaUserTaskUtilities");
		if (definedClass) {
			return Ext.create(definedClass);
		}
		const processSchemaUserTaskUtilities = Ext.define("Terrasoft.configuration.ProcessSchemaUserTaskUtilities", {
			extend: "Terrasoft.BaseObject",
			alternateClassName: "Terrasoft.ProcessSchemaUserTaskUtilities",

			/**
			 * UId of the process read data user task schema manager item.
			 * @type {String}
			 */
			ReadDataUserTaskSchemaUId: "cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f",

			/**
			 * UId of the process change admin rights user task schema manager item.
			 * @type {String}
			 */
			ChangeAdminRightsUserTaskSchemaUId: "0ebbb23c-f6db-45eb-ad13-a1445b7ef081",

			/**
			 * UId of the process autogenerated page user task schema manager item.
			 * @type {String}
			 */
			AutoGeneratedPageUserTaskSchemaUId: "b5936328-09b2-45fd-b763-48d37c265644",

			/**
			 * UId of the approval user task schema manager item.
			 * @type {String}
			 */
			ApprovalUserTaskSchemaUId: "51179e03-650d-4492-862d-9943005c26b4",

			/**
			 * UId of the activity user task schema manager item.
			 * @type {String}
			 */
			ActivityUserTaskSchemaUId: "b5c726f2-af5b-4381-bac6-913074144308",

			/**
			 * @private
			 */
			_getResultParameterByResultType: function(element) {
				const parameter = element.findParameterByName("ResultType");
				let resultParameter;
				switch (parameter.getValue()) {
					case ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.ENTITY:
						resultParameter = element.findParameterByName("ResultEntity");
						break;
					case ProcessUserTaskConstants.READ_DATA_RESULT_TYPE.ENTITY_COLLECTION:
						resultParameter = element.findParameterByName("ResultCompositeObjectList");
						break;
					default:
						resultParameter = null;
						break;
				}
				return resultParameter;
			},

			/**
			 * Finds result data of parameters for read data user task.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 * @return {Object || null}
			 */
			findReadDataUserTaskSchemaResultInfo: function(element) {
				const resultParameter = this.findResultParameter(element.parameters) ||
					this._getResultParameterByResultType(element);
				if (resultParameter) {
					const resultInfo = {resultParameters: []};
					if (resultParameter.dataValueType === Terrasoft.DataValueType.ENTITY) {
						resultInfo.resultParameter = resultParameter;
						const parameter = element.findParameterByName("EntityColumnMetaPathes");
						let metaPaths = parameter.getValue();
						if (!Ext.isEmpty(metaPaths)) {
							metaPaths = metaPaths.split(";");
							resultInfo.entitySchemaColumnUIds = metaPaths;
						}
						return resultInfo;
					}
					resultInfo.resultParameters = [resultParameter];
					return resultInfo;
				} else {
					return null;
				}
			},

			/**
			 * Returns result data of parameters for read data user task.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback scope.
			 */
			getReadDataUserTaskSchemaResultParametersInfo: function(element, callback, scope) {
				let resultInfo = this.findReadDataUserTaskSchemaResultInfo(element);
				if (resultInfo) {
					callback.call(scope, resultInfo);
					return;
				}
				resultInfo = {resultParameters: []};
				let resultParameter = null;
				const parameter = element.findParameterByName("FunctionType");
				const functionType = parameter.getValue();
				const aggregationType = Terrasoft.convertToServerAggregationType(Terrasoft.AggregationType.COUNT);
				if (functionType === aggregationType) {
					resultParameter = element.findParameterByName("ResultCount");
					resultInfo.resultParameters = [resultParameter];
					callback.call(scope, resultInfo);
					return;
				}
				const aggregateColumnNameParameter = element.findParameterByName("AggregationColumnName");
				const aggregateColumnName = aggregateColumnNameParameter.getValue();
				const resultEntityParameter = element.findParameterByName("ResultEntity");
				const referenceSchemaUId = resultEntityParameter.referenceSchemaUId;
				let dataValueType = null;
				const config = {
					schemaUId: referenceSchemaUId,
					packageUId: element.getPackageUId()
				};
				Terrasoft.EntitySchemaManager.findBundleSchemaInstance(config, function(schema) {
					if (schema) {
						schema.columns.each(function (column) {
							if (column.name === aggregateColumnName) {
								dataValueType = column.dataValueType;
								return false;
							}
						}, this);
					}
					if (dataValueType === Terrasoft.DataValueType.INTEGER) {
						resultParameter = element.findParameterByName("ResultIntegerFunction");
					} else if (Terrasoft.isNumberDataValueType(dataValueType)) {
						resultParameter = element.findParameterByName("ResultFloatFunction");
					} else if (Terrasoft.isDateDataValueType(dataValueType)) {
						resultParameter = element.findParameterByName("ResultDateTimeFunction");
					}
					resultInfo.resultParameters = resultParameter ? [resultParameter] : element.parameters.getItems();
					callback.call(scope, resultInfo);
				}, this);
			},

			/**
			 * Returns result parameter if it is found.
			 * @param {Array|Terrasoft.Collection} parameters Parameters of the element.
			 * @return {Terrasoft.ProcessSchemaParameter}
			 */
			findResultParameter: function(parameters) {
				if (!parameters) {
					return null;
				}
				let resultParameter = null;
				const items = parameters instanceof Terrasoft.Collection ? parameters.getItems() : parameters;
				Terrasoft.each(items, function (item) {
					if (item.isResult) {
						resultParameter = item;
						return false;
					}
				}, this);
				return resultParameter;
			},

			/**
			 * Returns result data of parameters.
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback scope.
			 */
			getResultParametersInfo: function(element, callback, scope) {
				if (element.managerItemUId === this.ReadDataUserTaskSchemaUId) {
					this.getReadDataUserTaskSchemaResultParametersInfo(element, callback, scope);
					return;
				}
				const parameters = element.getResultParameters();
				const resultInfo = {
					resultParameters: parameters
				};
				callback.call(scope, resultInfo);
			},

			/**
			 * Generates unique element name by prefix.
			 * @param {String} prefix Prefix name.
			 * @param {Terrasoft.Collection} collection of items.
			 * @param {Function} filterFn Filter function.
			 * @return {String}
			 * @example
			 * var filterFn = function(item, name) {
			 *     return item.name === name;
			 * };
			 * var name = parentSchema.generateItemUniqueName("Button", buttonsCollection, filterFn);
			 */
			generateItemUniqueName: function(prefix, collection, filterFn, startIndex) {
				let counter = startIndex || 1;
				let name = prefix + counter;
				const internalFilterFn = function(item) {
					return filterFn(item, name);
				};
				do {
					const filteredItems = collection.filterByFn(internalFilterFn);
					if (filteredItems.getCount() === 0) {
						return name;
					}
					counter++;
					name = prefix + counter;
				} while (true);
			},

			/**
			 * Validates mapping value.
			 * @public
			 * @param  {Object} value Mapping value.
			 * @return {Object} Validation info.
			 * @return {Object} return.isValid Validation result.
			 * @return {Object} return.invalidMessage Validation message.
			 */
			validateMappingValue: function(value) {
				const fieldValue = Ext.isObject(value) ? value.value : null;
				const isValid = !Ext.isEmpty(fieldValue);
				const message = resources.localizableStrings.ValidateMappingFieldInvalidMessage;
				const validationInfo = {
					isValid: isValid,
					invalidMessage: isValid ? "" : message
				};
				return validationInfo;
			}
		});

		return Ext.create(processSchemaUserTaskUtilities);
	});
