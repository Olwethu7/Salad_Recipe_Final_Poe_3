using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Salad_Recipe_Final_Poe_3
{
    public partial class Add_Recipes : Page
    {
        public static ObservableCollection<Recipe> Recipes { get; set; } = new ObservableCollection<Recipe>();

        public Add_Recipes()
        {
            InitializeComponent();
            lvEntries.ItemsSource = Recipes;
        }

        private void txtSteps_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void txtCalories_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]+");
            return !regex.IsMatch(text);
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var recipe = new Recipe
            {
                RecipeName = txtName.Text,
                Ingredients = txtIngredient.Text,
                Steps = txtSteps.Text,
                Measurements = txtMeasurements.Text,
                Instructions = txtInstructions.Text,
                FoodGroup = (cmbFoodGroup.SelectedItem as ComboBoxItem)?.Content.ToString(),
                Calories = txtCalories.Text,
                Description = txtDescription.Text
            };

            Recipes.Add(recipe);

            // Clear the input fields
            txtName.Clear();
            txtIngredient.Clear();
            txtSteps.Clear();
            txtMeasurements.Clear();
            txtInstructions.Clear();
            cmbFoodGroup.SelectedIndex = 0;
            txtCalories.Clear();
            txtDescription.Clear();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }

    public class Recipe
    {
        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public string Measurements { get; set; }
        public string Instructions { get; set; }
        public string FoodGroup { get; set; }
        public string Calories { get; set; }
        public string Description { get; set; }
    }
}
