using System.Windows;

namespace FinalProgPOE
{
    public partial class AddRecipe : Window
    {
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Implement save functionality here
            string recipeName = RecipeNameTextBox.Text;
            string ingredients = IngredientsTextBox.Text;
            string directions = DirectionsTextBox.Text;
            string foodGroup = FoodGroupTextBox.Text;
            string calories = CaloriesTextBox.Text;

            // Here you can save the recipe details to a database, file, or any other storage

            MessageBox.Show("Recipe saved!\n" +
                            "Name: " + recipeName + "\n" +
                            "Ingredients: " + ingredients + "\n" +
                            "Directions: " + directions + "\n" +
                            "Food Group: " + foodGroup + "\n" +
                            "Calories: " + calories);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

