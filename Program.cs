using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prviZadatak
{

    class FoodType
    {
        private string name;
        private double protein, carbs, fat;
        public string ispis;
        private static int counter;

        public FoodType(string name, double protein, double carbs, double fat)
        {
            this.Name = name;
            this.Protein = protein;
            this.Carbs = carbs;
            this.Fat = fat;
            this.Ispis = ispis;
            Counter = Counter++;
        }

        

        public string Name { get => name; set => name = value; }
        public double Protein { get => protein; set => protein = value; }
        public double Carbs { get => carbs; set => carbs = value; }
        public double Fat { get => fat; set => fat = value; }
        public string Ispis { get => ispis; set => ispis = value; }
        public int Counter { get => counter; set => counter = value; }

        public override string ToString()
        {
            ispis = name + ": p - " + protein + "%, c - " + carbs + "%, f - " + fat + "%";

            return ispis.ToString();
        }

        public static int GetNumberOfCreatedInstances()
        {
            return counter;
        }
    }

    class Food
    {
        double weight;
        FoodType type;
        

        public Food( FoodType type,double weight)
        {
            this.Weight = weight;
            this.Type = type;
            
        }

        double Weight { get => weight; set => weight = value; }
        internal FoodType Type { get => type; set => type = value; }

        public string toStringsInGrams()
        {
            double ProteinGram = (weight * type.Protein)/ 100;
            double CarbsGram = (weight * type.Carbs)/ 100;
            double FatGram = (weight * type.Fat)/ 100;

            string ispis2 = type.Name + ": p - " + ProteinGram + "%, c - " + CarbsGram + "%, f - " + FatGram + "%";
            return ispis2;
        }

       

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodType, 110);
            Console.WriteLine(food.toStringsInGrams());
            Console.ReadKey();
        }
    }
}
