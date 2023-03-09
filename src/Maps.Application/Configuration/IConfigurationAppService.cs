using System.Threading.Tasks;
using Maps.Configuration.Dto;

namespace Maps.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
