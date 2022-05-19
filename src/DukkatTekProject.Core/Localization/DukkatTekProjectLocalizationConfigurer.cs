using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace DukkatTekProject.Localization
{
    public static class DukkatTekProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DukkatTekProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DukkatTekProjectLocalizationConfigurer).GetAssembly(),
                        "DukkatTekProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
