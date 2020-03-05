using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatToEat
{
    class BusinessLogic
    {
        public static string BestMatch(double kcal, double protein, int maxAmount = 500)
        {
            string whatToEat = "";
            double howMuch = 0;
            double howMuchProtein = 0;
            double howMuchKcal = 0;

            double minDif = 1000;
            foreach (var item in FoodDataBase.FoodData)
            {
                if (FoodDataBase.FoodCategories.Contains(item.Category))
                {
                    double kaloria = 0;
                    double KcalPer1Gram = item.Kcalper100Gram / 100;
                    double proteinPer1Gram = item.ProteinPer100Gram / 100;
                    int counter = 0;
                    while (kaloria < kcal && counter <= maxAmount)
                    {
                        counter++;
                        kaloria = counter * KcalPer1Gram;
                        if (kaloria >= kcal)
                        {
                            if (minDif > Math.Abs((proteinPer1Gram * counter) - protein))
                            {
                                minDif = Math.Abs((proteinPer1Gram * counter) - protein);
                                whatToEat = item.Name;
                                howMuch = counter;
                                howMuchProtein = proteinPer1Gram * counter;
                                howMuchKcal = KcalPer1Gram * counter;
                            }
                        }
                    }
                }   
            }

            Debug.Write("hello");
            //return "Egyél " + howMuch + "g " + whatToEat + "-t, ami így " + howMuchKcal + " kalória, és " + howMuchProtein + "g Fehérje lesz";
            return howMuch + "g " + whatToEat + "\n" +
                (int)howMuchKcal + " kalória \n" +
                (int)howMuchProtein + "g fehérje";
        }
    }
}
