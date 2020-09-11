namespace Terrasoft.Configuration.ESN
{
	using System;
	using System.Runtime.Serialization;
	using Terrasoft.Nui.ServiceModel.DataContract;

	#region  Class: EsnReadMessageDTO

	[DataContract]
	public class EsnReadMessageDTO
	{
		#region Properties: Public

		[DataMember(Name = "Id")]
		public Guid Id { get; set; }

		[DataMember(Name = "CommentCount")]
		public int CommentCount { get; set; }

		[DataMember(Name = "CreatedBy")]
		public LookupColumnValue CreatedBy { get; set; }

		[DataMember(Name = "CreatedOn")]
		public string CreatedOn { get; set; }

		[DataMember(Name = "LastActionOn")]
		public string LastActionOn { get; set; }

		[DataMember(Name = "EntityId")]
		public Guid EntityId { get; set; }

		[DataMember(Name = "Message")]
		public string Message { get; set; }

		[DataMember(Name = "EntitySchemaUId")]
		public Guid EntitySchemaUId { get; set; }

		[DataMember(Name = "EntitySchemaName")]
		public string EntitySchemaName { get; set; }
		
		[DataMember(Name = "EntitySchemaCaption")]
		public string EntitySchemaCaption { get; set; }

		[DataMember(Name = "LikeCount")]
		public int LikeCount { get; set; }

		[DataMember(Name = "LinkPreviewData")]
		public byte[] LinkPreviewData { get; set; }

		[DataMember(Name = "Parent")]
		public LookupColumnValue Parent { get; set; }

		[DataMember(Name = "Color")]
		public string Color { get; set; }

		#endregion
	}

	#endregion

	#region  Class: EsnWriteMessageDTO

	[DataContract]
	public class EsnWriteMessageDTO 
	{
		[DataMember(Name = "SchemaUId")]
		public Guid SchemaUId { get; set; }

		[DataMember(Name = "EntityId")]
		public Guid EntityId { get; set; }

		[DataMember(Name = "Message")]
		public string Message { get; set; }
	}

	#endregion
}

