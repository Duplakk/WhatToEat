using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatToEat
{
    class Food
    {
        public string Name;
        public double Kcalper100Gram;
        public double ProteinPer100Gram;
        public double KcalPer1GProtein;
        public double ProteinPer100Kcal;

        public Categories Category;

        public Food(string name, double Kcalper100Gram, double ProteinPer100Gram, Categories category)
        {
            this.Name = name;
            this.Kcalper100Gram = Kcalper100Gram;
            this.ProteinPer100Gram = ProteinPer100Gram;
            this.Category = category;

            this.KcalPer1GProtein = Kcalper100Gram/ ProteinPer100Gram;
            this.ProteinPer100Kcal = ProteinPer100Gram / (Kcalper100Gram/100);
        }
    }

    public enum Categories
    {
        Meat,
        Dairy,
        Egg,
        Vegetable,
        Seed,
        Grain,
        Meal
    }
}
