using System.Collections.ObjectModel;

namespace Salad_Recipe_Final_Poe_3
{
    public class RecipeManager
    {
        private static RecipeManager instance;
        public ObservableCollection<Recipe> Recipes { get; private set; }

        private RecipeManager()
        {
            
        }

        public static RecipeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RecipeManager();
                }
                return instance;
            }
        }

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }

        public void RemoveRecipe(Recipe recipe)
        {
            Recipes.Remove(recipe);
        }
    }
}
