using insideNutri.Debugging;

namespace insideNutri
{
    public class insideNutriConsts
    {
        public const string LocalizationSourceName = "insideNutri";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4401ac1f6e124801931bcfffd0c6d63e";
    }
}
