using System.Windows.Controls;

using WPF_TEST.ViewModels;

namespace WPF_TEST.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
