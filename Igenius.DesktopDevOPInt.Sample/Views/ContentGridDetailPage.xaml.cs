using System.Windows.Controls;

using Igenius.DesktopDevOPInt.Sample.ViewModels;

namespace Igenius.DesktopDevOPInt.Sample.Views;

public partial class ContentGridDetailPage : Page
{
    public ContentGridDetailPage(ContentGridDetailViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
