using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatToEat
{
    class FoodDataBase
    {
        public static List<Food> FoodData = new List<Food>();
        public static List<Categories> FoodCategories = new List<Categories>();

        public static void FillDataBase()
        {
            FoodData.Add(new Food("Csirkemell", 144, 28, Categories.Meat));
            FoodData.Add(new Food("Marhahús", 147, 21, Categories.Meat));
            FoodData.Add(new Food("Brokkoli", 24, 3.3, Categories.Vegetable));
            FoodData.Add(new Food("Sertéshús", 192, 26, Categories.Meat));
            FoodData.Add(new Food("Spárga", 17, 2, Categories.Vegetable));
            FoodData.Add(new Food("Túró", 147, 16, Categories.Dairy));
            FoodData.Add(new Food("Füstölt Lazac", 177, 19, Categories.Meat));
            FoodData.Add(new Food("Kelkáposzta", 35, 3.6, Categories.Vegetable));
            FoodData.Add(new Food("Kelbimbó", 51, 4.9, Categories.Vegetable));
            
            FoodData.Add(new Food("Tojás", 143, 12.6, Categories.Egg));
            FoodData.Add(new Food("Karfiol", 30, 2.4, Categories.Vegetable));
            FoodData.Add(new Food("Lencse", 342, 26, Categories.Vegetable));
            FoodData.Add(new Food("Zöldbab", 28, 2.1, Categories.Vegetable));
            FoodData.Add(new Food("Trappista", 381, 28, Categories.Dairy));
            FoodData.Add(new Food("Bab", 333, 24, Categories.Vegetable));
            FoodData.Add(new Food("Camembert", 308, 22, Categories.Dairy));
            FoodData.Add(new Food("Babgulyás", 96, 6.8, Categories.Meal));
            FoodData.Add(new Food("Sárgaborsó", 321, 21.7, Categories.Vegetable));
            FoodData.Add(new Food("Zöldborsó", 81, 5.4, Categories.Vegetable));

            FoodData.Add(new Food("Gyros pita", 138, 8.7, Categories.Meal));
            FoodData.Add(new Food("Petrezselyem", 32, 2, Categories.Vegetable));
            FoodData.Add(new Food("KFC Hotwings", 108, 6, Categories.Meat));
            FoodData.Add(new Food("Tej", 62, 3.4, Categories.Dairy));
            FoodData.Add(new Food("Tökmag", 623, 34, Categories.Seed));
            FoodData.Add(new Food("Karalábé", 39, 2.1, Categories.Vegetable));
            FoodData.Add(new Food("Csicseriborsó", 142, 7.5, Categories.Vegetable));
            FoodData.Add(new Food("Big Mac", 232, 12, Categories.Meal));
            FoodData.Add(new Food("Mandula", 626, 27.6, Categories.Seed));
            FoodData.Add(new Food("Földimogyoró", 609, 26.7, Categories.Seed));

            FoodData.Add(new Food("Pizza", 226, 9.7, Categories.Meal));
            FoodData.Add(new Food("Kukorica", 86, 3.3, Categories.Grain));
            FoodData.Add(new Food("Mák", 537, 20.5, Categories.Grain));
            FoodData.Add(new Food("Száraztészta", 389, 14, Categories.Grain));
            FoodData.Add(new Food("Bulgur", 342, 12.3, Categories.Grain));
            FoodData.Add(new Food("Quinoa", 374, 13.1, Categories.Grain));
            FoodData.Add(new Food("Hummus", 342, 11, Categories.Vegetable));
            FoodData.Add(new Food("Rozskenyér", 261, 8.1, Categories.Grain));
            FoodData.Add(new Food("Fehér kenyér", 270, 8.3, Categories.Grain));
            FoodData.Add(new Food("Kesudió", 596, 18, Categories.Seed));

            FoodData.Add(new Food("Burgonya", 80, 2, Categories.Vegetable));
            FoodData.Add(new Food("Bolognai spagetti", 174, 4.3, Categories.Meal));
            FoodData.Add(new Food("Dió", 654, 15.2, Categories.Seed));
            FoodData.Add(new Food("Rizs", 130, 2.7, Categories.Grain));
            FoodData.Add(new Food("Édesburgonya", 86, 1.5, Categories.Vegetable));
            FoodData.Add(new Food("Tejföl", 216, 3.3, Categories.Dairy));
            FoodData.Add(new Food("Rántott Csirkemell", 210, 20, Categories.Meat));
        }
    }
}
