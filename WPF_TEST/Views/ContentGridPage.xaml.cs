using System.Windows.Controls;

using WPF_TEST.ViewModels;

namespace WPF_TEST.Views;

public partial class ContentGridPage : Page
{
    public ContentGridPage(ContentGridViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
