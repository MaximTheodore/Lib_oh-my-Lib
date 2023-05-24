using Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyLib
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }
        private void SerializeButton_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person { Name = "John", Age = 30 };
            string serializedData = SerializationLibrary.Serialize(person, "Main");
            MessageBox.Show("Serialized Data: " + serializedData);
        }

        private void DeserializeButton_Click(object sender, RoutedEventArgs e)
        {
            string jsonData = JsonTextBox.Text;
            Person deserializedPerson = SerializationLibrary.Deserialize<Person>(jsonData);
            MessageBox.Show("Deserialized Person: Name = " + deserializedPerson.Name + ", Age = " + deserializedPerson.Age);
        }
        private void SecondPageButton_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).Page.Content = new PageSecond();
        }

      
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

