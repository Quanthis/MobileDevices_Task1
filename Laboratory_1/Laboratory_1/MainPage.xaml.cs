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

        private async void Button_OK(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string surName = SurName.Text;
            string gender = Gender.Text;
            string age = Age.Text;

            Person.Gender genderC;

            if(gender == "Male")
            {
                genderC = Person.Gender.Male;
            }
            else
            {
                genderC = Person.Gender.Female;
            }

            Person person = new Person(firstName, surName, genderC, age);

            await Navigation.PushAsync(new PersonPage(person));

            FirstName.Text = "";
            SurName.Text = "";
            Gender.Text = "";
            Age.Text = "";
        }

    }
}
