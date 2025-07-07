using System.Windows.Controls;

namespace Igenius.DesktopDevOPInt.Sample.Contracts.Views;

public interface IShellWindow
{
    Frame GetNavigationFrame();

    void ShowWindow();

    void CloseWindow();
}
