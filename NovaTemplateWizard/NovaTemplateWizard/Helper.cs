using System;

namespace NovaTemplateWizard
{
	internal static class Helper
	{
		/// <summary>
		/// Capitalizes the first letter.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <returns></returns>
		public static string CapitalizeFirstLetter(this string source)
		{
			if (string.IsNullOrEmpty(source))
				return string.Empty;

			var letters = source.ToCharArray();
			letters[0] = char.ToUpper(letters[0]);
			return new string(letters);
		}

		/// <summary>
		/// Creates a new GUID.
		/// </summary>
		/// <returns>A new guid in string form.</returns>
		public static string CreateGuid()
		{
			return Guid.NewGuid().ToString();
		}
	}
}
