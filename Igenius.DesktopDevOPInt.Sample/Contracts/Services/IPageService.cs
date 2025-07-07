using System.Windows.Controls;

namespace Igenius.DesktopDevOPInt.Sample.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
