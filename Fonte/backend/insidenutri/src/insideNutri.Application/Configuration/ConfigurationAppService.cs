using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using insideNutri.Configuration.Dto;

namespace insideNutri.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : insideNutriAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
