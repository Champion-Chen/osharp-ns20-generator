using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;

namespace OSharp.Generator
{
    public class WizardImplementation : IWizard
    {
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind,
            object[] customParams)
        {
            
        }

        public void ProjectFinishedGenerating(Project project)
        { }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        { }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        public void BeforeOpeningFile(ProjectItem projectItem)
        { }

        public void RunFinished()
        { }
    }
}