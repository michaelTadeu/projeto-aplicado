using System.Threading.Tasks;
using insideNutri.Configuration.Dto;

namespace insideNutri.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
