﻿define("ContentPanelLoader", [], function() {
	return {
		messages: {
			/**
			 * @message ActiveContentItemChanged
			 * Receives config of actual content item.
			 */
			ActiveContentItemChanged: {
				mode: Terrasoft.MessageMode.BROADCAST,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message ContentItemConfigChanged.
			 * Actualize current config.
			 */
			ContentItemConfigChanged: {
				mode: Terrasoft.MessageMode.BROADCAST,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},

			/**
			 * @message RightPanelLoaded
			 * Sends signal of loaded panel.
			 */
			RightPanelLoaded: {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}

		},
		attributes: {
			"PanelAttributes": {
				dataValueType: this.Terrasoft.DataValueType.CUSTOM_OBJECT
			},
			/**
			 * Flag to indicate that config is for MJML.
			 */
			"IsMjmlConfig": {
				dataValueType: this.Terrasoft.DataValueType.BOOLEAN
			}
		},
		properties: {
			sandboxId: "ContentPanelLoader"
		},
		methods: {
			/**
			 * @private
			 */
			_onContentItemChanged: Terrasoft.throttle(function(itemConfig) {
				var moduleId = this.sandbox.id + "ContentPanelModule";
				var element;
				if (itemConfig.ElementInfo && this.$IsMjmlConfig) {
					element = itemConfig.ElementInfo;
				} else {
					var manager = new Terrasoft.ContentElementManager();
					element = manager.findByType(itemConfig.ItemType);
				}
				var elementSettings = element && element.Settings;
				if (elementSettings) {
					var isStylesVisible = elementSettings.isStylesVisible;
					var useBackgroundImage = elementSettings.useBackgroundImage;
					if (isStylesVisible && useBackgroundImage !== undefined) {
						itemConfig.UseBackgroundImage = useBackgroundImage;
					}
				}
				var prevItemType = this.$PanelAttributes && this.$PanelAttributes["data-item-type"];
				this.$PanelAttributes = {
					"data-item-type": itemConfig.ItemType,
					"data-page-exists": Boolean(elementSettings && !Ext.isEmpty(elementSettings.schemaName))
				};
				if (prevItemType !== itemConfig.ItemType) {
					this.sandbox.loadModule("ContentPanelModule", {
						renderTo: "PanelContainer",
						moduleId: moduleId,
						instanceConfig: {
							parameters: {
								viewModelConfig: {
									Config: itemConfig,
									ElementInfo: element
								}
							}
						}
					});
				} else {
					this.sandbox.publish("ContentItemConfigChanged", itemConfig, ["PropertiesPage"]);
				}
			}, 500),

			/**
			 * @inheritdoc BaseSchemaViewModel#init
			 * @overridden
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.sandbox.subscribe("ActiveContentItemChanged", this._onContentItemChanged, this,
						[this.sandboxId]);
					Ext.callback(callback, scope);
				}, this]);
			},

			/**
			 * @inheritDoc
			 * @overridden
			 */
			onRender: function() {
				this.callParent(arguments);
				this.sandbox.publish("RightPanelLoaded", null, [this.sandboxId]);
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "PanelContainer",
				"values": {
					"id": "PanelContainer",
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"wrapClass": ["content-panel-wrapper"],
					"domAttributes": "$PanelAttributes"
				}
			}
		]
	};
});
