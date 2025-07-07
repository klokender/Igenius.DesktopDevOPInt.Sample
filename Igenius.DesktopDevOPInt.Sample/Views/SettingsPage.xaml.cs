using System.Windows.Controls;

using Igenius.DesktopDevOPInt.Sample.ViewModels;

namespace Igenius.DesktopDevOPInt.Sample.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
