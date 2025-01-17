﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Dog // implicityly internal
    {
        // Access Modifiers:
        // Private: only things in this class can use it, default in a class
        // Public: everything that can see the class can access it
        // Internal: anything in this project can access it
        // Protected: anything that inherits from me can access

        // Properties
        // Access Modifier  Type    Name
        public string Size { get; set;} // auto-property
        public short Weight { get; private set;}
        public string Name { get; set; }

        // Constuctor, Constuctor Method
        public Dog(string name, short weight, string size)
        {
            Name = name;
            Weight = weight;
            Size = size;
        }

        // Method Signature : access modifier, return type, name, parameters
        // void means not returning anything
        public void Bark()
        {
            Console.WriteLine($"{Name} barks noisily.");
        }

        // Parameters are camelCase
        public void Eat(string typeOfFood)
        {
            //if (string.Equals(typeOfFood, "healthy food", StringComparison.OrdinalIgnoreCase))
            if (typeOfFood.ToLower() == "healthy food")
            {
                Weight -= 1;
            }
            Console.WriteLine($"{Name} just ate {typeOfFood}. {Name} weighs {Weight}.");
        }


    }
}
