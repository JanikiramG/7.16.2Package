{
	"CustomSchemas": [
		"MobileActivityActionsUtilities",
		"MobileActivityCacheManager",
		"MobileSysAdminUnitCacheManager"
	],
	"SyncOptions": {
		"ModelDataImportConfig": [
			{
				"Name": "Activity",
				"SyncFilter": {
					"property": "Participant",
					"modelName": "ActivityParticipant",
					"assocProperty": "Activity",
					"operation": "Terrasoft.FilterOperations.Any",
					"valueIsMacros": true,
					"value": "Terrasoft.ValueMacros.CurrentUserContact"
				},
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "Activity",
					"items": {
						"ActivityParticipant": {
							"filterType": 5,
							"subFilters": {
								"logicalOperation": 0,
								"filterType": 6,
								"rootSchemaName": "ActivityParticipant",
								"items": {
									"detailedFilter": {
										"filterType": 1,
										"rightExpression": {
											"expressionType": 1,
											"functionType": 1,
											"macrosType": 2
										},
										"leftExpression": {
											"expressionType": 0,
											"columnPath": "Participant"
										},
										"comparisonType": 3
									}
								}
							},
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "[ActivityParticipant:Activity].Id"
							}
						}
					}
				},
				"ExpandLookups": true,
				"SyncColumns": [
					"Title",
					"StartDate",
					"DueDate",
					"Status",
					"Result",
					"DetailedResult",
					"ActivityCategory",
					"Priority",
					"Owner",
					"Account",
					"Contact",
					"ShowInScheduler",
					"Author",
					"Type",
					"AllowedResult",
					"ProcessElementId"
				]
			},
			{
				"Name": "ActivityParticipant",
				"SyncByParentObjectWithRights": "Activity",
				"HistoricalColumns": ["Activity.ModifiedOn"],
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "ActivityParticipant",
					"items": {
						"ActivityFilter": {
							"filterType": 5,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "Activity.[ActivityParticipant:Activity].Id"
							},
							"subFilters": {
								"logicalOperation": 0,
								"filterType": 6,
								"rootSchemaName": "ActivityParticipant",
								"items": {
									"ParticipantFilter": {
										"filterType": 1,
										"comparisonType": 3,
										"leftExpression": {
											"expressionType": 0,
											"columnPath": "Participant"
										},
										"rightExpression": {
											"expressionType": 1,
											"functionType": 1,
											"macrosType": 2
										}
									}
								}
							}
						}
					}
				},
				"ExpandLookups": ["Participant"],
				"SyncColumns": [
					"Activity",
					"Participant",
					"Participant.Photo"
				]
			},
			{
				"Name": "ActivityCategoryResultEntry",
				"SyncColumns": [
					"ActivityResult",
					"ActivityCategory"
				]
			},
			{
				"Name": "ActivityCorrespondence",
				"SyncColumns": [
					"Activity",
					"IsDeleted",
					"SourceActivityId",
					"SourceAccount",
					"CreatedInBPMonline"
				]
			},
			{
				"Name": "Contact",
				"ExpandLookups": true,
				"RequiredDataFilter": {
					"filterType": 6,
					"rootSchemaName": "Contact",
					"logicalOperation": 0,
					"items": {
						"CurrentContact": {
							"filterType": 1,
							"comparisonType": 3,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "Id"
							},
							"rightExpression": {
								"expressionType": 1,
								"functionType": 1,
								"macrosType": 2
							}
						}
					}
				},
				"SyncColumns": [
					"Name",
					"Account",
					"Department",
					"JobTitle",
					"Photo",
					"Job"
				]
			},
			{
				"Name": "ContactAddress",
				"SyncByParentObjectWithRights": "Contact",
				"SyncColumns": [
					"AddressType",
					"Country",
					"Region",
					"City",
					"Address",
					"Zip",
					"Contact",
					"Primary"
				]
			},
			{
				"Name": "ContactAnniversary",
				"SyncByParentObjectWithRights": "Contact",
				"SyncColumns": [
					"Date",
					"AnniversaryType",
					"Contact"
				]
			},
			{
				"Name": "ContactCommunication",
				"SyncByParentObjectWithRights": "Contact",
				"SyncColumns": [
					"Number",
					"CommunicationType",
					"Contact",
					"SearchNumber"
				]
			},
			{
				"Name": "Account",
				"ExpandLookups": true,
				"SyncColumns": [
					"Name",
					"PrimaryContact",
					"Industry",
					"GPSN",
					"GPSE",
					"Address",
					"Type",
					"AccountCategory"
				]
			},
			{
				"Name": "AccountAddress",
				"SyncByParentObjectWithRights": "Account",
				"SyncColumns": [
					"AddressType",
					"Country",
					"Region",
					"City",
					"Address",
					"Zip",
					"Account",
					"Primary"
				]
			},
			{
				"Name": "AccountAnniversary",
				"SyncByParentObjectWithRights": "Account",
				"SyncColumns": [
					"Date",
					"AnniversaryType",
					"Account"
				]
			},
			{
				"Name": "AccountCommunication",
				"SyncByParentObjectWithRights": "Account",
				"SyncColumns": [
					"Number",
					"CommunicationType",
					"Account"
				]
			},
			{
				"Name": "SysImage",
				"SyncFilter": {
					"property": "HasRef",
					"value": true
				},
				"QueryFilter": {
					"logicalOperation": 0,
					"filterType": 6,
					"rootSchemaName": "SysImage",
					"items": {
						"ExistContactPhoto": {
							"filterType": 5,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "[Contact:Photo].Id"
							},
							"subFilters": {
								"items": {},
								"logicalOperation": 0,
								"filterType": 6,
								"rootSchemaName": "Contact"
							}
						}
					}
				},
				"RequiredDataFilter": {
					"filterType": 6,
					"rootSchemaName": "SysImage",
					"logicalOperation": 0,
					"items": {
						"CurrentContact": {
							"filterType": 1,
							"comparisonType": 3,
							"leftExpression": {
								"expressionType": 0,
								"columnPath": "[Contact:Photo].Id"
							},
							"rightExpression": {
								"expressionType": 1,
								"functionType": 1,
								"macrosType": 2
							}
						}
					}
				},
				"SyncColumns": [
					"Name",
					"HasRef",
					{
						"Name": "PreviewData",
						"UseRecordIdAsFileName": true,
						"ImportBinaryData": true
					}
				]
			},
			"FileType",
			{
				"Name": "Department",
				"SyncColumns": []
			},
			{
				"Name": "ActivityPriority",
				"SyncColumns": []
			},
			{
				"Name": "ActivityType",
				"SyncColumns": []
			},
			{
				"Name": "ActivityCategory",
				"SyncColumns": [
					"ActivityType"
				]
			},
			{
				"Name": "ActivityStatus",
				"SyncColumns": [
					"Finish"
				]
			},
			{
				"Name": "CommunicationType",
				"SyncColumns": [
					"UseforContacts",
					"UseforAccounts"
				]
			},
			{
				"Name": "AddressType",
				"SyncColumns": [
					"ForAccount",
					"ForContact"
				]
			},
			{
				"Name": "Country",
				"SyncColumns": []
			},
			{
				"Name": "Region",
				"SyncColumns": [
					"Country"
				]
			},
			{
				"Name": "City",
				"SyncColumns": [
					"Country",
					"Region"
				]
			},
			{
				"Name": "AnniversaryType",
				"SyncColumns": []
			},
			{
				"Name": "AccountIndustry",
				"SyncColumns": []
			},
			{
				"Name": "ActivityResult",
				"SyncColumns": [
					"Category"
				]
			},
			{
				"Name": "ActivityParticipantRole",
				"SyncColumns": [
					"Code"
				]
			},
			{
				"Name": "KnowledgeBase",
				"SyncColumns": [
					"Code",
					"Type"
				]
			},
			{
				"Name": "KnowledgeBaseType",
				"SyncColumns": [
					"Description"
				]
			},
			{
				"Name": "KnowledgeBaseFile",
				"SyncColumns": [
					"Notes",
					{
						"Name": "Data",
						"UseRecordIdAsFileName": false,
						"ImportBinaryData": true
					},
					"Type",
					"KnowledgeBase"
				]
			},
			{
				"Name": "Job",
				"SyncColumns": []
			},
			{
				"Name": "AccountType",
				"SyncColumns": []
			},
			{
				"Name": "AccountCategory",
				"SyncColumns": []
			}
		]
	},
	"Models": {
		"Activity": {
			"Grid": "MobileActivityGridPage",
			"Preview": "MobileActivityPreviewPage",
			"Edit": "MobileActivityEditPage",
			"RequireLookupColumnsModels": true,
			"RequiredModels": [
				"Activity",
				"Account",
				"ActivityCategory",
				"ActivityCategoryResultEntry",
				"ActivityPriority",
				"ActivityParticipant",
				"ActivityParticipantRole",
				"ParticipantResponse",
				"ActivityResult",
				"ActivityStatus",
				"ActivityType",
				"Contact",
				"SysImage",
				"SysAdminUnit",
				"ActivityCorrespondence",
				"FileType",
				"EmailSendStatus",
				"EmailType",
				"KnowledgeBase",
				"KnowledgeBaseType",
				"KnowledgeBaseFile",
				"CallDirection"
			],
			"ModelExtensions": [
				"MobileActivityModelConfig"
			],
			"PagesExtensions": [
				"MobileActivityRecordPageSettingsDefaultWorkplace",
				"MobileActivityGridPageSettingsDefaultWorkplace",
				"MobileActivityActionsSettingsDefaultWorkplace",
				"MobileActivityModuleConfig",
				"MobileActivityImportHelper",
				"MobileActivityGridPageDataV2",
				"MobileActivityGridPageViewV2",
				"MobileActivityGridPageControllerV2"
			]
		},
		"Contact": {
			"Preview": "MobileContactPreviewPage",
			"RequiredModels": [
				"Account",
				"Contact",
				"ContactCommunication",
				"CommunicationType",
				"Department",
				"ContactAddress",
				"AddressType",
				"Country",
				"Region",
				"City",
				"ContactAnniversary",
				"AnniversaryType",
				"Activity",
				"SysImage",
				"FileType",
				"ActivityPriority",
				"ActivityType",
				"ActivityCategory",
				"ActivityStatus",
				"Job"
			],
			"ModelExtensions": [],
			"PagesExtensions": [
				"MobileContactRecordPageSettingsDefaultWorkplace",
				"MobileContactGridPageSettingsDefaultWorkplace",
				"MobileContactActionsSettingsDefaultWorkplace",
				"MobileContactModuleConfig"
			]
		},
		"Account": {
			"Preview": "MobileAccountPreviewPage",
			"RequiredModels": [
				"Account",
				"Contact",
				"AccountIndustry",
				"Activity",
				"AccountCommunication",
				"CommunicationType",
				"AccountAddress",
				"AccountAnniversary",
				"ActivityResult",
				"ActivityCategory",
				"ActivityPriority",
				"ActivityType",
				"ActivityStatus",
				"ActivityCategoryResultEntry",
				"AddressType",
				"AnniversaryType",
				"City",
				"Country",
				"Region",
				"SysImage",
				"FileType",
				"AccountType",
				"AccountCategory"
			],
			"ModelExtensions": [
				"MobileAccountModelConfig"
			],
			"PagesExtensions": [
				"MobileAccountRecordPageSettingsDefaultWorkplace",
				"MobileAccountGridPageSettingsDefaultWorkplace",
				"MobileAccountActionsSettingsDefaultWorkplace",
				"MobileAccountModuleConfig"
			]
		},
		"SysDashboard": {
			"CacheConfig": {
				"Disable": true
			},
			"RequiredModels": [
				"SysDashboard",
				"SysModule"
			]
		},
		"ContactAddress": {
			"ModelExtensions": [
				"MobileContactAddressModelConfig"
			]
		},
		"AccountAddress": {
			"ModelExtensions": [
				"MobileAccountAddressModelConfig"
			]
		},
		"ContactCommunication": {
			"ModelExtensions": [
				"MobileContactCommunicationModelConfig"
			]
		},
		"ContactAnniversary": {
			"ModelExtensions": [
				"MobileContactAnniversaryModelConfig"
			]
		},
		"AccountCommunication": {
			"ModelExtensions": [
				"MobileAccountCommunicationModelConfig"
			]
		},
		"AccountAnniversary": {
			"ModelExtensions": [
				"MobileAccountAnniversaryModelConfig"
			]
		},
		"ActivityParticipant": {
			"Grid": "MobileActivityParticipantGridPage",
			"ModelExtensions": [
				"MobileActivityParticipantModelConfig"
			],
			"PagesExtensions": [
				"MobileActivityParticipantGridPageView",
				"MobileActivityParticipantGridPageController",
				"MobileActivityParticipantModuleConfig"
			]
		},
		"KnowledgeBase": {
			"RequiredModels": [
				"KnowledgeBase",
				"KnowledgeBaseType",
				"FileType",
				"KnowledgeBaseFile"
			],
			"PagesExtensions": [
				"MobileKnowledgeBaseModuleConfig"
			]
		},
		"KnowledgeBaseType": {
			"RequiredModels": [
				"KnowledgeBaseType"
			]
		},
		"KnowledgeBaseFile": {
			"RequiredModels": [
				"KnowledgeBaseFile",
				"KnowledgeBaseType"
			],
			"ModelExtensions": [
				"MobileKnowledgeBaseFileModelConfig"
			]
		}
	}
}