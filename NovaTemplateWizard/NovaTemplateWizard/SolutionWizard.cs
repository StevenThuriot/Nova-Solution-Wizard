using System;
using System.Collections.Generic;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace NovaTemplateWizard
{
	/// <summary>
	/// The wizard used to create the solution.
	/// </summary>
	public class SolutionWizard : IWizard
	{
		/// <summary>
		/// Global dictionary to share with child wizards. 
		/// This is mainly useful for sharing global guids and the solution name.
		/// </summary>
		public static Dictionary<string, string> GlobalDictionary;
		
		/// <summary>
		/// Runs custom wizard logic at the beginning of a template wizard run.
		/// </summary>
		/// <param name="automationObject">The automation object being used by the template wizard.</param>
		/// <param name="replacementsDictionary">The list of standard parameters to be replaced.</param>
		/// <param name="runKind">A <see cref="T:Microsoft.VisualStudio.TemplateWizard.WizardRunKind"/> indicating the type of wizard run.</param>
		/// <param name="customParams">The custom parameters with which to perform parameter replacement in the project.</param>
		public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
		{
			GlobalDictionary = new Dictionary<string, string>();

			//Saving the solution name to our dictionary for the project wizards to use.
			GlobalDictionary["$safesolutionname$"] = replacementsDictionary["$safeprojectname$"];
			GlobalDictionary["$solutionname$"] = replacementsDictionary["$projectname$"];

			GlobalDictionary["$interfacesguid$"] = Guid.NewGuid().ToString();
			GlobalDictionary["$domainguid$"] = Guid.NewGuid().ToString();
			GlobalDictionary["$infrastructureguid$"] = Guid.NewGuid().ToString();
			GlobalDictionary["$controllersguid$"] = Guid.NewGuid().ToString();
			GlobalDictionary["$viewguid$"] = Guid.NewGuid().ToString();
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
		/// Runs custom wizard logic when the wizard has completed all tasks.
		/// </summary>
		public void RunFinished()
		{
			//Cleaning up our dictionary.
			GlobalDictionary.Clear();
			GlobalDictionary = null;
		}

		/// <summary>
		/// Runs custom wizard logic before opening an item in the template.
		/// </summary>
		/// <param name="projectItem">The project item that will be opened.</param>
		public void BeforeOpeningFile(ProjectItem projectItem)
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
		/// Runs custom wizard logic when a project has finished generating.
		/// </summary>
		/// <param name="project">The project that finished generating.</param>
		public void ProjectFinishedGenerating(Project project)
		{
		}
	}
}
