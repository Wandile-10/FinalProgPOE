using System.Windows;

namespace FinalProgPOE
{
    public partial class DeleteRecipe : Window
    {
        // Constructor
        public DeleteRecipe()
        {
            InitializeComponent();
        }

        // Event handler for Delete button
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // Implement your delete logic here
            // Example: Delete the recipe from database or collection
            MessageBox.Show("Recipe deleted successfully!");

            // Close the DeleteRecipe window after deletion
            this.Close();
        }

        // Event handler for Cancel button
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // Simply close the window without performing any delete action
            this.Close();
        }
    }
}
