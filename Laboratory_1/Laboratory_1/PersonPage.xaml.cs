using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratory_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonPage : ContentPage
    {
        private Person person;

        public PersonPage()
        {
            InitializeComponent();
        }

        public PersonPage(Person person)
        {
            InitializeComponent();

            this.person = person;

            PageContent = Generate();
        }

        private StackLayout Generate()
        {
            /*Label firstName, surName, gender, age;

            firstName = new Label { Text = person.GetName() };
            surName = new Label { Text = person.GetSurname() };
            gender = new Label { Text = person.GetGenderInString() };
            age = new Label { Text = person.GetAge() };*/

            Label[] PersonData = new Label[4];

            PersonData[0] = new Label { Text = "Name: " + person.GetName() };
            PersonData[1] = new Label { Text = "Surname: " + person.GetSurname() };
            PersonData[2] = new Label { Text = "Gender: " + person.GetGenderInString() };
            PersonData[3] = new Label { Text = "Age: " + person.GetAge() };

            foreach(var item in PersonData)
            {
                PageContent.Children.Add(item);
            }

            return PageContent;
        }
    }
}