using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Salad_Recipe_Final_Poe_3
{
    public partial class Remove_Recipes : Page
    {
        public Remove_Recipes()
        {
            InitializeComponent();
            lvEntries.ItemsSource = Add_Recipes.Recipes;
        }

        private void RemoveRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (lvEntries.SelectedItem is Recipe selectedRecipe)
            {
                Add_Recipes.Recipes.Remove(selectedRecipe);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
