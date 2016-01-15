using System.Collections.Generic;
using System.Linq;

namespace ReloadedFramework.Model
{
	public static class Colour
	{
		/// <summary>
		/// List of default colours available to Reloaded users in the ThemePicker.
		/// </summary>
		static Dictionary<string, string> _colours = new Dictionary<string, string>();

		static Colour()
		{
			_colours.Add("Red", "rgba(244, 67, 54, 1)");
			_colours.Add("Pink", "rgba(233, 30, 99, 1)");
			_colours.Add("Purple", "rgba(156, 39, 176, 1)");
			_colours.Add("Deep Purple", "rgba(103, 58, 183, 1)");
			_colours.Add("Indigo", "rgba(63, 81, 181, 1)");
			_colours.Add("Blue", "rgba(33, 150, 243, 1)");
			_colours.Add("Light Blue", "rgba(3, 169, 244, 1)");
			_colours.Add("Cyan", "rgba(0, 188, 212, 1)");
			_colours.Add("Teal", "rgba(0, 150, 136, 1)");
			_colours.Add("Green", "rgba(76, 175, 80, 1)");
			_colours.Add("Light Green", "rgba(139, 195, 74, 1)");
			_colours.Add("Lime", "rgba(205, 220, 57, 1)");
			_colours.Add("Yellow", "rgba(255, 235, 59, 1)");
			_colours.Add("Amber", "rgba(255, 193, 7, 1)");
			_colours.Add("Orange", "rgba(255, 152, 0, 1)");
			_colours.Add("Deep Orange", "rgba(255, 87, 34, 1)");
			_colours.Add("Brown", "rgba(121, 85, 72, 1)");
			_colours.Add("Grey", "rgba(117, 117, 117, 1)");
			_colours.Add("Blue Grey", "rgba(69, 90, 100, 1)");
		}

		/// <summary>
		/// Converts the given RGB value to the corresponding colour name, if present.
		/// </summary>
		/// <param name="rgba"></param>
		/// <returns>Colour Name</returns>
		public static string RBGAToColourName(string rgba)
		{
			return _colours.FirstOrDefault(x => x.Value == rgba).Key;
		}

		/// <summary>
		/// Converts the given Colour name into the correspoinding RGB value, if present.
		/// </summary>
		/// <param name="colour"></param>
		/// <returns>RGB colour value.</returns>
		public static string ColourNameToRGBA(string colour)
		{
			return _colours[colour];
		}
	}
}
