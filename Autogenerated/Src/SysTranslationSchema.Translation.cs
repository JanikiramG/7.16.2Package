namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.Translation;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Translation;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SysTranslationSchema

	/// <exclude/>
	public class SysTranslationSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysTranslationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysTranslationSchema(SysTranslationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysTranslationSchema(SysTranslationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateSysTranslationKeyIndexIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("b020e659-d03e-460f-ab19-1eac2eb6cdaf");
			index.Name = "SysTranslationKeyIndex";
			index.CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951");
			index.ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951");
			index.CreatedInPackageId = new Guid("e7665219-c7e8-455d-bf4f-2274803999e4");
			EntitySchemaIndexColumn keyIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("c8bc4d42-2e51-487f-8804-2525880becba"),
				ColumnUId = new Guid("4e54682a-31c5-4ec3-b1e9-d291901bfc9e"),
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("e7665219-c7e8-455d-bf4f-2274803999e4"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(keyIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951");
			RealUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951");
			Name = "SysTranslation";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateKeyColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2ec7a8e1-bda1-45f1-8038-8c9d6ee310ed")) == null) {
				Columns.Add(CreateLanguage0Column());
			}
			if (Columns.FindByUId(new Guid("d6083d73-a1ce-4f49-8cb8-01de8db77af6")) == null) {
				Columns.Add(CreateLanguage1Column());
			}
			if (Columns.FindByUId(new Guid("113fb377-47d2-444b-b8d4-0847dbb63ca3")) == null) {
				Columns.Add(CreateLanguage2Column());
			}
			if (Columns.FindByUId(new Guid("7a63c135-6350-4e15-af20-ae7553afd1e9")) == null) {
				Columns.Add(CreateLanguage3Column());
			}
			if (Columns.FindByUId(new Guid("db708816-23d4-43bd-8eb7-5f46a021f2c3")) == null) {
				Columns.Add(CreateLanguage4Column());
			}
			if (Columns.FindByUId(new Guid("a1deada4-b1d5-4d72-b92b-5ee7a9dcf808")) == null) {
				Columns.Add(CreateLanguage5Column());
			}
			if (Columns.FindByUId(new Guid("e02df9b3-41a3-48f2-ada7-f646b4e6cf46")) == null) {
				Columns.Add(CreateLanguage6Column());
			}
			if (Columns.FindByUId(new Guid("7a28646b-7a1d-46fd-a095-638905442eaf")) == null) {
				Columns.Add(CreateLanguage7Column());
			}
			if (Columns.FindByUId(new Guid("312972d9-b3a7-4647-9e3f-ef1dd53867bf")) == null) {
				Columns.Add(CreateLanguage8Column());
			}
			if (Columns.FindByUId(new Guid("a159185b-84dd-4fe8-a21b-e27b7f1ae509")) == null) {
				Columns.Add(CreateLanguage9Column());
			}
			if (Columns.FindByUId(new Guid("5551a508-bb63-4e92-abcc-459226c10967")) == null) {
				Columns.Add(CreateIsVerified0Column());
			}
			if (Columns.FindByUId(new Guid("f9fd8b05-9437-499a-bd61-4fb757c5e93a")) == null) {
				Columns.Add(CreateIsVerified1Column());
			}
			if (Columns.FindByUId(new Guid("70ebca63-31fd-4660-aca0-f121d8364f8d")) == null) {
				Columns.Add(CreateIsVerified2Column());
			}
			if (Columns.FindByUId(new Guid("8ba15eda-adf6-40cd-a328-5486b63e7e83")) == null) {
				Columns.Add(CreateIsVerified3Column());
			}
			if (Columns.FindByUId(new Guid("67ad9d20-ff6c-4be5-bdcd-c88425f2b88c")) == null) {
				Columns.Add(CreateIsVerified4Column());
			}
			if (Columns.FindByUId(new Guid("127a8bf4-4468-4cab-b3ff-7c2337e9c0ec")) == null) {
				Columns.Add(CreateIsVerified5Column());
			}
			if (Columns.FindByUId(new Guid("4bf92d3a-9799-4ae3-9540-13a4ae135ce2")) == null) {
				Columns.Add(CreateIsVerified6Column());
			}
			if (Columns.FindByUId(new Guid("5052c476-9f8e-4220-95fa-c75d1042b7d0")) == null) {
				Columns.Add(CreateIsVerified7Column());
			}
			if (Columns.FindByUId(new Guid("c0297e29-a2e8-43a8-8537-d8a92a358fb9")) == null) {
				Columns.Add(CreateIsVerified8Column());
			}
			if (Columns.FindByUId(new Guid("cf773afc-033f-48db-99de-d52c78c848cf")) == null) {
				Columns.Add(CreateIsVerified9Column());
			}
			if (Columns.FindByUId(new Guid("8cb78c5b-b362-4c6d-ae55-665a29ebbec0")) == null) {
				Columns.Add(CreateIsChanged0Column());
			}
			if (Columns.FindByUId(new Guid("db362f56-b1ec-4efc-b1a6-f25ac4e66c9c")) == null) {
				Columns.Add(CreateIsChanged1Column());
			}
			if (Columns.FindByUId(new Guid("249f0a0e-5b79-445d-ae09-62c431e62802")) == null) {
				Columns.Add(CreateIsChanged2Column());
			}
			if (Columns.FindByUId(new Guid("1f10ced2-9735-498e-a313-5c798e0c48e2")) == null) {
				Columns.Add(CreateIsChanged3Column());
			}
			if (Columns.FindByUId(new Guid("f3a685ec-f704-4e02-bff9-5d7b62a99548")) == null) {
				Columns.Add(CreateIsChanged4Column());
			}
			if (Columns.FindByUId(new Guid("90f169b1-6f0a-498f-8f6e-a8c1d429e39c")) == null) {
				Columns.Add(CreateIsChanged5Column());
			}
			if (Columns.FindByUId(new Guid("472f1dc3-eac2-4f2c-8831-366cc3eaf84c")) == null) {
				Columns.Add(CreateIsChanged6Column());
			}
			if (Columns.FindByUId(new Guid("2cb95690-896f-486c-8be4-5dff742fffec")) == null) {
				Columns.Add(CreateIsChanged7Column());
			}
			if (Columns.FindByUId(new Guid("88a18436-7505-4c77-9bef-a44e2dbea4b6")) == null) {
				Columns.Add(CreateIsChanged8Column());
			}
			if (Columns.FindByUId(new Guid("584d8f47-54e4-44dd-882b-01c6ed74c2ef")) == null) {
				Columns.Add(CreateIsChanged9Column());
			}
			if (Columns.FindByUId(new Guid("b660805a-93ce-4205-8c07-5ea919badfb0")) == null) {
				Columns.Add(CreateLanguage10Column());
			}
			if (Columns.FindByUId(new Guid("2895cab7-493e-4fa0-b4c8-feccfeab8d16")) == null) {
				Columns.Add(CreateLanguage11Column());
			}
			if (Columns.FindByUId(new Guid("25f36736-1938-4fa4-996d-bb17f6933fc3")) == null) {
				Columns.Add(CreateLanguage12Column());
			}
			if (Columns.FindByUId(new Guid("60838d5f-7537-44fd-ad1f-4bdb50a54541")) == null) {
				Columns.Add(CreateLanguage13Column());
			}
			if (Columns.FindByUId(new Guid("b3ee34f3-ce8d-436f-b675-cd8c9c224df8")) == null) {
				Columns.Add(CreateLanguage14Column());
			}
			if (Columns.FindByUId(new Guid("7a937094-5dc2-4a32-95da-06e00f1139e0")) == null) {
				Columns.Add(CreateLanguage15Column());
			}
			if (Columns.FindByUId(new Guid("35d10ee8-41dc-48bf-8659-568cdef39c0a")) == null) {
				Columns.Add(CreateLanguage16Column());
			}
			if (Columns.FindByUId(new Guid("8c82395d-354d-451d-aad9-ec3ebf5de014")) == null) {
				Columns.Add(CreateLanguage17Column());
			}
			if (Columns.FindByUId(new Guid("e9ed5185-278f-4a43-a061-29e948852e32")) == null) {
				Columns.Add(CreateLanguage18Column());
			}
			if (Columns.FindByUId(new Guid("31388a0e-8db5-4496-aa7a-04303f7fe5fd")) == null) {
				Columns.Add(CreateLanguage19Column());
			}
			if (Columns.FindByUId(new Guid("d416a27a-0a72-4638-813e-9feff82b71cc")) == null) {
				Columns.Add(CreateLanguage20Column());
			}
			if (Columns.FindByUId(new Guid("bf358b7e-6e84-43d1-9150-d65f579aea87")) == null) {
				Columns.Add(CreateLanguage21Column());
			}
			if (Columns.FindByUId(new Guid("ff995c89-7283-44bd-b06e-a5c402b02988")) == null) {
				Columns.Add(CreateLanguage22Column());
			}
			if (Columns.FindByUId(new Guid("e0eef4f9-5d80-42c3-a213-d9b2316819a7")) == null) {
				Columns.Add(CreateLanguage23Column());
			}
			if (Columns.FindByUId(new Guid("c97d0e51-e6e4-459f-ab83-de017c36ab2f")) == null) {
				Columns.Add(CreateLanguage24Column());
			}
			if (Columns.FindByUId(new Guid("99ff77a8-b873-4ce0-bb20-64696be2c627")) == null) {
				Columns.Add(CreateLanguage25Column());
			}
			if (Columns.FindByUId(new Guid("3b872cdb-cd76-4891-992d-da4b5337ded6")) == null) {
				Columns.Add(CreateLanguage26Column());
			}
			if (Columns.FindByUId(new Guid("bfdd9315-a491-4272-b9c2-e1dc49b85ba5")) == null) {
				Columns.Add(CreateLanguage27Column());
			}
			if (Columns.FindByUId(new Guid("d7f3dd56-94fe-4922-9974-37db8bdf932b")) == null) {
				Columns.Add(CreateLanguage28Column());
			}
			if (Columns.FindByUId(new Guid("7fba7ad8-cb09-46b7-aa22-4fced486e021")) == null) {
				Columns.Add(CreateLanguage29Column());
			}
			if (Columns.FindByUId(new Guid("e14a9e9b-cc27-42f5-bbda-5bba8348a5ca")) == null) {
				Columns.Add(CreateLanguage30Column());
			}
			if (Columns.FindByUId(new Guid("363ce737-e745-4c50-ab60-75214785f4d8")) == null) {
				Columns.Add(CreateIsVerified10Column());
			}
			if (Columns.FindByUId(new Guid("a9555a78-3734-4fb7-b5b9-ea000313d4a1")) == null) {
				Columns.Add(CreateIsVerified11Column());
			}
			if (Columns.FindByUId(new Guid("72f0c330-fd85-4c81-bf09-e846eaf0e01c")) == null) {
				Columns.Add(CreateIsVerified12Column());
			}
			if (Columns.FindByUId(new Guid("1a8e092e-4f69-4adb-8318-e06815073178")) == null) {
				Columns.Add(CreateIsVerified13Column());
			}
			if (Columns.FindByUId(new Guid("c8601f44-b46c-4080-8ed9-d388be1e9a43")) == null) {
				Columns.Add(CreateIsVerified14Column());
			}
			if (Columns.FindByUId(new Guid("5f701f56-4cae-460d-a8f0-08f3e4255e77")) == null) {
				Columns.Add(CreateIsVerified15Column());
			}
			if (Columns.FindByUId(new Guid("5ee1b637-4766-40da-98a0-a3a8dd6a3df3")) == null) {
				Columns.Add(CreateIsVerified16Column());
			}
			if (Columns.FindByUId(new Guid("8c14177f-643c-4f56-ac50-edfdc50b74ff")) == null) {
				Columns.Add(CreateIsVerified17Column());
			}
			if (Columns.FindByUId(new Guid("6f35fc91-a078-461f-b7a2-65d79fad86e3")) == null) {
				Columns.Add(CreateIsVerified18Column());
			}
			if (Columns.FindByUId(new Guid("84f672ab-d268-4084-a96d-721b7cbacd2a")) == null) {
				Columns.Add(CreateIsVerified19Column());
			}
			if (Columns.FindByUId(new Guid("dd2f9d93-1cef-4e0f-ac70-c0f0bf2f8d42")) == null) {
				Columns.Add(CreateIsVerified20Column());
			}
			if (Columns.FindByUId(new Guid("6ff14239-5454-4450-a00f-86eabb7ec06a")) == null) {
				Columns.Add(CreateIsVerified21Column());
			}
			if (Columns.FindByUId(new Guid("6a9c8d59-6e76-4b5f-8bfc-a4a659827f86")) == null) {
				Columns.Add(CreateIsVerified22Column());
			}
			if (Columns.FindByUId(new Guid("eddc2538-c371-499d-99fb-134827bba9b7")) == null) {
				Columns.Add(CreateIsVerified23Column());
			}
			if (Columns.FindByUId(new Guid("0b79d6b3-6d1a-429e-a12a-179ce5828a2a")) == null) {
				Columns.Add(CreateIsVerified24Column());
			}
			if (Columns.FindByUId(new Guid("6772bde1-06b6-49a9-a306-94b3daf6bbc7")) == null) {
				Columns.Add(CreateIsVerified25Column());
			}
			if (Columns.FindByUId(new Guid("c3ca9919-eed4-4bcd-86a7-defc66b0e397")) == null) {
				Columns.Add(CreateIsVerified26Column());
			}
			if (Columns.FindByUId(new Guid("7fe2dae2-708d-4b86-914c-4fad61c5da5d")) == null) {
				Columns.Add(CreateIsVerified27Column());
			}
			if (Columns.FindByUId(new Guid("e5716d37-153d-4385-bcaa-8c0da867bee9")) == null) {
				Columns.Add(CreateIsVerified28Column());
			}
			if (Columns.FindByUId(new Guid("23d06938-2239-4c15-b8a1-b39ee6b05eb0")) == null) {
				Columns.Add(CreateIsVerified29Column());
			}
			if (Columns.FindByUId(new Guid("8892f5ee-d627-41cc-afec-de4355272014")) == null) {
				Columns.Add(CreateIsVerified30Column());
			}
			if (Columns.FindByUId(new Guid("98449d55-0dce-4e49-ba6f-373c599f4e57")) == null) {
				Columns.Add(CreateIsChanged10Column());
			}
			if (Columns.FindByUId(new Guid("241dd570-e9cf-4b72-8c30-5f76e58c8c2b")) == null) {
				Columns.Add(CreateIsChanged11Column());
			}
			if (Columns.FindByUId(new Guid("3e757d67-38d3-4842-a9f7-3312efb6b411")) == null) {
				Columns.Add(CreateIsChanged12Column());
			}
			if (Columns.FindByUId(new Guid("163c3906-00dd-4c20-8c82-785ad579ede7")) == null) {
				Columns.Add(CreateIsChanged13Column());
			}
			if (Columns.FindByUId(new Guid("d7eb9557-486f-405d-ac92-4294c352628e")) == null) {
				Columns.Add(CreateIsChanged14Column());
			}
			if (Columns.FindByUId(new Guid("f0841c66-af84-49c4-ab03-e9f7a349facf")) == null) {
				Columns.Add(CreateIsChanged15Column());
			}
			if (Columns.FindByUId(new Guid("722faacd-d97d-4b64-8661-c07472086a25")) == null) {
				Columns.Add(CreateIsChanged16Column());
			}
			if (Columns.FindByUId(new Guid("af96d99c-ec23-4043-bde8-f97e7db3ed8e")) == null) {
				Columns.Add(CreateIsChanged17Column());
			}
			if (Columns.FindByUId(new Guid("5c0e60f4-b9ba-496f-b56a-50dbdebb898c")) == null) {
				Columns.Add(CreateIsChanged18Column());
			}
			if (Columns.FindByUId(new Guid("96d13aa6-c170-4694-ae0d-d0463651e41d")) == null) {
				Columns.Add(CreateIsChanged19Column());
			}
			if (Columns.FindByUId(new Guid("49d434fa-e9e7-4cba-9fd9-5a0306d3d2b7")) == null) {
				Columns.Add(CreateIsChanged20Column());
			}
			if (Columns.FindByUId(new Guid("0df6886f-97eb-4752-82a8-0da5dee6249c")) == null) {
				Columns.Add(CreateIsChanged21Column());
			}
			if (Columns.FindByUId(new Guid("39ef4e05-1810-4cb6-a977-23f681dd659d")) == null) {
				Columns.Add(CreateIsChanged22Column());
			}
			if (Columns.FindByUId(new Guid("26a7838b-a83d-43c6-a396-a17936c07a17")) == null) {
				Columns.Add(CreateIsChanged23Column());
			}
			if (Columns.FindByUId(new Guid("0cdd4104-cdc1-4b57-8483-01a43244859e")) == null) {
				Columns.Add(CreateIsChanged24Column());
			}
			if (Columns.FindByUId(new Guid("9f1041fe-571e-4a58-b68e-9f728f488f9c")) == null) {
				Columns.Add(CreateIsChanged25Column());
			}
			if (Columns.FindByUId(new Guid("d4fe99db-e84c-49c2-a768-f6652ee1acfe")) == null) {
				Columns.Add(CreateIsChanged26Column());
			}
			if (Columns.FindByUId(new Guid("419266c3-e19b-4b2c-83ef-9d2a9b936187")) == null) {
				Columns.Add(CreateIsChanged27Column());
			}
			if (Columns.FindByUId(new Guid("02036514-fbb6-463d-9e07-cd89369e00f8")) == null) {
				Columns.Add(CreateIsChanged28Column());
			}
			if (Columns.FindByUId(new Guid("aa124d6e-753c-45eb-939c-d61fc83d0fce")) == null) {
				Columns.Add(CreateIsChanged29Column());
			}
			if (Columns.FindByUId(new Guid("addfc1e0-c1e6-4561-b00b-74f7c123da75")) == null) {
				Columns.Add(CreateIsChanged30Column());
			}
			if (Columns.FindByUId(new Guid("ead9f0f9-8b1b-4b01-9909-c0c388bc3d87")) == null) {
				Columns.Add(CreateLanguage0ShortColumn());
			}
			if (Columns.FindByUId(new Guid("ce3656a3-ad7d-4a5d-bb9e-3ee49ff631de")) == null) {
				Columns.Add(CreateLanguage1ShortColumn());
			}
			if (Columns.FindByUId(new Guid("cc6140b8-79de-44ea-8c87-bbdb8b119be3")) == null) {
				Columns.Add(CreateLanguage2ShortColumn());
			}
			if (Columns.FindByUId(new Guid("aad4b88c-e4b5-441b-abbd-1178462e7eb2")) == null) {
				Columns.Add(CreateLanguage3ShortColumn());
			}
			if (Columns.FindByUId(new Guid("42a45adf-2690-4271-9578-c786a4695796")) == null) {
				Columns.Add(CreateLanguage4ShortColumn());
			}
			if (Columns.FindByUId(new Guid("993dc791-47a4-4b76-a58e-df13a575d462")) == null) {
				Columns.Add(CreateLanguage5ShortColumn());
			}
			if (Columns.FindByUId(new Guid("44ea85a1-46a7-40df-a981-9bd9898f80b9")) == null) {
				Columns.Add(CreateLanguage6ShortColumn());
			}
			if (Columns.FindByUId(new Guid("f587e1f0-cd1a-497e-9817-09bc3a381b48")) == null) {
				Columns.Add(CreateLanguage7ShortColumn());
			}
			if (Columns.FindByUId(new Guid("0f3b754a-2b40-4a80-934b-97c8e9a09772")) == null) {
				Columns.Add(CreateLanguage8ShortColumn());
			}
			if (Columns.FindByUId(new Guid("5056540b-d232-4b74-a299-4225acdb1847")) == null) {
				Columns.Add(CreateLanguage9ShortColumn());
			}
			if (Columns.FindByUId(new Guid("0cf89ab4-26e0-4f23-a0d7-f721d39eaaa0")) == null) {
				Columns.Add(CreateLanguage10ShortColumn());
			}
			if (Columns.FindByUId(new Guid("40a049ca-a293-43c5-9304-661202c1d86a")) == null) {
				Columns.Add(CreateLanguage11ShortColumn());
			}
			if (Columns.FindByUId(new Guid("4ddf08b2-2767-4afd-8bc3-4229e0ccd8d3")) == null) {
				Columns.Add(CreateLanguage12ShortColumn());
			}
			if (Columns.FindByUId(new Guid("41e6bdee-287e-4caa-82e2-4ddc5092ca49")) == null) {
				Columns.Add(CreateLanguage13ShortColumn());
			}
			if (Columns.FindByUId(new Guid("fddf606f-3c8f-433f-b9a4-bffbad5cec20")) == null) {
				Columns.Add(CreateLanguage14ShortColumn());
			}
			if (Columns.FindByUId(new Guid("4b682718-9aa5-4834-af36-f2af4a5e68ad")) == null) {
				Columns.Add(CreateLanguage15ShortColumn());
			}
			if (Columns.FindByUId(new Guid("ec08203f-22a8-472b-b6f7-2ac332fc5f85")) == null) {
				Columns.Add(CreateLanguage16ShortColumn());
			}
			if (Columns.FindByUId(new Guid("78788498-e85a-4f3b-8f48-7ed04f1de4b9")) == null) {
				Columns.Add(CreateLanguage17ShortColumn());
			}
			if (Columns.FindByUId(new Guid("a14c9923-c42f-412c-a77a-8db648f1a96f")) == null) {
				Columns.Add(CreateLanguage18ShortColumn());
			}
			if (Columns.FindByUId(new Guid("7180df09-88b4-4a6c-9377-d5ca0c5033f3")) == null) {
				Columns.Add(CreateLanguage19ShortColumn());
			}
			if (Columns.FindByUId(new Guid("d9456e2d-9f91-4e35-8119-76a2f5fcd12e")) == null) {
				Columns.Add(CreateLanguage20ShortColumn());
			}
			if (Columns.FindByUId(new Guid("c8d1375f-4386-49e4-a525-bffee6457acd")) == null) {
				Columns.Add(CreateLanguage21ShortColumn());
			}
			if (Columns.FindByUId(new Guid("a778af48-7eb9-40f0-844d-26a4789dc26e")) == null) {
				Columns.Add(CreateLanguage22ShortColumn());
			}
			if (Columns.FindByUId(new Guid("449f9fee-6e85-4338-9f6c-b5920fa3cf9f")) == null) {
				Columns.Add(CreateLanguage23ShortColumn());
			}
			if (Columns.FindByUId(new Guid("d39f10b9-8ccd-49f6-8515-75d4209d0064")) == null) {
				Columns.Add(CreateLanguage24ShortColumn());
			}
			if (Columns.FindByUId(new Guid("b94e98db-e7bc-4030-8acc-1b422110676b")) == null) {
				Columns.Add(CreateLanguage25ShortColumn());
			}
			if (Columns.FindByUId(new Guid("17f99c85-5618-4649-9189-609b170b9b88")) == null) {
				Columns.Add(CreateLanguage26ShortColumn());
			}
			if (Columns.FindByUId(new Guid("53d7cb24-7e6b-4331-aa8a-146c0600e750")) == null) {
				Columns.Add(CreateLanguage27ShortColumn());
			}
			if (Columns.FindByUId(new Guid("f75e0b47-7c3a-4059-8c94-26609978b6f7")) == null) {
				Columns.Add(CreateLanguage28ShortColumn());
			}
			if (Columns.FindByUId(new Guid("bfc8fa4c-293e-4f23-8366-a262a3c0b1ad")) == null) {
				Columns.Add(CreateLanguage29ShortColumn());
			}
			if (Columns.FindByUId(new Guid("cd1f2eb5-91f5-4588-851b-1b39ff76782e")) == null) {
				Columns.Add(CreateLanguage30ShortColumn());
			}
			if (Columns.FindByUId(new Guid("57b0e5bd-8222-4e20-8e5c-85b88c2f21b8")) == null) {
				Columns.Add(CreateErrorMessageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4e54682a-31c5-4ec3-b1e9-d291901bfc9e"),
				Name = @"Key",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage0Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("2ec7a8e1-bda1-45f1-8038-8c9d6ee310ed"),
				Name = @"Language0",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d6083d73-a1ce-4f49-8cb8-01de8db77af6"),
				Name = @"Language1",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage2Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("113fb377-47d2-444b-b8d4-0847dbb63ca3"),
				Name = @"Language2",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage3Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7a63c135-6350-4e15-af20-ae7553afd1e9"),
				Name = @"Language3",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage4Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("db708816-23d4-43bd-8eb7-5f46a021f2c3"),
				Name = @"Language4",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage5Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a1deada4-b1d5-4d72-b92b-5ee7a9dcf808"),
				Name = @"Language5",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage6Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("e02df9b3-41a3-48f2-ada7-f646b4e6cf46"),
				Name = @"Language6",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage7Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7a28646b-7a1d-46fd-a095-638905442eaf"),
				Name = @"Language7",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage8Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("312972d9-b3a7-4647-9e3f-ef1dd53867bf"),
				Name = @"Language8",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage9Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a159185b-84dd-4fe8-a21b-e27b7f1ae509"),
				Name = @"Language9",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified0Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5551a508-bb63-4e92-abcc-459226c10967"),
				Name = @"IsVerified0",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f9fd8b05-9437-499a-bd61-4fb757c5e93a"),
				Name = @"IsVerified1",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified2Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("70ebca63-31fd-4660-aca0-f121d8364f8d"),
				Name = @"IsVerified2",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified3Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8ba15eda-adf6-40cd-a328-5486b63e7e83"),
				Name = @"IsVerified3",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified4Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("67ad9d20-ff6c-4be5-bdcd-c88425f2b88c"),
				Name = @"IsVerified4",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified5Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("127a8bf4-4468-4cab-b3ff-7c2337e9c0ec"),
				Name = @"IsVerified5",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified6Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("4bf92d3a-9799-4ae3-9540-13a4ae135ce2"),
				Name = @"IsVerified6",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified7Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5052c476-9f8e-4220-95fa-c75d1042b7d0"),
				Name = @"IsVerified7",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified8Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c0297e29-a2e8-43a8-8537-d8a92a358fb9"),
				Name = @"IsVerified8",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified9Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("cf773afc-033f-48db-99de-d52c78c848cf"),
				Name = @"IsVerified9",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged0Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8cb78c5b-b362-4c6d-ae55-665a29ebbec0"),
				Name = @"IsChanged0",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged1Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("db362f56-b1ec-4efc-b1a6-f25ac4e66c9c"),
				Name = @"IsChanged1",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged2Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("249f0a0e-5b79-445d-ae09-62c431e62802"),
				Name = @"IsChanged2",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged3Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1f10ced2-9735-498e-a313-5c798e0c48e2"),
				Name = @"IsChanged3",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged4Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f3a685ec-f704-4e02-bff9-5d7b62a99548"),
				Name = @"IsChanged4",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged5Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("90f169b1-6f0a-498f-8f6e-a8c1d429e39c"),
				Name = @"IsChanged5",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged6Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("472f1dc3-eac2-4f2c-8831-366cc3eaf84c"),
				Name = @"IsChanged6",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged7Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2cb95690-896f-486c-8be4-5dff742fffec"),
				Name = @"IsChanged7",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged8Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("88a18436-7505-4c77-9bef-a44e2dbea4b6"),
				Name = @"IsChanged8",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged9Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("584d8f47-54e4-44dd-882b-01c6ed74c2ef"),
				Name = @"IsChanged9",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage10Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("b660805a-93ce-4205-8c07-5ea919badfb0"),
				Name = @"Language10",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage11Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("2895cab7-493e-4fa0-b4c8-feccfeab8d16"),
				Name = @"Language11",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage12Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("25f36736-1938-4fa4-996d-bb17f6933fc3"),
				Name = @"Language12",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage13Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("60838d5f-7537-44fd-ad1f-4bdb50a54541"),
				Name = @"Language13",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage14Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("b3ee34f3-ce8d-436f-b675-cd8c9c224df8"),
				Name = @"Language14",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage15Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7a937094-5dc2-4a32-95da-06e00f1139e0"),
				Name = @"Language15",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage16Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("35d10ee8-41dc-48bf-8659-568cdef39c0a"),
				Name = @"Language16",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage17Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("8c82395d-354d-451d-aad9-ec3ebf5de014"),
				Name = @"Language17",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage18Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("e9ed5185-278f-4a43-a061-29e948852e32"),
				Name = @"Language18",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage19Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("31388a0e-8db5-4496-aa7a-04303f7fe5fd"),
				Name = @"Language19",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage20Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d416a27a-0a72-4638-813e-9feff82b71cc"),
				Name = @"Language20",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage21Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("bf358b7e-6e84-43d1-9150-d65f579aea87"),
				Name = @"Language21",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage22Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("ff995c89-7283-44bd-b06e-a5c402b02988"),
				Name = @"Language22",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage23Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("e0eef4f9-5d80-42c3-a213-d9b2316819a7"),
				Name = @"Language23",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage24Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("c97d0e51-e6e4-459f-ab83-de017c36ab2f"),
				Name = @"Language24",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage25Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("99ff77a8-b873-4ce0-bb20-64696be2c627"),
				Name = @"Language25",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage26Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("3b872cdb-cd76-4891-992d-da4b5337ded6"),
				Name = @"Language26",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage27Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("bfdd9315-a491-4272-b9c2-e1dc49b85ba5"),
				Name = @"Language27",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage28Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d7f3dd56-94fe-4922-9974-37db8bdf932b"),
				Name = @"Language28",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage29Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7fba7ad8-cb09-46b7-aa22-4fced486e021"),
				Name = @"Language29",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage30Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("e14a9e9b-cc27-42f5-bbda-5bba8348a5ca"),
				Name = @"Language30",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified10Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("363ce737-e745-4c50-ab60-75214785f4d8"),
				Name = @"IsVerified10",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified11Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a9555a78-3734-4fb7-b5b9-ea000313d4a1"),
				Name = @"IsVerified11",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified12Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("72f0c330-fd85-4c81-bf09-e846eaf0e01c"),
				Name = @"IsVerified12",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified13Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1a8e092e-4f69-4adb-8318-e06815073178"),
				Name = @"IsVerified13",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified14Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c8601f44-b46c-4080-8ed9-d388be1e9a43"),
				Name = @"IsVerified14",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified15Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5f701f56-4cae-460d-a8f0-08f3e4255e77"),
				Name = @"IsVerified15",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified16Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5ee1b637-4766-40da-98a0-a3a8dd6a3df3"),
				Name = @"IsVerified16",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified17Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8c14177f-643c-4f56-ac50-edfdc50b74ff"),
				Name = @"IsVerified17",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified18Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6f35fc91-a078-461f-b7a2-65d79fad86e3"),
				Name = @"IsVerified18",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified19Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("84f672ab-d268-4084-a96d-721b7cbacd2a"),
				Name = @"IsVerified19",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified20Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("dd2f9d93-1cef-4e0f-ac70-c0f0bf2f8d42"),
				Name = @"IsVerified20",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified21Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6ff14239-5454-4450-a00f-86eabb7ec06a"),
				Name = @"IsVerified21",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified22Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6a9c8d59-6e76-4b5f-8bfc-a4a659827f86"),
				Name = @"IsVerified22",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified23Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("eddc2538-c371-499d-99fb-134827bba9b7"),
				Name = @"IsVerified23",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified24Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0b79d6b3-6d1a-429e-a12a-179ce5828a2a"),
				Name = @"IsVerified24",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified25Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6772bde1-06b6-49a9-a306-94b3daf6bbc7"),
				Name = @"IsVerified25",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified26Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c3ca9919-eed4-4bcd-86a7-defc66b0e397"),
				Name = @"IsVerified26",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified27Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("7fe2dae2-708d-4b86-914c-4fad61c5da5d"),
				Name = @"IsVerified27",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified28Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e5716d37-153d-4385-bcaa-8c0da867bee9"),
				Name = @"IsVerified28",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified29Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("23d06938-2239-4c15-b8a1-b39ee6b05eb0"),
				Name = @"IsVerified29",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsVerified30Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8892f5ee-d627-41cc-afec-de4355272014"),
				Name = @"IsVerified30",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged10Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("98449d55-0dce-4e49-ba6f-373c599f4e57"),
				Name = @"IsChanged10",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged11Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("241dd570-e9cf-4b72-8c30-5f76e58c8c2b"),
				Name = @"IsChanged11",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged12Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3e757d67-38d3-4842-a9f7-3312efb6b411"),
				Name = @"IsChanged12",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged13Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("163c3906-00dd-4c20-8c82-785ad579ede7"),
				Name = @"IsChanged13",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged14Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d7eb9557-486f-405d-ac92-4294c352628e"),
				Name = @"IsChanged14",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged15Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f0841c66-af84-49c4-ab03-e9f7a349facf"),
				Name = @"IsChanged15",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged16Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("722faacd-d97d-4b64-8661-c07472086a25"),
				Name = @"IsChanged16",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged17Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("af96d99c-ec23-4043-bde8-f97e7db3ed8e"),
				Name = @"IsChanged17",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged18Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5c0e60f4-b9ba-496f-b56a-50dbdebb898c"),
				Name = @"IsChanged18",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged19Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("96d13aa6-c170-4694-ae0d-d0463651e41d"),
				Name = @"IsChanged19",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged20Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("49d434fa-e9e7-4cba-9fd9-5a0306d3d2b7"),
				Name = @"IsChanged20",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged21Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0df6886f-97eb-4752-82a8-0da5dee6249c"),
				Name = @"IsChanged21",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged22Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("39ef4e05-1810-4cb6-a977-23f681dd659d"),
				Name = @"IsChanged22",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged23Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("26a7838b-a83d-43c6-a396-a17936c07a17"),
				Name = @"IsChanged23",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged24Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0cdd4104-cdc1-4b57-8483-01a43244859e"),
				Name = @"IsChanged24",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged25Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9f1041fe-571e-4a58-b68e-9f728f488f9c"),
				Name = @"IsChanged25",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged26Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d4fe99db-e84c-49c2-a768-f6652ee1acfe"),
				Name = @"IsChanged26",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged27Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("419266c3-e19b-4b2c-83ef-9d2a9b936187"),
				Name = @"IsChanged27",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged28Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("02036514-fbb6-463d-9e07-cd89369e00f8"),
				Name = @"IsChanged28",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged29Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("aa124d6e-753c-45eb-939c-d61fc83d0fce"),
				Name = @"IsChanged29",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChanged30Column() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("addfc1e0-c1e6-4561-b00b-74f7c123da75"),
				Name = @"IsChanged30",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage0ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ead9f0f9-8b1b-4b01-9909-c0c388bc3d87"),
				Name = @"Language0Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage1ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ce3656a3-ad7d-4a5d-bb9e-3ee49ff631de"),
				Name = @"Language1Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage2ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("cc6140b8-79de-44ea-8c87-bbdb8b119be3"),
				Name = @"Language2Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage3ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("aad4b88c-e4b5-441b-abbd-1178462e7eb2"),
				Name = @"Language3Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage4ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("42a45adf-2690-4271-9578-c786a4695796"),
				Name = @"Language4Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage5ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("993dc791-47a4-4b76-a58e-df13a575d462"),
				Name = @"Language5Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage6ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("44ea85a1-46a7-40df-a981-9bd9898f80b9"),
				Name = @"Language6Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage7ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f587e1f0-cd1a-497e-9817-09bc3a381b48"),
				Name = @"Language7Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage8ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("0f3b754a-2b40-4a80-934b-97c8e9a09772"),
				Name = @"Language8Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage9ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5056540b-d232-4b74-a299-4225acdb1847"),
				Name = @"Language9Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage10ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("0cf89ab4-26e0-4f23-a0d7-f721d39eaaa0"),
				Name = @"Language10Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage11ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("40a049ca-a293-43c5-9304-661202c1d86a"),
				Name = @"Language11Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage12ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4ddf08b2-2767-4afd-8bc3-4229e0ccd8d3"),
				Name = @"Language12Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage13ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("41e6bdee-287e-4caa-82e2-4ddc5092ca49"),
				Name = @"Language13Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage14ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("fddf606f-3c8f-433f-b9a4-bffbad5cec20"),
				Name = @"Language14Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage15ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4b682718-9aa5-4834-af36-f2af4a5e68ad"),
				Name = @"Language15Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage16ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ec08203f-22a8-472b-b6f7-2ac332fc5f85"),
				Name = @"Language16Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage17ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("78788498-e85a-4f3b-8f48-7ed04f1de4b9"),
				Name = @"Language17Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage18ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a14c9923-c42f-412c-a77a-8db648f1a96f"),
				Name = @"Language18Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage19ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("7180df09-88b4-4a6c-9377-d5ca0c5033f3"),
				Name = @"Language19Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage20ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d9456e2d-9f91-4e35-8119-76a2f5fcd12e"),
				Name = @"Language20Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage21ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c8d1375f-4386-49e4-a525-bffee6457acd"),
				Name = @"Language21Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage22ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a778af48-7eb9-40f0-844d-26a4789dc26e"),
				Name = @"Language22Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage23ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("449f9fee-6e85-4338-9f6c-b5920fa3cf9f"),
				Name = @"Language23Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage24ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d39f10b9-8ccd-49f6-8515-75d4209d0064"),
				Name = @"Language24Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage25ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b94e98db-e7bc-4030-8acc-1b422110676b"),
				Name = @"Language25Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage26ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("17f99c85-5618-4649-9189-609b170b9b88"),
				Name = @"Language26Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage27ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("53d7cb24-7e6b-4331-aa8a-146c0600e750"),
				Name = @"Language27Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage28ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f75e0b47-7c3a-4059-8c94-26609978b6f7"),
				Name = @"Language28Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage29ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("bfc8fa4c-293e-4f23-8366-a262a3c0b1ad"),
				Name = @"Language29Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateLanguage30ShortColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("cd1f2eb5-91f5-4588-851b-1b39ff76782e"),
				Name = @"Language30Short",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("4f20c153-048f-4a5e-b76c-c7a7749e359a")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorMessageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("57b0e5bd-8222-4e20-8e5c-85b88c2f21b8"),
				Name = @"ErrorMessage",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				ModifiedInSchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"),
				CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateSysTranslationKeyIndexIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysTranslationEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysTranslationEventsProcessSchema() {
			var schema = new SysTranslationEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysTranslation(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysTranslation_TranslationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysTranslationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysTranslationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951"));
		}

		#endregion

	}

	#endregion

	#region Class: SysTranslation

	/// <summary>
	/// Translation.
	/// </summary>
	public class SysTranslation : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysTranslation(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysTranslation";
		}

		public SysTranslation(SysTranslation source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Key.
		/// </summary>
		public string Key {
			get {
				return GetTypedColumnValue<string>("Key");
			}
			set {
				SetColumnValue("Key", value);
			}
		}

		/// <summary>
		/// Language0.
		/// </summary>
		public string Language0 {
			get {
				return GetTypedColumnValue<string>("Language0");
			}
			set {
				SetColumnValue("Language0", value);
			}
		}

		/// <summary>
		/// Language1.
		/// </summary>
		public string Language1 {
			get {
				return GetTypedColumnValue<string>("Language1");
			}
			set {
				SetColumnValue("Language1", value);
			}
		}

		/// <summary>
		/// Language2.
		/// </summary>
		public string Language2 {
			get {
				return GetTypedColumnValue<string>("Language2");
			}
			set {
				SetColumnValue("Language2", value);
			}
		}

		/// <summary>
		/// Language3.
		/// </summary>
		public string Language3 {
			get {
				return GetTypedColumnValue<string>("Language3");
			}
			set {
				SetColumnValue("Language3", value);
			}
		}

		/// <summary>
		/// Language4.
		/// </summary>
		public string Language4 {
			get {
				return GetTypedColumnValue<string>("Language4");
			}
			set {
				SetColumnValue("Language4", value);
			}
		}

		/// <summary>
		/// Language5.
		/// </summary>
		public string Language5 {
			get {
				return GetTypedColumnValue<string>("Language5");
			}
			set {
				SetColumnValue("Language5", value);
			}
		}

		/// <summary>
		/// Language6.
		/// </summary>
		public string Language6 {
			get {
				return GetTypedColumnValue<string>("Language6");
			}
			set {
				SetColumnValue("Language6", value);
			}
		}

		/// <summary>
		/// Language7.
		/// </summary>
		public string Language7 {
			get {
				return GetTypedColumnValue<string>("Language7");
			}
			set {
				SetColumnValue("Language7", value);
			}
		}

		/// <summary>
		/// Language8.
		/// </summary>
		public string Language8 {
			get {
				return GetTypedColumnValue<string>("Language8");
			}
			set {
				SetColumnValue("Language8", value);
			}
		}

		/// <summary>
		/// Language9.
		/// </summary>
		public string Language9 {
			get {
				return GetTypedColumnValue<string>("Language9");
			}
			set {
				SetColumnValue("Language9", value);
			}
		}

		/// <summary>
		/// IsVerified0.
		/// </summary>
		public bool IsVerified0 {
			get {
				return GetTypedColumnValue<bool>("IsVerified0");
			}
			set {
				SetColumnValue("IsVerified0", value);
			}
		}

		/// <summary>
		/// IsVerified1.
		/// </summary>
		public bool IsVerified1 {
			get {
				return GetTypedColumnValue<bool>("IsVerified1");
			}
			set {
				SetColumnValue("IsVerified1", value);
			}
		}

		/// <summary>
		/// IsVerified0.
		/// </summary>
		public bool IsVerified2 {
			get {
				return GetTypedColumnValue<bool>("IsVerified2");
			}
			set {
				SetColumnValue("IsVerified2", value);
			}
		}

		/// <summary>
		/// IsVerified3.
		/// </summary>
		public bool IsVerified3 {
			get {
				return GetTypedColumnValue<bool>("IsVerified3");
			}
			set {
				SetColumnValue("IsVerified3", value);
			}
		}

		/// <summary>
		/// IsVerified4.
		/// </summary>
		public bool IsVerified4 {
			get {
				return GetTypedColumnValue<bool>("IsVerified4");
			}
			set {
				SetColumnValue("IsVerified4", value);
			}
		}

		/// <summary>
		/// IsVerified5.
		/// </summary>
		public bool IsVerified5 {
			get {
				return GetTypedColumnValue<bool>("IsVerified5");
			}
			set {
				SetColumnValue("IsVerified5", value);
			}
		}

		/// <summary>
		/// IsVerified6.
		/// </summary>
		public bool IsVerified6 {
			get {
				return GetTypedColumnValue<bool>("IsVerified6");
			}
			set {
				SetColumnValue("IsVerified6", value);
			}
		}

		/// <summary>
		/// IsVerified7.
		/// </summary>
		public bool IsVerified7 {
			get {
				return GetTypedColumnValue<bool>("IsVerified7");
			}
			set {
				SetColumnValue("IsVerified7", value);
			}
		}

		/// <summary>
		/// IsVerified8.
		/// </summary>
		public bool IsVerified8 {
			get {
				return GetTypedColumnValue<bool>("IsVerified8");
			}
			set {
				SetColumnValue("IsVerified8", value);
			}
		}

		/// <summary>
		/// IsVerified9.
		/// </summary>
		public bool IsVerified9 {
			get {
				return GetTypedColumnValue<bool>("IsVerified9");
			}
			set {
				SetColumnValue("IsVerified9", value);
			}
		}

		/// <summary>
		/// IsChanged0.
		/// </summary>
		public bool IsChanged0 {
			get {
				return GetTypedColumnValue<bool>("IsChanged0");
			}
			set {
				SetColumnValue("IsChanged0", value);
			}
		}

		/// <summary>
		/// IsChanged1.
		/// </summary>
		public bool IsChanged1 {
			get {
				return GetTypedColumnValue<bool>("IsChanged1");
			}
			set {
				SetColumnValue("IsChanged1", value);
			}
		}

		/// <summary>
		/// IsChanged2.
		/// </summary>
		public bool IsChanged2 {
			get {
				return GetTypedColumnValue<bool>("IsChanged2");
			}
			set {
				SetColumnValue("IsChanged2", value);
			}
		}

		/// <summary>
		/// IsChanged3.
		/// </summary>
		public bool IsChanged3 {
			get {
				return GetTypedColumnValue<bool>("IsChanged3");
			}
			set {
				SetColumnValue("IsChanged3", value);
			}
		}

		/// <summary>
		/// IsChanged4.
		/// </summary>
		public bool IsChanged4 {
			get {
				return GetTypedColumnValue<bool>("IsChanged4");
			}
			set {
				SetColumnValue("IsChanged4", value);
			}
		}

		/// <summary>
		/// IsChanged5.
		/// </summary>
		public bool IsChanged5 {
			get {
				return GetTypedColumnValue<bool>("IsChanged5");
			}
			set {
				SetColumnValue("IsChanged5", value);
			}
		}

		/// <summary>
		/// IsChanged6.
		/// </summary>
		public bool IsChanged6 {
			get {
				return GetTypedColumnValue<bool>("IsChanged6");
			}
			set {
				SetColumnValue("IsChanged6", value);
			}
		}

		/// <summary>
		/// IsChanged7.
		/// </summary>
		public bool IsChanged7 {
			get {
				return GetTypedColumnValue<bool>("IsChanged7");
			}
			set {
				SetColumnValue("IsChanged7", value);
			}
		}

		/// <summary>
		/// IsChanged8.
		/// </summary>
		public bool IsChanged8 {
			get {
				return GetTypedColumnValue<bool>("IsChanged8");
			}
			set {
				SetColumnValue("IsChanged8", value);
			}
		}

		/// <summary>
		/// IsChanged9.
		/// </summary>
		public bool IsChanged9 {
			get {
				return GetTypedColumnValue<bool>("IsChanged9");
			}
			set {
				SetColumnValue("IsChanged9", value);
			}
		}

		/// <summary>
		/// Language10.
		/// </summary>
		public string Language10 {
			get {
				return GetTypedColumnValue<string>("Language10");
			}
			set {
				SetColumnValue("Language10", value);
			}
		}

		/// <summary>
		/// Language11.
		/// </summary>
		public string Language11 {
			get {
				return GetTypedColumnValue<string>("Language11");
			}
			set {
				SetColumnValue("Language11", value);
			}
		}

		/// <summary>
		/// Language12.
		/// </summary>
		public string Language12 {
			get {
				return GetTypedColumnValue<string>("Language12");
			}
			set {
				SetColumnValue("Language12", value);
			}
		}

		/// <summary>
		/// Language13.
		/// </summary>
		public string Language13 {
			get {
				return GetTypedColumnValue<string>("Language13");
			}
			set {
				SetColumnValue("Language13", value);
			}
		}

		/// <summary>
		/// Language14.
		/// </summary>
		public string Language14 {
			get {
				return GetTypedColumnValue<string>("Language14");
			}
			set {
				SetColumnValue("Language14", value);
			}
		}

		/// <summary>
		/// Language15.
		/// </summary>
		public string Language15 {
			get {
				return GetTypedColumnValue<string>("Language15");
			}
			set {
				SetColumnValue("Language15", value);
			}
		}

		/// <summary>
		/// Language16.
		/// </summary>
		public string Language16 {
			get {
				return GetTypedColumnValue<string>("Language16");
			}
			set {
				SetColumnValue("Language16", value);
			}
		}

		/// <summary>
		/// Language17.
		/// </summary>
		public string Language17 {
			get {
				return GetTypedColumnValue<string>("Language17");
			}
			set {
				SetColumnValue("Language17", value);
			}
		}

		/// <summary>
		/// Language18.
		/// </summary>
		public string Language18 {
			get {
				return GetTypedColumnValue<string>("Language18");
			}
			set {
				SetColumnValue("Language18", value);
			}
		}

		/// <summary>
		/// Language19.
		/// </summary>
		public string Language19 {
			get {
				return GetTypedColumnValue<string>("Language19");
			}
			set {
				SetColumnValue("Language19", value);
			}
		}

		/// <summary>
		/// Language20.
		/// </summary>
		public string Language20 {
			get {
				return GetTypedColumnValue<string>("Language20");
			}
			set {
				SetColumnValue("Language20", value);
			}
		}

		/// <summary>
		/// Language21.
		/// </summary>
		public string Language21 {
			get {
				return GetTypedColumnValue<string>("Language21");
			}
			set {
				SetColumnValue("Language21", value);
			}
		}

		/// <summary>
		/// Language22.
		/// </summary>
		public string Language22 {
			get {
				return GetTypedColumnValue<string>("Language22");
			}
			set {
				SetColumnValue("Language22", value);
			}
		}

		/// <summary>
		/// Language23.
		/// </summary>
		public string Language23 {
			get {
				return GetTypedColumnValue<string>("Language23");
			}
			set {
				SetColumnValue("Language23", value);
			}
		}

		/// <summary>
		/// Language24.
		/// </summary>
		public string Language24 {
			get {
				return GetTypedColumnValue<string>("Language24");
			}
			set {
				SetColumnValue("Language24", value);
			}
		}

		/// <summary>
		/// Language25.
		/// </summary>
		public string Language25 {
			get {
				return GetTypedColumnValue<string>("Language25");
			}
			set {
				SetColumnValue("Language25", value);
			}
		}

		/// <summary>
		/// Language26.
		/// </summary>
		public string Language26 {
			get {
				return GetTypedColumnValue<string>("Language26");
			}
			set {
				SetColumnValue("Language26", value);
			}
		}

		/// <summary>
		/// Language27.
		/// </summary>
		public string Language27 {
			get {
				return GetTypedColumnValue<string>("Language27");
			}
			set {
				SetColumnValue("Language27", value);
			}
		}

		/// <summary>
		/// Language28.
		/// </summary>
		public string Language28 {
			get {
				return GetTypedColumnValue<string>("Language28");
			}
			set {
				SetColumnValue("Language28", value);
			}
		}

		/// <summary>
		/// Language29.
		/// </summary>
		public string Language29 {
			get {
				return GetTypedColumnValue<string>("Language29");
			}
			set {
				SetColumnValue("Language29", value);
			}
		}

		/// <summary>
		/// Language30.
		/// </summary>
		public string Language30 {
			get {
				return GetTypedColumnValue<string>("Language30");
			}
			set {
				SetColumnValue("Language30", value);
			}
		}

		/// <summary>
		/// IsVerified10.
		/// </summary>
		public bool IsVerified10 {
			get {
				return GetTypedColumnValue<bool>("IsVerified10");
			}
			set {
				SetColumnValue("IsVerified10", value);
			}
		}

		/// <summary>
		/// IsVerified11.
		/// </summary>
		public bool IsVerified11 {
			get {
				return GetTypedColumnValue<bool>("IsVerified11");
			}
			set {
				SetColumnValue("IsVerified11", value);
			}
		}

		/// <summary>
		/// IsVerified12.
		/// </summary>
		public bool IsVerified12 {
			get {
				return GetTypedColumnValue<bool>("IsVerified12");
			}
			set {
				SetColumnValue("IsVerified12", value);
			}
		}

		/// <summary>
		/// IsVerified13.
		/// </summary>
		public bool IsVerified13 {
			get {
				return GetTypedColumnValue<bool>("IsVerified13");
			}
			set {
				SetColumnValue("IsVerified13", value);
			}
		}

		/// <summary>
		/// IsVerified14.
		/// </summary>
		public bool IsVerified14 {
			get {
				return GetTypedColumnValue<bool>("IsVerified14");
			}
			set {
				SetColumnValue("IsVerified14", value);
			}
		}

		/// <summary>
		/// IsVerified15.
		/// </summary>
		public bool IsVerified15 {
			get {
				return GetTypedColumnValue<bool>("IsVerified15");
			}
			set {
				SetColumnValue("IsVerified15", value);
			}
		}

		/// <summary>
		/// IsVerified16.
		/// </summary>
		public bool IsVerified16 {
			get {
				return GetTypedColumnValue<bool>("IsVerified16");
			}
			set {
				SetColumnValue("IsVerified16", value);
			}
		}

		/// <summary>
		/// IsVerified17.
		/// </summary>
		public bool IsVerified17 {
			get {
				return GetTypedColumnValue<bool>("IsVerified17");
			}
			set {
				SetColumnValue("IsVerified17", value);
			}
		}

		/// <summary>
		/// IsVerified18.
		/// </summary>
		public bool IsVerified18 {
			get {
				return GetTypedColumnValue<bool>("IsVerified18");
			}
			set {
				SetColumnValue("IsVerified18", value);
			}
		}

		/// <summary>
		/// IsVerified19.
		/// </summary>
		public bool IsVerified19 {
			get {
				return GetTypedColumnValue<bool>("IsVerified19");
			}
			set {
				SetColumnValue("IsVerified19", value);
			}
		}

		/// <summary>
		/// IsVerified20.
		/// </summary>
		public bool IsVerified20 {
			get {
				return GetTypedColumnValue<bool>("IsVerified20");
			}
			set {
				SetColumnValue("IsVerified20", value);
			}
		}

		/// <summary>
		/// IsVerified21.
		/// </summary>
		public bool IsVerified21 {
			get {
				return GetTypedColumnValue<bool>("IsVerified21");
			}
			set {
				SetColumnValue("IsVerified21", value);
			}
		}

		/// <summary>
		/// IsVerified22.
		/// </summary>
		public bool IsVerified22 {
			get {
				return GetTypedColumnValue<bool>("IsVerified22");
			}
			set {
				SetColumnValue("IsVerified22", value);
			}
		}

		/// <summary>
		/// IsVerified23.
		/// </summary>
		public bool IsVerified23 {
			get {
				return GetTypedColumnValue<bool>("IsVerified23");
			}
			set {
				SetColumnValue("IsVerified23", value);
			}
		}

		/// <summary>
		/// IsVerified24.
		/// </summary>
		public bool IsVerified24 {
			get {
				return GetTypedColumnValue<bool>("IsVerified24");
			}
			set {
				SetColumnValue("IsVerified24", value);
			}
		}

		/// <summary>
		/// IsVerified25.
		/// </summary>
		public bool IsVerified25 {
			get {
				return GetTypedColumnValue<bool>("IsVerified25");
			}
			set {
				SetColumnValue("IsVerified25", value);
			}
		}

		/// <summary>
		/// IsVerified26.
		/// </summary>
		public bool IsVerified26 {
			get {
				return GetTypedColumnValue<bool>("IsVerified26");
			}
			set {
				SetColumnValue("IsVerified26", value);
			}
		}

		/// <summary>
		/// IsVerified27.
		/// </summary>
		public bool IsVerified27 {
			get {
				return GetTypedColumnValue<bool>("IsVerified27");
			}
			set {
				SetColumnValue("IsVerified27", value);
			}
		}

		/// <summary>
		/// IsVerified28.
		/// </summary>
		public bool IsVerified28 {
			get {
				return GetTypedColumnValue<bool>("IsVerified28");
			}
			set {
				SetColumnValue("IsVerified28", value);
			}
		}

		/// <summary>
		/// IsVerified29.
		/// </summary>
		public bool IsVerified29 {
			get {
				return GetTypedColumnValue<bool>("IsVerified29");
			}
			set {
				SetColumnValue("IsVerified29", value);
			}
		}

		/// <summary>
		/// IsVerified30.
		/// </summary>
		public bool IsVerified30 {
			get {
				return GetTypedColumnValue<bool>("IsVerified30");
			}
			set {
				SetColumnValue("IsVerified30", value);
			}
		}

		/// <summary>
		/// IsChanged10.
		/// </summary>
		public bool IsChanged10 {
			get {
				return GetTypedColumnValue<bool>("IsChanged10");
			}
			set {
				SetColumnValue("IsChanged10", value);
			}
		}

		/// <summary>
		/// IsChanged11.
		/// </summary>
		public bool IsChanged11 {
			get {
				return GetTypedColumnValue<bool>("IsChanged11");
			}
			set {
				SetColumnValue("IsChanged11", value);
			}
		}

		/// <summary>
		/// IsChanged12.
		/// </summary>
		public bool IsChanged12 {
			get {
				return GetTypedColumnValue<bool>("IsChanged12");
			}
			set {
				SetColumnValue("IsChanged12", value);
			}
		}

		/// <summary>
		/// IsChanged13.
		/// </summary>
		public bool IsChanged13 {
			get {
				return GetTypedColumnValue<bool>("IsChanged13");
			}
			set {
				SetColumnValue("IsChanged13", value);
			}
		}

		/// <summary>
		/// IsChanged14.
		/// </summary>
		public bool IsChanged14 {
			get {
				return GetTypedColumnValue<bool>("IsChanged14");
			}
			set {
				SetColumnValue("IsChanged14", value);
			}
		}

		/// <summary>
		/// IsChanged15.
		/// </summary>
		public bool IsChanged15 {
			get {
				return GetTypedColumnValue<bool>("IsChanged15");
			}
			set {
				SetColumnValue("IsChanged15", value);
			}
		}

		/// <summary>
		/// IsChanged16.
		/// </summary>
		public bool IsChanged16 {
			get {
				return GetTypedColumnValue<bool>("IsChanged16");
			}
			set {
				SetColumnValue("IsChanged16", value);
			}
		}

		/// <summary>
		/// IsChanged17.
		/// </summary>
		public bool IsChanged17 {
			get {
				return GetTypedColumnValue<bool>("IsChanged17");
			}
			set {
				SetColumnValue("IsChanged17", value);
			}
		}

		/// <summary>
		/// IsChanged18.
		/// </summary>
		public bool IsChanged18 {
			get {
				return GetTypedColumnValue<bool>("IsChanged18");
			}
			set {
				SetColumnValue("IsChanged18", value);
			}
		}

		/// <summary>
		/// IsChanged19.
		/// </summary>
		public bool IsChanged19 {
			get {
				return GetTypedColumnValue<bool>("IsChanged19");
			}
			set {
				SetColumnValue("IsChanged19", value);
			}
		}

		/// <summary>
		/// IsChanged20.
		/// </summary>
		public bool IsChanged20 {
			get {
				return GetTypedColumnValue<bool>("IsChanged20");
			}
			set {
				SetColumnValue("IsChanged20", value);
			}
		}

		/// <summary>
		/// IsChanged21.
		/// </summary>
		public bool IsChanged21 {
			get {
				return GetTypedColumnValue<bool>("IsChanged21");
			}
			set {
				SetColumnValue("IsChanged21", value);
			}
		}

		/// <summary>
		/// IsChanged22.
		/// </summary>
		public bool IsChanged22 {
			get {
				return GetTypedColumnValue<bool>("IsChanged22");
			}
			set {
				SetColumnValue("IsChanged22", value);
			}
		}

		/// <summary>
		/// IsChanged23.
		/// </summary>
		public bool IsChanged23 {
			get {
				return GetTypedColumnValue<bool>("IsChanged23");
			}
			set {
				SetColumnValue("IsChanged23", value);
			}
		}

		/// <summary>
		/// IsChanged24.
		/// </summary>
		public bool IsChanged24 {
			get {
				return GetTypedColumnValue<bool>("IsChanged24");
			}
			set {
				SetColumnValue("IsChanged24", value);
			}
		}

		/// <summary>
		/// IsChanged25.
		/// </summary>
		public bool IsChanged25 {
			get {
				return GetTypedColumnValue<bool>("IsChanged25");
			}
			set {
				SetColumnValue("IsChanged25", value);
			}
		}

		/// <summary>
		/// IsChanged26.
		/// </summary>
		public bool IsChanged26 {
			get {
				return GetTypedColumnValue<bool>("IsChanged26");
			}
			set {
				SetColumnValue("IsChanged26", value);
			}
		}

		/// <summary>
		/// IsChanged27.
		/// </summary>
		public bool IsChanged27 {
			get {
				return GetTypedColumnValue<bool>("IsChanged27");
			}
			set {
				SetColumnValue("IsChanged27", value);
			}
		}

		/// <summary>
		/// IsChanged28.
		/// </summary>
		public bool IsChanged28 {
			get {
				return GetTypedColumnValue<bool>("IsChanged28");
			}
			set {
				SetColumnValue("IsChanged28", value);
			}
		}

		/// <summary>
		/// IsChanged29.
		/// </summary>
		public bool IsChanged29 {
			get {
				return GetTypedColumnValue<bool>("IsChanged29");
			}
			set {
				SetColumnValue("IsChanged29", value);
			}
		}

		/// <summary>
		/// IsChanged30.
		/// </summary>
		public bool IsChanged30 {
			get {
				return GetTypedColumnValue<bool>("IsChanged30");
			}
			set {
				SetColumnValue("IsChanged30", value);
			}
		}

		/// <summary>
		/// Language0Short.
		/// </summary>
		public string Language0Short {
			get {
				return GetTypedColumnValue<string>("Language0Short");
			}
			set {
				SetColumnValue("Language0Short", value);
			}
		}

		/// <summary>
		/// Language1Short.
		/// </summary>
		public string Language1Short {
			get {
				return GetTypedColumnValue<string>("Language1Short");
			}
			set {
				SetColumnValue("Language1Short", value);
			}
		}

		/// <summary>
		/// Language2Short.
		/// </summary>
		public string Language2Short {
			get {
				return GetTypedColumnValue<string>("Language2Short");
			}
			set {
				SetColumnValue("Language2Short", value);
			}
		}

		/// <summary>
		/// Language3Short.
		/// </summary>
		public string Language3Short {
			get {
				return GetTypedColumnValue<string>("Language3Short");
			}
			set {
				SetColumnValue("Language3Short", value);
			}
		}

		/// <summary>
		/// Language4Short.
		/// </summary>
		public string Language4Short {
			get {
				return GetTypedColumnValue<string>("Language4Short");
			}
			set {
				SetColumnValue("Language4Short", value);
			}
		}

		/// <summary>
		/// Language5Short.
		/// </summary>
		public string Language5Short {
			get {
				return GetTypedColumnValue<string>("Language5Short");
			}
			set {
				SetColumnValue("Language5Short", value);
			}
		}

		/// <summary>
		/// Language6Short.
		/// </summary>
		public string Language6Short {
			get {
				return GetTypedColumnValue<string>("Language6Short");
			}
			set {
				SetColumnValue("Language6Short", value);
			}
		}

		/// <summary>
		/// Language7Short.
		/// </summary>
		public string Language7Short {
			get {
				return GetTypedColumnValue<string>("Language7Short");
			}
			set {
				SetColumnValue("Language7Short", value);
			}
		}

		/// <summary>
		/// Language8Short.
		/// </summary>
		public string Language8Short {
			get {
				return GetTypedColumnValue<string>("Language8Short");
			}
			set {
				SetColumnValue("Language8Short", value);
			}
		}

		/// <summary>
		/// Language9Short.
		/// </summary>
		public string Language9Short {
			get {
				return GetTypedColumnValue<string>("Language9Short");
			}
			set {
				SetColumnValue("Language9Short", value);
			}
		}

		/// <summary>
		/// Language10Short.
		/// </summary>
		public string Language10Short {
			get {
				return GetTypedColumnValue<string>("Language10Short");
			}
			set {
				SetColumnValue("Language10Short", value);
			}
		}

		/// <summary>
		/// Language11Short.
		/// </summary>
		public string Language11Short {
			get {
				return GetTypedColumnValue<string>("Language11Short");
			}
			set {
				SetColumnValue("Language11Short", value);
			}
		}

		/// <summary>
		/// Language12Short.
		/// </summary>
		public string Language12Short {
			get {
				return GetTypedColumnValue<string>("Language12Short");
			}
			set {
				SetColumnValue("Language12Short", value);
			}
		}

		/// <summary>
		/// Language13Short.
		/// </summary>
		public string Language13Short {
			get {
				return GetTypedColumnValue<string>("Language13Short");
			}
			set {
				SetColumnValue("Language13Short", value);
			}
		}

		/// <summary>
		/// Language14Short.
		/// </summary>
		public string Language14Short {
			get {
				return GetTypedColumnValue<string>("Language14Short");
			}
			set {
				SetColumnValue("Language14Short", value);
			}
		}

		/// <summary>
		/// Language15Short.
		/// </summary>
		public string Language15Short {
			get {
				return GetTypedColumnValue<string>("Language15Short");
			}
			set {
				SetColumnValue("Language15Short", value);
			}
		}

		/// <summary>
		/// Language16Short.
		/// </summary>
		public string Language16Short {
			get {
				return GetTypedColumnValue<string>("Language16Short");
			}
			set {
				SetColumnValue("Language16Short", value);
			}
		}

		/// <summary>
		/// Language17Short.
		/// </summary>
		public string Language17Short {
			get {
				return GetTypedColumnValue<string>("Language17Short");
			}
			set {
				SetColumnValue("Language17Short", value);
			}
		}

		/// <summary>
		/// Language18Short.
		/// </summary>
		public string Language18Short {
			get {
				return GetTypedColumnValue<string>("Language18Short");
			}
			set {
				SetColumnValue("Language18Short", value);
			}
		}

		/// <summary>
		/// Language19Short.
		/// </summary>
		public string Language19Short {
			get {
				return GetTypedColumnValue<string>("Language19Short");
			}
			set {
				SetColumnValue("Language19Short", value);
			}
		}

		/// <summary>
		/// Language20Short.
		/// </summary>
		public string Language20Short {
			get {
				return GetTypedColumnValue<string>("Language20Short");
			}
			set {
				SetColumnValue("Language20Short", value);
			}
		}

		/// <summary>
		/// Language21Short.
		/// </summary>
		public string Language21Short {
			get {
				return GetTypedColumnValue<string>("Language21Short");
			}
			set {
				SetColumnValue("Language21Short", value);
			}
		}

		/// <summary>
		/// Language22Short.
		/// </summary>
		public string Language22Short {
			get {
				return GetTypedColumnValue<string>("Language22Short");
			}
			set {
				SetColumnValue("Language22Short", value);
			}
		}

		/// <summary>
		/// Language23Short.
		/// </summary>
		public string Language23Short {
			get {
				return GetTypedColumnValue<string>("Language23Short");
			}
			set {
				SetColumnValue("Language23Short", value);
			}
		}

		/// <summary>
		/// Language24Short.
		/// </summary>
		public string Language24Short {
			get {
				return GetTypedColumnValue<string>("Language24Short");
			}
			set {
				SetColumnValue("Language24Short", value);
			}
		}

		/// <summary>
		/// Language25Short.
		/// </summary>
		public string Language25Short {
			get {
				return GetTypedColumnValue<string>("Language25Short");
			}
			set {
				SetColumnValue("Language25Short", value);
			}
		}

		/// <summary>
		/// Language26Short.
		/// </summary>
		public string Language26Short {
			get {
				return GetTypedColumnValue<string>("Language26Short");
			}
			set {
				SetColumnValue("Language26Short", value);
			}
		}

		/// <summary>
		/// Language27Short.
		/// </summary>
		public string Language27Short {
			get {
				return GetTypedColumnValue<string>("Language27Short");
			}
			set {
				SetColumnValue("Language27Short", value);
			}
		}

		/// <summary>
		/// Language28Short.
		/// </summary>
		public string Language28Short {
			get {
				return GetTypedColumnValue<string>("Language28Short");
			}
			set {
				SetColumnValue("Language28Short", value);
			}
		}

		/// <summary>
		/// Language29Short.
		/// </summary>
		public string Language29Short {
			get {
				return GetTypedColumnValue<string>("Language29Short");
			}
			set {
				SetColumnValue("Language29Short", value);
			}
		}

		/// <summary>
		/// Language30Short.
		/// </summary>
		public string Language30Short {
			get {
				return GetTypedColumnValue<string>("Language30Short");
			}
			set {
				SetColumnValue("Language30Short", value);
			}
		}

		/// <summary>
		/// Error message.
		/// </summary>
		public string ErrorMessage {
			get {
				return GetTypedColumnValue<string>("ErrorMessage");
			}
			set {
				SetColumnValue("ErrorMessage", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysTranslation_TranslationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysTranslationDeleted", e);
			Saved += (s, e) => ThrowEvent("SysTranslationSaved", e);
			Saving += (s, e) => ThrowEvent("SysTranslationSaving", e);
			Updated += (s, e) => ThrowEvent("SysTranslationUpdated", e);
			Validating += (s, e) => ThrowEvent("SysTranslationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysTranslation(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysTranslation_TranslationEventsProcess

	/// <exclude/>
	public partial class SysTranslation_TranslationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysTranslation
	{

		public SysTranslation_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysTranslation_TranslationEventsProcess";
			SchemaUId = new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4a564759-cf96-48d9-ae57-97bbb9c0b951");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsInActualizing {
			get;
			set;
		}

		private ProcessFlowElement _sysTranslationSavedEventSubProcess;
		public ProcessFlowElement SysTranslationSavedEventSubProcess {
			get {
				return _sysTranslationSavedEventSubProcess ?? (_sysTranslationSavedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysTranslationSavedEventSubProcess",
					SchemaElementUId = new Guid("7f01fa69-82cf-47b3-b3ac-8cf67553e339"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysTranslationSavedStartMessage;
		public ProcessFlowElement SysTranslationSavedStartMessage {
			get {
				return _sysTranslationSavedStartMessage ?? (_sysTranslationSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysTranslationSavedStartMessage",
					SchemaElementUId = new Guid("95a1d21e-9487-4d18-ae66-3ed288c4993f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysTranslationSavedScriptTask;
		public ProcessScriptTask SysTranslationSavedScriptTask {
			get {
				return _sysTranslationSavedScriptTask ?? (_sysTranslationSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysTranslationSavedScriptTask",
					SchemaElementUId = new Guid("3154f277-1160-49a5-b3fd-4c7dbf93514c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysTranslationSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sysTranslationUpdatedEventSubProcess;
		public ProcessFlowElement SysTranslationUpdatedEventSubProcess {
			get {
				return _sysTranslationUpdatedEventSubProcess ?? (_sysTranslationUpdatedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysTranslationUpdatedEventSubProcess",
					SchemaElementUId = new Guid("23caadfd-86de-4fb9-a774-e8f107bb7080"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysTranslationUpdatedStartMessage;
		public ProcessFlowElement SysTranslationUpdatedStartMessage {
			get {
				return _sysTranslationUpdatedStartMessage ?? (_sysTranslationUpdatedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysTranslationUpdatedStartMessage",
					SchemaElementUId = new Guid("07371b4a-fa36-4b95-8dbe-1f3ff54303bd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysTranslationUpdatedScriptTask;
		public ProcessScriptTask SysTranslationUpdatedScriptTask {
			get {
				return _sysTranslationUpdatedScriptTask ?? (_sysTranslationUpdatedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysTranslationUpdatedScriptTask",
					SchemaElementUId = new Guid("c8ab652e-78ef-4475-9e80-4f852c3441cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysTranslationUpdatedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sysTranslationSavingEventSubProcess;
		public ProcessFlowElement SysTranslationSavingEventSubProcess {
			get {
				return _sysTranslationSavingEventSubProcess ?? (_sysTranslationSavingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysTranslationSavingEventSubProcess",
					SchemaElementUId = new Guid("92d9c732-7a4c-4679-af97-7adafc0f0b97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysTranslationSavingStartMessage;
		public ProcessFlowElement SysTranslationSavingStartMessage {
			get {
				return _sysTranslationSavingStartMessage ?? (_sysTranslationSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysTranslationSavingStartMessage",
					SchemaElementUId = new Guid("0054fef8-3a89-4e23-89a8-93ea36d1aeb0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysTranslationSavingScriptTask;
		public ProcessScriptTask SysTranslationSavingScriptTask {
			get {
				return _sysTranslationSavingScriptTask ?? (_sysTranslationSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysTranslationSavingScriptTask",
					SchemaElementUId = new Guid("608e4db7-d3cb-44a8-85bf-4f29bccd28a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysTranslationSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SysTranslationSavedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysTranslationSavedEventSubProcess };
			FlowElements[SysTranslationSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysTranslationSavedStartMessage };
			FlowElements[SysTranslationSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysTranslationSavedScriptTask };
			FlowElements[SysTranslationUpdatedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysTranslationUpdatedEventSubProcess };
			FlowElements[SysTranslationUpdatedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysTranslationUpdatedStartMessage };
			FlowElements[SysTranslationUpdatedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysTranslationUpdatedScriptTask };
			FlowElements[SysTranslationSavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysTranslationSavingEventSubProcess };
			FlowElements[SysTranslationSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysTranslationSavingStartMessage };
			FlowElements[SysTranslationSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysTranslationSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SysTranslationSavedEventSubProcess":
						break;
					case "SysTranslationSavedStartMessage":
						e.Context.QueueTasks.Enqueue("SysTranslationSavedScriptTask");
						break;
					case "SysTranslationSavedScriptTask":
						break;
					case "SysTranslationUpdatedEventSubProcess":
						break;
					case "SysTranslationUpdatedStartMessage":
						e.Context.QueueTasks.Enqueue("SysTranslationUpdatedScriptTask");
						break;
					case "SysTranslationUpdatedScriptTask":
						break;
					case "SysTranslationSavingEventSubProcess":
						break;
					case "SysTranslationSavingStartMessage":
						e.Context.QueueTasks.Enqueue("SysTranslationSavingScriptTask");
						break;
					case "SysTranslationSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysTranslationSavedStartMessage");
			ActivatedEventElements.Add("SysTranslationUpdatedStartMessage");
			ActivatedEventElements.Add("SysTranslationSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SysTranslationSavedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysTranslationSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysTranslationSavedStartMessage";
					result = SysTranslationSavedStartMessage.Execute(context);
					break;
				case "SysTranslationSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysTranslationSavedScriptTask";
					result = SysTranslationSavedScriptTask.Execute(context, SysTranslationSavedScriptTaskExecute);
					break;
				case "SysTranslationUpdatedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysTranslationUpdatedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysTranslationUpdatedStartMessage";
					result = SysTranslationUpdatedStartMessage.Execute(context);
					break;
				case "SysTranslationUpdatedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysTranslationUpdatedScriptTask";
					result = SysTranslationUpdatedScriptTask.Execute(context, SysTranslationUpdatedScriptTaskExecute);
					break;
				case "SysTranslationSavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysTranslationSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysTranslationSavingStartMessage";
					result = SysTranslationSavingStartMessage.Execute(context);
					break;
				case "SysTranslationSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysTranslationSavingScriptTask";
					result = SysTranslationSavingScriptTask.Execute(context, SysTranslationSavingScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "IsInActualizing":
					IsInActualizing = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SysTranslationSavedScriptTaskExecute(ProcessExecutingContext context) {
			return OnSysTranslationSaved(context);
		}

		public virtual bool SysTranslationUpdatedScriptTaskExecute(ProcessExecutingContext context) {
			return OnSysTranslationUpdated(context);
		}

		public virtual bool SysTranslationSavingScriptTaskExecute(ProcessExecutingContext context) {
			return OnSysTranslationSaving(context);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysTranslationSaved":
							if (ActivatedEventElements.Contains("SysTranslationSavedStartMessage")) {
							context.QueueTasks.Enqueue("SysTranslationSavedStartMessage");
						}
						break;
					case "SysTranslationUpdated":
							if (ActivatedEventElements.Contains("SysTranslationUpdatedStartMessage")) {
							context.QueueTasks.Enqueue("SysTranslationUpdatedStartMessage");
						}
						break;
					case "SysTranslationSaving":
							if (ActivatedEventElements.Contains("SysTranslationSavingStartMessage")) {
							context.QueueTasks.Enqueue("SysTranslationSavingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsInActualizing") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsInActualizing", IsInActualizing, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysTranslation_TranslationEventsProcess

	/// <exclude/>
	public class SysTranslation_TranslationEventsProcess : SysTranslation_TranslationEventsProcess<SysTranslation>
	{

		public SysTranslation_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysTranslation_TranslationEventsProcess

	public partial class SysTranslation_TranslationEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool OnSysTranslationSaved(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool OnSysTranslationUpdated(ProcessExecutingContext context) {
			return true;
		}

		public virtual void SetIsChanged() {
			if (IsInActualizing) {
				return;
			}
			ITranslationActualizersFactory translationActualizersFactory = ClassFactory.Get<TranslationActualizersFactory>(
				new ConstructorArgument("userConnection", UserConnection));
			ITranslationActualizer translationActualizer = translationActualizersFactory.GetTranslationActualizer();
			translationActualizer.SetIsTranslationChanged(Entity);
		}

		public virtual bool OnSysTranslationSaving(ProcessExecutingContext context) {
			SetIsChanged();
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: SysTranslationEventsProcessSchema

	/// <exclude/>
	public class SysTranslationEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysTranslationEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysTranslationEventsProcessSchema(SysTranslationEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysTranslation_TranslationEventsProcess";
			UId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c");
			CreatedInPackageId = new Guid("bfca9347-f1f5-488e-aaab-4b6bdd3d61fe");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateIsInActualizingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("71997467-465a-46e5-9352-90e87b77b429"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"IsInActualizing",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsInActualizingParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaSysTranslationLaneSet = CreateSysTranslationLaneSetLaneSet();
			LaneSets.Add(schemaSysTranslationLaneSet);
			ProcessSchemaLane schemaSysTranslationLane = CreateSysTranslationLaneLane();
			schemaSysTranslationLaneSet.Lanes.Add(schemaSysTranslationLane);
			ProcessSchemaEventSubProcess systranslationsavedeventsubprocess = CreateSysTranslationSavedEventSubProcessEventSubProcess();
			FlowElements.Add(systranslationsavedeventsubprocess);
			ProcessSchemaEventSubProcess systranslationupdatedeventsubprocess = CreateSysTranslationUpdatedEventSubProcessEventSubProcess();
			FlowElements.Add(systranslationupdatedeventsubprocess);
			ProcessSchemaEventSubProcess systranslationsavingeventsubprocess = CreateSysTranslationSavingEventSubProcessEventSubProcess();
			FlowElements.Add(systranslationsavingeventsubprocess);
			ProcessSchemaStartMessageEvent systranslationsavedstartmessage = CreateSysTranslationSavedStartMessageStartMessageEvent();
			systranslationsavedeventsubprocess.FlowElements.Add(systranslationsavedstartmessage);
			ProcessSchemaScriptTask systranslationsavedscripttask = CreateSysTranslationSavedScriptTaskScriptTask();
			systranslationsavedeventsubprocess.FlowElements.Add(systranslationsavedscripttask);
			ProcessSchemaStartMessageEvent systranslationupdatedstartmessage = CreateSysTranslationUpdatedStartMessageStartMessageEvent();
			systranslationupdatedeventsubprocess.FlowElements.Add(systranslationupdatedstartmessage);
			ProcessSchemaScriptTask systranslationupdatedscripttask = CreateSysTranslationUpdatedScriptTaskScriptTask();
			systranslationupdatedeventsubprocess.FlowElements.Add(systranslationupdatedscripttask);
			ProcessSchemaStartMessageEvent systranslationsavingstartmessage = CreateSysTranslationSavingStartMessageStartMessageEvent();
			systranslationsavingeventsubprocess.FlowElements.Add(systranslationsavingstartmessage);
			ProcessSchemaScriptTask systranslationsavingscripttask = CreateSysTranslationSavingScriptTaskScriptTask();
			systranslationsavingeventsubprocess.FlowElements.Add(systranslationsavingscripttask);
			FlowElements.Add(CreateSysTranslationSavedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSysTranslationUpdatedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSysTranslationSavingSequenceFlowSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysTranslationSavedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysTranslationSavedSequenceFlow",
				UId = new Guid("b68ce4f5-2a70-4280-afc2-59edc0c4c43e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("95a1d21e-9487-4d18-ae66-3ed288c4993f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3154f277-1160-49a5-b3fd-4c7dbf93514c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysTranslationUpdatedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysTranslationUpdatedSequenceFlow",
				UId = new Guid("151907b9-6dc8-4503-b9a9-f11edb742a01"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("07371b4a-fa36-4b95-8dbe-1f3ff54303bd"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c8ab652e-78ef-4475-9e80-4f852c3441cd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysTranslationSavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysTranslationSavingSequenceFlow",
				UId = new Guid("fbb37a48-c4f3-47f7-a2bd-fb4b58525b38"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0054fef8-3a89-4e23-89a8-93ea36d1aeb0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("608e4db7-d3cb-44a8-85bf-4f29bccd28a0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSysTranslationLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaSysTranslationLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("33d9163e-85fe-4313-a207-5538f433e278"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationLaneSet",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaSysTranslationLaneSet;
		}

		protected virtual ProcessSchemaLane CreateSysTranslationLaneLane() {
			ProcessSchemaLane schemaSysTranslationLane = new ProcessSchemaLane(this) {
				UId = new Guid("32ddd8a6-1425-421b-96c2-a318d728cca3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("33d9163e-85fe-4313-a207-5538f433e278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationLane",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaSysTranslationLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysTranslationSavedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysTranslationSavedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7f01fa69-82cf-47b3-b3ac-8cf67553e339"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32ddd8a6-1425-421b-96c2-a318d728cca3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationSavedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 180),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(220, 120),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysTranslationSavedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysTranslationSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("95a1d21e-9487-4d18-ae66-3ed288c4993f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f01fa69-82cf-47b3-b3ac-8cf67553e339"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysTranslationSaved",
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysTranslationSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3154f277-1160-49a5-b3fd-4c7dbf93514c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f01fa69-82cf-47b3-b3ac-8cf67553e339"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(111, 26),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,174,44,14,41,74,204,43,206,73,44,201,204,207,11,78,44,75,77,209,72,206,207,43,73,173,40,209,180,6,0,174,93,117,57,38,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysTranslationUpdatedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysTranslationUpdatedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("23caadfd-86de-4fb9-a774-e8f107bb7080"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32ddd8a6-1425-421b-96c2-a318d728cca3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationUpdatedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(220, 127),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysTranslationUpdatedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysTranslationUpdatedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("07371b4a-fa36-4b95-8dbe-1f3ff54303bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23caadfd-86de-4fb9-a774-e8f107bb7080"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysTranslationUpdated",
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationUpdatedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysTranslationUpdatedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c8ab652e-78ef-4475-9e80-4f852c3441cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23caadfd-86de-4fb9-a774-e8f107bb7080"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationUpdatedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(111, 25),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,174,44,14,41,74,204,43,206,73,44,201,204,207,11,45,72,73,44,73,77,209,72,206,207,43,73,173,40,209,180,6,0,148,3,195,52,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysTranslationSavingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysTranslationSavingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("92d9c732-7a4c-4679-af97-7adafc0f0b97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32ddd8a6-1425-421b-96c2-a318d728cca3"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationSavingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 324),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(220, 127),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysTranslationSavingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysTranslationSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0054fef8-3a89-4e23-89a8-93ea36d1aeb0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92d9c732-7a4c-4679-af97-7adafc0f0b97"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysTranslationSaving",
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(37, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysTranslationSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("608e4db7-d3cb-44a8-85bf-4f29bccd28a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92d9c732-7a4c-4679-af97-7adafc0f0b97"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Name = @"SysTranslationSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(111, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,207,11,174,44,14,41,74,204,43,206,73,44,201,204,207,11,78,44,203,204,75,215,72,206,207,43,73,173,40,209,180,6,0,112,125,181,238,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnSysTranslationSavedMethod());
			Methods.Add(CreateOnSysTranslationUpdatedMethod());
			Methods.Add(CreateSetIsChangedMethod());
			Methods.Add(CreateOnSysTranslationSavingMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f3aa6aeb-382b-497e-a59d-89b0eef7925b"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b41a14f5-3daa-42b9-87f4-ac9b5cd432a7"),
				Name = "Terrasoft.Core.Translation",
				Alias = "",
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2418f9f5-c6dd-488a-9a8d-7e78a3f9cec4"),
				Name = "Terrasoft.Configuration.Translation",
				Alias = "",
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b261d1c9-cc98-44e8-aabd-7806d1dc26ed"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateOnSysTranslationSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b368fd4d-3cf2-4282-843e-cba165d0e674"),
				Name = "OnSysTranslationSaved",
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b4f22289-9c64-46a7-b8a1-5ba6104e0f74"),
				Name = "context",
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSysTranslationUpdatedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a4725185-041d-4cdc-bb52-c16d1f2bdd1a"),
				Name = "OnSysTranslationUpdated",
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("88fe36bf-6ce9-45b2-adeb-3778c10ec2d9"),
				Name = "context",
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetIsChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("384a34b7-24e6-4f5c-9ffc-bc16e95dcdb2"),
				Name = "SetIsChanged",
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,193,10,194,48,16,68,207,22,250,15,161,167,4,164,63,80,21,74,81,201,89,253,128,80,215,26,104,183,176,187,65,170,248,239,54,7,69,161,246,184,51,59,51,207,95,148,182,108,177,172,37,184,214,223,61,54,70,61,210,100,65,32,129,176,72,147,103,154,216,35,57,228,214,137,239,63,143,64,188,115,181,244,52,40,153,117,215,170,106,29,191,207,124,15,178,154,173,219,232,113,29,225,166,170,30,89,40,68,177,164,38,116,128,162,179,192,64,163,129,80,199,116,182,84,167,31,193,152,226,31,238,52,230,136,55,139,31,121,39,235,116,92,154,140,230,7,16,203,95,161,234,234,176,129,179,222,162,120,25,76,241,2,38,128,119,145,116,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnSysTranslationSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a268a0ca-959e-4228-abe0-663fbcfe64d6"),
				Name = "OnSysTranslationSaving",
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e6bdd824-6e39-458f-bb8a-6cf78b09bba1"),
				Name = "context",
				CreatedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				ModifiedInSchemaUId = new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,241,44,118,206,72,204,75,79,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,93,16,15,111,28,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysTranslationEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0d4563f2-260c-481c-bf68-97722cd8525c"));
		}

		#endregion

	}

	#endregion


	#region Class: SysTranslationEventsProcess

	/// <exclude/>
	public class SysTranslationEventsProcess : SysTranslation_TranslationEventsProcess
	{

		public SysTranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

