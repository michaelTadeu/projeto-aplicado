using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace insideNutri.Localization
{
    public static class insideNutriLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(insideNutriConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(insideNutriLocalizationConfigurer).GetAssembly(),
                        "insideNutri.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
