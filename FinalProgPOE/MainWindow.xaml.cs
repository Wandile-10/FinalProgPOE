using System.Windows;

namespace FinalProgPOE
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe addRecipeWindow = new AddRecipe();
            addRecipeWindow.Show();
        }

        private void ViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            ViewRecipe viewRecipeWindow = new ViewRecipe();
            viewRecipeWindow.Show();
        }

        private void EditRecipe_Click(object sender, RoutedEventArgs e)
        {
            EditRecipe editRecipeWindow = new EditRecipe();
            editRecipeWindow.Show();
        }

        private void DeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            DeleteRecipe deleteRecipeWindow = new DeleteRecipe();
            deleteRecipeWindow.Show();
        }
    }
}
