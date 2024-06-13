using System.Windows;

namespace FinalProgPOE
{
    public partial class ViewRecipe : Window
    {
        public ViewRecipe()
        {
            InitializeComponent();

            // Display Marry Me Chicken recipe by default
            DisplayMarryMeChicken();
        }

        private void DisplayMarryMeChicken()
        {
            Recipe maryMeChickenRecipe = new Recipe
            {
                Name = "Marry Me Chicken",
                Ingredients = "4 boneless, skinless chicken breasts\n" +
                              "Salt and pepper, to taste\n" +
                              "1/4 cup all-purpose flour\n" +
                              "2 tablespoons olive oil\n" +
                              "2 tablespoons butter\n" +
                              "3 cloves garlic, minced\n" +
                              "1 cup chicken broth\n" +
                              "1/2 cup heavy cream\n" +
                              "1 cup cherry tomatoes, halved\n" +
                              "Fresh basil leaves, for garnish",
                Directions = "1. Season chicken breasts with salt and pepper, then dredge in flour.\n" +
                             "2. In a large skillet, heat olive oil and butter over medium heat. Add chicken and cook until golden brown on each side.\n" +
                             "3. Add minced garlic and cook until fragrant.\n" +
                             "4. Pour in chicken broth and bring to a simmer. Add heavy cream and cherry tomatoes.\n" +
                             "5. Simmer until sauce thickens and chicken is cooked through.\n" +
                             "6. Garnish with fresh basil leaves before serving."
            };

            DisplayRecipe(maryMeChickenRecipe);
        }

        private void DisplayChickenPenneCasserole()
        {
            Recipe chickenPenneCasseroleRecipe = new Recipe
            {
                Name = "Chicken Penne Casserole",
                Ingredients = "8 oz penne pasta\n" +
                              "2 cups cooked chicken, shredded\n" +
                              "1 cup marinara sauce\n" +
                              "1 cup Alfredo sauce\n" +
                              "1 cup mozzarella cheese, shredded\n" +
                              "1/2 cup Parmesan cheese, grated\n" +
                              "Fresh parsley, for garnish",
                Directions = "1. Preheat oven to 350°F (175°C). Cook penne pasta according to package instructions.\n" +
                             "2. In a large bowl, combine cooked chicken, marinara sauce, and Alfredo sauce.\n" +
                             "3. Add cooked pasta to the sauce mixture and stir until well combined.\n" +
                             "4. Transfer to a greased baking dish and sprinkle with mozzarella and Parmesan cheese.\n" +
                             "5. Bake for 20-25 minutes, or until cheese is melted and bubbly.\n" +
                             "6. Garnish with fresh parsley before serving."
            };

            DisplayRecipe(chickenPenneCasseroleRecipe);
        }

        private void DisplayRecipe(Recipe recipe)
        {
            RecipeNameTextBlock.Text = recipe.Name;
            IngredientsTextBlock.Text = recipe.Ingredients;
            DirectionsTextBlock.Text = recipe.Directions;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Example: Define a class or structure for Recipe
        public class Recipe
        {
            public string Name { get; set; }
            public string Ingredients { get; set; }
            public string Directions { get; set; }
        }
    }
}

