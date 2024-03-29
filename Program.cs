﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokkaharjoituksia1
{
    class Hooman
    {
        // Define properties of Hooman ie. fields
        public string name = "Essi Esimerkki";
        public int age = 30;
        public string gender = "Emäntä";

        // Default constructor w/o arguments
        // No need to define, will be crated automatically
        public Hooman()
        {

        }

        // Constructor with one argument
        public Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with 2 arguments
        public Hooman(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Constructor with 3 arguments
        public Hooman(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

        }

        // A method to say something
        public void SayOpinion()
        {
            Console.WriteLine("Voi, lemmikit ne on elämän suola");
        }
    }
    //eats method is explicity defind to be over written in the subclass with keyword virtual
    
    
    class Pet
    {
        public virtual void Eats()
        {
            Console.WriteLine("lemmikit syö ruokaa");
        }
    }
    // A subclass of pet
    class Hare : Pet
    { 
        public override void Eats()
        {
            Console.WriteLine(" jyrsiä syö porkkanoita");
        }
 }


    class CatOwner : Hooman
    {
        public new void SayOpinion()
        {
            Console.WriteLine("Kissat ovat itsenäisiä ja pitävät hiiret loitolla");
        }
    }
    class DogOwner : Hooman
    { 
        public new void SayOpinion() 
        {
            Console.WriteLine("Enemmän me syödään jyrsiöitä, sanoi koira");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Create (instantiate) a hooman object from Hooman class
            Hooman owner = new Hooman("Ossi Omistaja", 35, "isäntä");

            // Call the SayOpinion method
            owner.SayOpinion();

            // Save owners name property to a variable
            string who = owner.name;

            // Test it by echoing it to a console
            Console.WriteLine("totesi " + who);


            // Create a new catowner object
            CatOwner catOwner = new CatOwner();
            // Use catowners SayOpinion method
            catOwner.SayOpinion();

            Console.WriteLine();

            // Create a new dogowner object
            DogOwner DogOwner = new DogOwner();
            // Use dogowners SayOpinion method
            DogOwner.SayOpinion();

            Console.WriteLine();

            Pet Pet = new Pet();
            Pet.Eats();

            Hare Hare = new Hare();
            Hare.Eats();

            // Keep the window opent until enter pressed
            Console.ReadLine();
        }
    }
}