using System;

namespace Inheritance
{
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            public class Animal
            {
                public string Name { get; set; }
                public double Age { get; set;}
                public string Habitat { get; set; }
                public bool IsWild { get; set; }
            }


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            public class Bird : Animal
            {
                public bool CanFly { get; set; }
                public double WingSpan { get; set; }
                public string BeakType { get; set; }
                public string MigrationSeason { get; set; }
            }

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            public class Reptile : Animal
            {
                public bool IsColdBlooded { get; set; }
                public bool CanRegrowTail { get; set; }
                public string ScaleType { get; set; }
                public string PreferredTempRange { get; set; }
            }
    class Program
    {   
        static void Main(string[] args) 
        {
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var eagle = new Bird()
            {
                Name = "Bald Eagle",
                Age = 5,
                Habitat = "Forests and Mountains",
                IsWild = true,
                CanFly = true,
                WingSpan = 2.3, //meters
                BeakType = "Hooked",
                MigrationSeason = "Winter"
            };
            
            
            Console.WriteLine($"---Bird Info---\nName: {eagle.Name}\nAge: {eagle.Age} years\nHabitat: {eagle.Habitat}\nIs Wild: {eagle.IsWild}\n:Can Fly: {eagle.CanFly}\nWing Span: {eagle.WingSpan} meters\nBeak Type: {eagle.BeakType}\nMigration Season: {eagle.MigrationSeason})");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            var gecko = new Reptile
            {
                Name = "Leopard Gecko",
                Age = 2,
                Habitat = "Desert",
                IsWild = false,
                IsColdBlooded = false,
                CanRegrowTail = true,
                ScaleType = "Ganular",
                PreferredTempRange = "75-90˚F"
            };
            Console.WriteLine($"---Reptile Info---\nName: {gecko.Name}\nAge: {gecko.Age} years\nHabitat: {gecko.Habitat}\nIs Wild: {gecko.IsWild}\nCold Blooded: {gecko.IsColdBlooded}\nCan Regrow Tail: {gecko.CanRegrowTail}\nScale Type: {gecko.ScaleType}\nPreferred Temp Range: {gecko.PreferredTempRange}");
        }
    }
}
