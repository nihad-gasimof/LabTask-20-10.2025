using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Dersi_17_10_2025;

public class Person
{
    public string Name;
    public string Surname;
    public int Age;


    public Person(string name)
    {
        Name = name;
        Surname = "XXXXXXXXX";
        Age = 0;
    }
    public Person(string name, int age)
    {
        if (age < 0)
        {
            age = 0;
        }
        else
        {
            Name = name;
            Age = age;
            Surname = "XXXXXXXXX";
        }
    }
    public Person(string name, string surname)
    {
        Name = name;
        Age = 0;
        if (surname.Length < 3)
        {
            Surname = "XXXXXXXXX";
        }
        else
        {
            Surname = surname;
        }
    }
    public Person(string name,string surname,int age):this(name,surname)
    {
        Name = name;

        if (age < 0)
        {
            Age = 0;
        }
        else
        {
            Age = age;
        }
    }
}

