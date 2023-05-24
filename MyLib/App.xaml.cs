using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MyCustomThemes;
namespace MyLib
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var descktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (File.Exists($"{descktop}\\theme.txt"))
            {
                Theme = File.ReadAllText($"{descktop}\\theme.txt");
            }
            
        }
        private static string theme;

        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                var dict = new ResourceDictionary { Source = new Uri($"D:/2/c#/Приложения/MyLib/MyCustomThemes/{value}", UriKind.Absolute) };
                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0,dict);
                File.WriteAllText("C:\\Users\\user6\\OneDrive\\Рабочий стол\\theme.txt", value);
            }
        }
    }

}
