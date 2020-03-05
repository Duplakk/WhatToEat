using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WhatToEat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoodDataBase.FillDataBase();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FoodDataBase.FoodCategories = new List<Categories>();
            CheckCategories();
            Result.Text = BusinessLogic.BestMatch(double.Parse(KcalTextBox.Text), double.Parse(ProteinTextBox.Text), int.Parse(MaxAmountTextBox.Text));
        }

        public void CheckCategories()
        {
            if ((bool)CheckBoxEgg.IsChecked) FoodDataBase.FoodCategories.Add(Categories.Egg);
            if ((bool)CheckBoxGrains.IsChecked) FoodDataBase.FoodCategories.Add(Categories.Grain);
            if ((bool)CheckBoxMeal.IsChecked) FoodDataBase.FoodCategories.Add(Categories.Meal);
            if ((bool)CheckBoxMeat.IsChecked) FoodDataBase.FoodCategories.Add(Categories.Meat);
            if ((bool)CheckBoxMilk.IsChecked) FoodDataBase.FoodCategories.Add(Categories.Dairy);
            if ((bool)CheckBoxSeeds.IsChecked) FoodDataBase.FoodCategories.Add(Categories.Seed);
            if ((bool)CheckBoxVegetable.IsChecked) FoodDataBase.FoodCategories.Add(Categories.Vegetable);
        }
    }
}
