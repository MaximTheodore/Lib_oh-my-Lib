using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace MyCustomThemes
{
    class CustomThemes
    {
        public static ResourceDictionary GetLightTheme()
        {
            ResourceDictionary lightTheme = new ResourceDictionary();
            return lightTheme;
        }

        public static ResourceDictionary GetDarkTheme()
        {
            ResourceDictionary darkTheme = new ResourceDictionary();
            return darkTheme;
        }
    }
}
