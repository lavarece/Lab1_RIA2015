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
using System.Windows.Navigation;

namespace Lab1
{
    public partial class Ver : Page
    {
        public Ver()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void ingresar_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Ingreso();
        }

        private void ver_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Ver();
        }

    }
}
