define("MoodCustomGeneratorV2", ["MoodCustomGeneratorV2Resources", "ext-base", "terrasoft"], function() {
	function generateCustomMoodControl(controlConfig) {
		return {
			className: "Terrasoft.ImageView",
			id: controlConfig.name + "ImageView",
			click: {bindTo: controlConfig.onMoodClick},
			imageSrc: {bindTo: controlConfig.getSrcMethod}
		};
	}
	return {
		generateCustomMoodControl: generateCustomMoodControl
	};
});
