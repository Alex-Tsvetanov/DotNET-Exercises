using System.Windows;
using UI.Windows;

namespace UI;

/// <summary>
/// Interaction logic for StudentsWindow.xaml
/// </summary>
public partial class StudentsWindow : Window
{
    public StudentsWindow()
    {
        InitializeComponent();
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        LogsWindow window1 = new LogsWindow();
        window1.ShowDialog();
        this.Visibility = Visibility.Hidden;
    }
}