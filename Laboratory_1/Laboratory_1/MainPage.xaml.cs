using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratory_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Person person;
        private async void Button_OK(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string surName = SurName.Text;
            string age = Age.Text;

            Person.Gender genderC;

            if(MaleButton.IsChecked == true)
            {
                genderC = Person.Gender.Male;
            }
            else if(FemaleButton.IsChecked == true)
            {
                genderC = Person.Gender.Female;
            }
            else
            {
                genderC = Person.Gender.NotSpecified;
            }

            person = new Person(firstName, surName, genderC, age);

            await Navigation.PushAsync(new PersonPage(person));

            FirstName.Text = "";
            SurName.Text = "";
            Age.Text = "";
        }

    }
}
