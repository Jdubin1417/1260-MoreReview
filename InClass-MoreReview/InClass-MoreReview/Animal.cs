using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_MoreReview
{
    public class Animal
    {
        //Attributes
        //# of legs, species, color, name, age
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public Color FurColor { get; set; }
        public int NumLegs { get; set; }
        //public DateTime DateBorn { get; set; } //there is a DateTime data type in C# for dates

        //Constructors
        //1. Have the same name as the class
        //2. Have no return type
        //3. Used to create a new object of this class
        //   and set up the initial values of its attributes
        public Animal() //default constructor - sets attributes to default values
        {
            //you choose the default values
            Name = "";
            Age = 0;
            Species = "";
            FurColor = Color.Gray;
            NumLegs = 0;
        }

        //parameterized constructor - sets attributes to passed in values
        //**parameter**ized
        //can't have more than one with the same number, order, and types of parameters
        public Animal(string name, int age, string species, Color color, int numLegs) //fully parameterized
        {
            Name = name;
            Age = age;
            Species = species;
            FurColor = color;
            NumLegs = numLegs;
        }

        public Animal(string species) //also a parameterized constructor
        {
            Name = "";
            Age = 0;
            Species = species;
            FurColor = Color.Gray;
            NumLegs = 0;
        }

        public Animal(Animal other) //copy constructor - sets attributes to the values of the other, existing object's attributes
        {
            Name = other.Name;
            Age = other.Age;
            Species = other.Species;
            FurColor = other.FurColor;
            NumLegs = other.NumLegs;
        }

        //Methods
    }
}
