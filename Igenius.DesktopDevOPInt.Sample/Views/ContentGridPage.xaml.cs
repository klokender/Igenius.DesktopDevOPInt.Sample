using System.Windows.Controls;

using Igenius.DesktopDevOPInt.Sample.ViewModels;

namespace Igenius.DesktopDevOPInt.Sample.Views;

public partial class ContentGridPage : Page
{
    public ContentGridPage(ContentGridViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
