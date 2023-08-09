using System.Windows.Controls;

using MahApps.Metro.Controls;

using WPF_TEST.Contracts.Views;
using WPF_TEST.ViewModels;

namespace WPF_TEST.Views;

public partial class ShellWindow : MetroWindow, IShellWindow
{
    public ShellWindow(ShellViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    public Frame GetNavigationFrame()
        => shellFrame;

    public void ShowWindow()
        => Show();

    public void CloseWindow()
        => Close();
}
