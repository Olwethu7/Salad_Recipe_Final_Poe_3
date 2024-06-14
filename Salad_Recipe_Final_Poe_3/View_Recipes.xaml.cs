using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Salad_Recipe_Final_Poe_3
{
    public partial class View_Recipes : Page
    {
        public View_Recipes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string pageUrl = button.Tag as string;
                if (!string.IsNullOrEmpty(pageUrl))
                {
                    NavigationService?.Navigate(new Uri(pageUrl, UriKind.Relative));
                }
            }
        }
    }
}
