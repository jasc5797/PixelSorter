using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelSorter
{
    public class SortSettings
    {
        /// <summary>
        /// Settings that the user can choose when pixel sorting an image
        /// </summary>
        public enum SortBy { Luminance, Brightness, Saturation, Hue }
        public enum SortDirection { Horizontal, Vertical, Angle }
        public enum IntervalType { Disabled, WholeImage, FromPixel }

        public SortBy SortBySelection { get; set; }
        public SortDirection SortDirectionSelection { get; set; }
        public IntervalType IntervalTypeSelection { get; set; }

        public Bitmap ImageOriginal { get; set; }
        public Bitmap ImageSorted { get; set; }

        public int Angle { get; set; }
        public int Interval { get; set; }

        /// <summary>
        /// Given an enum type get a human readable list of values from the enum that can be used as a data source
        /// </summary>
        /// <param name="type">The type of enum to convert into a data source</param>
        /// <returns>An array of strings in a human readable format. This array can be used as a data source</returns>
        public static string[] GetEnumAsDataSource(Type type){
            return GetReadableNames(Enum.GetNames(type));
        }

        /// <summary>
        /// Given an array of strings return an array human readable strings. 
        /// </summary>
        /// <param name="names">Names of the values</param>
        /// <returns>Returns a human readable version of the names given</returns>
        private static string[] GetReadableNames(string[] names)
        {
            for (int index = 0; index < names.Count(); index++)
            {
                names[index] = GetReadableName(names[index]);
            }
            return names;
        }

        /// <summary>
        /// Adds a space before each capital letter in a string. Ignores the capital at the start of the string. 
        /// This function creates more readable verisons of the given name.
        /// </summary>
        /// <param name="name">Name of the value to make more human readable</param>
        /// <returns>A more human readable version of the given string</returns>
        private static string GetReadableName(string name)
        {
            for (int index = 1; index < name.Length; index++)
            {
                if (char.IsUpper(name[index]))
                {
                    name = name.Insert(index, " ");
                    index += 1;
                }
            }
            return name;
        }
    }
}
