
using System.Windows;

namespace FinalProgPOE
{
    public partial class EditRecipe : Window
    {
        // Constructor
        public EditRecipe()
        {
            InitializeComponent();
        }

        // Event handler for Save button
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Example: Saving the recipe details
            string recipeName = RecipeNameTextBox.Text;
            string ingredients = IngredientsTextBox.Text;
            string directions = DirectionsTextBox.Text;
            string foodGroup = FoodGroupTextBox.Text;
            string calories = CaloriesTextBox.Text;

            // Implement your save logic here, for example:
            // SaveRecipe(recipeName, ingredients, directions, foodGroup, calories);

            MessageBox.Show("Recipe saved!");
        }

        // Event handler for Exit button
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
