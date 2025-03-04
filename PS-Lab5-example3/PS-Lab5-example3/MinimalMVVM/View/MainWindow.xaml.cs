using MinimalMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MinimalMVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new UpperCasePresenter();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is UpperCasePresenter)
            {
                this.DataContext = new LowerCasePresenter(this.DataContext as UpperCasePresenter);
            }
            else
            {
                this.DataContext = new UpperCasePresenter(this.DataContext as LowerCasePresenter);
            }
        }
    }
}
