using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_1
{
    public class Person
    {
        public enum Gender
        {
            Male,
            Female,
            NotSpecified
        };

        private string name;
        private string surname;
        private Gender gender;
        private string age;

        public Person(string name, string surname, Gender gender, string age)
        {
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public Gender GetGender()
        {
            return gender;
        }

        public string GetGenderInString()
        {
            if(gender == Gender.Female)
            {
                return "Female";
            }
            else
            {
                return "Male";
            }
        }

        public string GetAge()
        {
            return age;
        }
    }
}
