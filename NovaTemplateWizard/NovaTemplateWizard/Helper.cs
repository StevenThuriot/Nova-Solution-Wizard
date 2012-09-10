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
