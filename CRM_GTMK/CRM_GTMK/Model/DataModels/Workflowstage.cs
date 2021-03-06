﻿using System.ComponentModel;

namespace CRM_GTMK.Model.DataModels
{
	public enum Workflowstage
	{
		[Description("Translation")]
		Translation,
		[Description("Editing")]
		Editing,
		[Description("Proofreading")]
		Proofreading,
		[Description("Postediting")]
		Postediting,
		[Description("CrowdTranslation")]
		CrowdTranslation,
		[Description("CrowdReview")]
		CrowdReview,
		[Description("Empty")]
		Empty,
		[Description("Source layout and text check")]
		SourceLayout,
		[Description("Post-translation layout check")]
		PostTranslationLayout
	};
}