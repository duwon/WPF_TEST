using System.Windows.Controls;

using WPF_TEST.ViewModels;

namespace WPF_TEST.Views;

public partial class ListDetailsPage : Page
{
    public ListDetailsPage(ListDetailsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
