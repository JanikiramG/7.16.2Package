define("LeadTypePageV2", ["LeadTypePageV2Resources"], function(resources) {
	return {
		entitySchemaName: "LeadType",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Name",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 2,
						"row": 0,
						"colSpan": 12,
						"rowSpan": 1,
						"layoutName": "Header"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "ImageContainer",
				"values": {
					"itemType": this.Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["image-edit-container"],
					"layout": {
						"column": 0,
						"row": 0,
						"rowSpan": 2,
						"colSpan": 2
					},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "Description",
				"parentName": "Header",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 2,
						"row": 1,
						"colSpan": 12,
						"rowSpan": 1,
						"layoutName": "Header"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "ImageContainer",
				"propertyName": "items",
				"name": "Image",
				"values": {
					"getSrcMethod": "getSrcMethod",
					"onPhotoChange": "onImageChange",
					"beforeFileSelected": "beforeFileSelected",
					"readonly": false,
					"defaultImage": {"bindTo": "getDefaultImageURL"},
					"generator": "ImageCustomGeneratorV2.generateCustomImageControl"
				}
			}
		]/**SCHEMA_DIFF*/,
		methods: {
			/**
			 * ########## web-##### ###########.
			 * @private
			 * @return {String} Web-##### ###########.
			 */
			getSrcMethod: function() {
				var primaryImageColumnValue = this.get(this.primaryImageColumnName);
				if (primaryImageColumnValue) {
					return this.getSchemaImageUrl(primaryImageColumnValue);
				}
				return this.getDefaultImageURL();
			},

			/**
			 * Returns default image url.
			 * @return {String} Default image url.
			 */
			getDefaultImageURL: function() {
				return this.Terrasoft.ImageUrlBuilder.getUrl(resources.localizableImages.DefaultPhoto);
			},

			/**
			 * ############ ######### ###########.
			 * @private
			 * @param {File} image ###########.
			 */
			onImageChange: function(image) {
				if (!image) {
					this.set(this.primaryImageColumnName, null);
					return;
				}
				this.Terrasoft.ImageApi.upload({
					file: image,
					onComplete: this.onImageUploaded,
					onError: this.Terrasoft.emptyFn,
					scope: this
				});
			},

			/**
			 * ######### ##### ########### ##### ### ########## # #### ######.
			 * @private
			 * @param {String} imageId ############# ###########.
			 */
			onImageUploaded: function(imageId) {
				var imageData = {
					value: imageId,
					displayValue: this.primaryImageColumnName
				};
				this.set("Image", imageData);
			}
		},
		rules: {}
	};
});
