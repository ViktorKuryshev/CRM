using CRM_GTMK.Model.DataModels;
using System.Collections.Generic;

namespace CRM_GTMK.Model
{
    public static class GlobalValues
    {
        public static List<RecievedProject> CurrentProjects { get; set; } = new List<RecievedProject>();
        public static MyProject FocusedProject { get; set; }
        public static string[] DocumentsPaths { get; set; } = new string[] { };
        public static Company FocusedCompany { get; set; }

        public static bool ShouldSerializeFocusedProject()
        { return FocusedProject != null; }
        public static bool ShouldSerializeFocusedCompany()
        { return FocusedCompany != null; }
    }
}
