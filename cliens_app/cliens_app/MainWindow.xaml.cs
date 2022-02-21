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

namespace cliens_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { firstName = "John", lastName = "Doe" });
            people.Add(new Person { firstName = "Joe", lastName = "Smith" });
            people.Add(new Person { firstName = "Sue", lastName = "Storm" });

            foreach(Person person in people)
            {
                person.setFullName();
            }
            NameComboBx.ItemsSource = people;
            

        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameTxtBx.Text} {lastNameTxtBx.Text}");
        }
    }
}
