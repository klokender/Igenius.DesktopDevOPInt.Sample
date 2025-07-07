using Igenius.DesktopDevOPInt.Sample.Core.Models;

namespace Igenius.DesktopDevOPInt.Sample.Core.Contracts.Services;

public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetContentGridDataAsync();
}
