using System.Windows;
using STARHOUND.OS.ViewModels;

namespace STARHOUND.OS;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = new MainWindowViewModel();
    }
}