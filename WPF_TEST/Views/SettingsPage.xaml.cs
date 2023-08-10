using System.Windows.Controls;

using WPF_TEST.ViewModels;

namespace WPF_TEST.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
