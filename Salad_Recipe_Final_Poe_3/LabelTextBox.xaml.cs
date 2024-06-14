using System.Windows;
using System.Windows.Controls;

namespace Salad_Recipe_Final_Poe_3
{
    public partial class LabelTextBox : UserControl
    {
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(LabelTextBox), new PropertyMetadata(""));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(LabelTextBox), new PropertyMetadata(""));

        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public LabelTextBox()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
