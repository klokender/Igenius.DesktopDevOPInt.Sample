using System.Windows.Controls;

using Igenius.DesktopDevOPInt.Sample.ViewModels;

namespace Igenius.DesktopDevOPInt.Sample.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
