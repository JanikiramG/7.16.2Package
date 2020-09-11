﻿define('EditPageDesignerGroupEdit', ['EditPageDesignerGroupEditResources'],
	function(resources) {
		function createConstructor(context) {

			var Ext = context.Ext;
			var sandbox = context.sandbox;
			var Terrasoft = context.Terrasoft;
			var viewModel;

			function init() {

				var state = sandbox.publish('GetHistoryState');
				var currentHash = state.hash;
				var currentState = state.state || {};
				if (currentState.moduleId === sandbox.id) {
					return;
				}
				sandbox.publish('ReplaceHistoryState', {
					stateObj: {
						moduleId: sandbox.id
					},
					pageTitle: null,
					hash: currentHash.historyState,
					silent: true
				});
			}
			function render(renderTo) {
				var params = {
					name: Terrasoft.generateGUID(),
					HeaderCaption: resources.localizableStrings.HeaderText,
					GroupLabelCaption: null,
					caption: null
				};
				Ext.apply(params, sandbox.publish('GetGroupConfig', null, [sandbox.id]));
				viewModel = createViewModel(params);
				var viewConfig = getViewConfig();
				var view = Ext.create(viewConfig.className || 'Terrasoft.Container', viewConfig);
				view.bind(viewModel);
				view.render(renderTo);
			}

			function getContainerConfig(id, wrapClass) {
				var container = {
					className: 'Terrasoft.Container',
					items: [],
					id: id,
					selectors: {
						wrapEl: '#' + id
					}
				};
				if (!Ext.isEmpty(wrapClass)) {
					container.classes = {
						wrapClassName: wrapClass
					};
				}
				return container;
			}
			function getViewConfig() {
				var viewConfig = getContainerConfig('autoGeneratedContainer');
				var headerConfig = getContainerConfig('header');
				var utilsConfig = getContainerConfig('utils');
				var itemsContainerConfig = getContainerConfig('itemsContainerConfig');
				headerConfig.items = [
					{
						className: 'Terrasoft.Label',
						caption: {
							bindTo: 'HeaderCaption'
						},
						classes: {
							labelClass: ['header-name']
						},
						width: 'auto'
					}
				];
				utilsConfig.items = [{
					className: 'Terrasoft.Container',
					id: 'utils-left',
					selectors: {
						wrapEl: '#utils-left'
					},
					items: [{
						className: 'Terrasoft.Button',
						margin: '0px 10px 0px 0px',
						caption: resources.localizableStrings.SaveButtonText,
						style: Terrasoft.controls.ButtonEnums.style.GREEN,
						click: {
							bindTo: 'save'
						}
					}, {
						className: 'Terrasoft.Button',
						margin: '0px 10px 0px 0px',
						style: Terrasoft.controls.ButtonEnums.style.DEFAULT,
						caption: resources.localizableStrings.CancelButtonText,
						click: {
							bindTo: 'cancel'
						}
					}]
				}];
				itemsContainerConfig.items = [{
					className: 'Terrasoft.Label',
					caption: resources.localizableStrings.GroupCaption,
					classes: {
						labelClass: ['object-header-name']
					}
				}, {
					className: 'Terrasoft.TextEdit',
					id: 'GroupCaption',
					selectors: {
						wrapEl: '#GroupCaption'

					},
					value: {
						bindTo: 'caption'
					},
					focused: true
				}];
				viewConfig.items = [headerConfig, utilsConfig, itemsContainerConfig];
				return viewConfig;
			}
			function createViewModel(values) {
				return Ext.create('Terrasoft.BaseViewModel', {
						values: values,
						methods: {
							cancel: function() {
								sandbox.publish('BackHistoryState');
							},
							save: function() {
								var result = {
									caption: this.get('caption'),
									name: this.get('name')
								};
								sandbox.publish('GroupEdited', result, [sandbox.id]);
								sandbox.publish('BackHistoryState');
							}
						}
					}
				);
			}
			return Ext.define('StructureExploreModule', {
				init: init,
				render: render
			});
		}
		return createConstructor;
	});
