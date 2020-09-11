define("DeduplicationConstants", [], function() {
	return {
		serviceName: "DeduplicationService",
		findDuplicatesMethodName: "FindDuplicatesOnSave",
		setDuplicatesMethodName: "SetDuplicatesOnSave",
		features: {
			bulkDeduplication: "BulkESDeduplication",
			lazyDuplicatesPage: "LazyLoadDeduplicationResult"
		}
	};
});
