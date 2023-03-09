using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Maps.Configuration.Dto;

namespace Maps.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MapsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
