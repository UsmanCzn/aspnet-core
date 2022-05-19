using DukkatTekProject.Debugging;

namespace DukkatTekProject
{
    public class DukkatTekProjectConsts
    {
        public const string LocalizationSourceName = "DukkatTekProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6bc27b96038b46efbb62cdb5ce9c4c18";
    }
}
