using project_12_29_01.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_12_29_01.classes
{
    enum Role
    {
        Sudent = 1,
        Teacher = 2,
        Menager = 3,
        Director = 8
    }
    enum Permission
    {
        Administrator = 1,
        Modifier = 2,
        User = 3,
        Guest = 4,
    }
    public enum Gender
    {
        kobieta,
        mężczyzna
    }


    internal class Person
    {
        public string FirstName { private get; set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Permission Permission { get; set; }
        public Role Role { get; set; }
        public string GetData()
        {
            return "Imię i nazwisko: " + FirstName + " " + LastName + ", wzrost: " + Height + "cm, waga: " + Weight + "kg";
        }
    }
}
