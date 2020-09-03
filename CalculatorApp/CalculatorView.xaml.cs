using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CalculatorApp
{
    public partial class CalculatorView : UserControl
    {
        public CalculatorView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "HistorialOperaciones", true);
            IsVisibilityRectangle.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Normal", true);
        }

        private void IsVisibilityRectangle_Click(object sender, RoutedEventArgs e)
        {
            IsVisibilityRectangle.Visibility = Visibility.Collapsed;
            VisualStateManager.GoToState(this, "Normal", true);
        }
    }
}
