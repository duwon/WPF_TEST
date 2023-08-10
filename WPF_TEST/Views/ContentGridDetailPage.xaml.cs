using System.Windows.Controls;

using WPF_TEST.ViewModels;

namespace WPF_TEST.Views;

public partial class ContentGridDetailPage : Page
{
    public ContentGridDetailPage(ContentGridDetailViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
