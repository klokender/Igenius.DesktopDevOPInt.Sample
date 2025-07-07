using Igenius.DesktopDevOPInt.Sample.Models;

namespace Igenius.DesktopDevOPInt.Sample.Contracts.Services;

public interface IThemeSelectorService
{
    void InitializeTheme();

    void SetTheme(AppTheme theme);

    AppTheme GetCurrentTheme();
}
