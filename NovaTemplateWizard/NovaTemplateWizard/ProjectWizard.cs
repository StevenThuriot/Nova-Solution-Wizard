#region License
// 
//  Copyright 2012 Steven Thuriot
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
#endregion
using System.Collections.Generic;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace NovaTemplateWizard
{
	/// <summary>
	/// The wizard used to create the projects.
	/// </summary>
	public class ProjectWizard : IWizard
	{
		/// <summary>
		/// Runs custom wizard logic at the beginning of a template wizard run.
		/// </summary>
		/// <param name="automationObject">The automation object being used by the template wizard.</param>
		/// <param name="replacementsDictionary">The list of standard parameters to be replaced.</param>
		/// <param name="runKind">A <see cref="T:Microsoft.VisualStudio.TemplateWizard.WizardRunKind"/> indicating the type of wizard run.</param>
		/// <param name="customParams">The custom parameters with which to perform parameter replacement in the project.</param>
		public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
		{
			//Making sure the first letter of the project is a capital.
			replacementsDictionary["$safeprojectname$"] = replacementsDictionary["$safeprojectname$"].CapitalizeFirstLetter();

			//Inserting our global variables into the project's variables as well.
			foreach (var pair in SolutionWizard.GlobalDictionary)
			{
				replacementsDictionary.Add(pair.Key, pair.Value);
			}
		}

		/// <summary>
		/// Runs custom wizard logic when a project has finished generating.
		/// </summary>
		/// <param name="project">The project that finished generating.</param>
		public void ProjectFinishedGenerating(Project project)
		{
			
		}

		/// <summary>
		/// Runs custom wizard logic when a project item has finished generating.
		/// </summary>
		/// <param name="projectItem">The project item that finished generating.</param>
		public void ProjectItemFinishedGenerating(ProjectItem projectItem)
		{
			
		}

		/// <summary>
		/// Indicates whether the specified project item should be added to the project.
		/// </summary>
		/// <param name="filePath">The path to the project item.</param>
		/// <returns>
		/// true if the project item should be added to the project; otherwise, false.
		/// </returns>
		public bool ShouldAddProjectItem(string filePath)
		{
			return true;
		}

		/// <summary>
		/// Runs custom wizard logic before opening an item in the template.
		/// </summary>
		/// <param name="projectItem">The project item that will be opened.</param>
		public void BeforeOpeningFile(ProjectItem projectItem)
		{
			
		}

		/// <summary>
		/// Runs custom wizard logic when the wizard has completed all tasks.
		/// </summary>
		public void RunFinished()
		{
			
		}
	}
}
