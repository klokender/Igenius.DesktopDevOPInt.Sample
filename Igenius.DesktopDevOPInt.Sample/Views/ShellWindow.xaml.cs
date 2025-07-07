using System.Windows.Controls;

using Igenius.DesktopDevOPInt.Sample.Contracts.Views;
using Igenius.DesktopDevOPInt.Sample.ViewModels;

using MahApps.Metro.Controls;

namespace Igenius.DesktopDevOPInt.Sample.Views;

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
