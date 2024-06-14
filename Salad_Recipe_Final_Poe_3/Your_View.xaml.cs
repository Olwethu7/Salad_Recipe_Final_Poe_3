using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Salad_Recipe_Final_Poe_3
{
    public partial class Your_View : Page
    {
        public Your_View()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to the previous page
            NavigationService?.GoBack();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the user's view
           // string userView = UserViewTextBox.Text;

            // Validate the input
          //  if (string.IsNullOrWhiteSpace(userView))
            {
                MessageBox.Show("Please enter your view before submitting.", "Input Required", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Here, you would normally process or save the user's view
            // For this example, we'll just show a success message
            MessageBox.Show("Your view has been successfully submitted!", "Submission Successful", MessageBoxButton.OK, MessageBoxImage.Information);

            // Clear the input field
         //   UserViewTextBox.Clear();
        }
    }
}
