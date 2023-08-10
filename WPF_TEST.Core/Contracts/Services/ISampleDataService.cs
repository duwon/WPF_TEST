using WPF_TEST.Core.Models;

namespace WPF_TEST.Core.Contracts.Services;

public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
}
