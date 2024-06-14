using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace Salad_Recipe_Final_Poe_3
{
    public partial class Edit_Recipes : Page
    {
        private Recipe selectedRecipe;

        public Edit_Recipes()
        {
            InitializeComponent();
            lvRecipes.ItemsSource = Add_Recipes.Recipes;
        }

        private void lvRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedRecipe = lvRecipes.SelectedItem as Recipe;
            if (selectedRecipe != null)
            {
                DisplayRecipe(selectedRecipe);
            }
        }

        private void DisplayRecipe(Recipe recipe)
        {
            txtRecipeName.Text = recipe.RecipeName;
            txtIngredients.Text = recipe.Ingredients;
            txtSteps.Text = recipe.Steps;
            txtMeasurements.Text = recipe.Measurements;
            txtInstructions.Text = recipe.Instructions;
            txtFoodGroup.Text = recipe.FoodGroup;
            txtCalories.Text = recipe.Calories;
            txtDescription.Text = recipe.Description;
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRecipe != null)
            {
                selectedRecipe.RecipeName = txtRecipeName.Text;
                selectedRecipe.Ingredients = txtIngredients.Text;
                selectedRecipe.Steps = txtSteps.Text;
                selectedRecipe.Measurements = txtMeasurements.Text;
                selectedRecipe.Instructions = txtInstructions.Text;
                selectedRecipe.FoodGroup = txtFoodGroup.Text;
                selectedRecipe.Calories = txtCalories.Text;
                selectedRecipe.Description = txtDescription.Text;

                MessageBox.Show("Unable to edit the recipe, please try again later ", "Error");
            }
            else
            {
                MessageBox.Show("Error: Recipe not found.", "Error");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
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
    }
}
