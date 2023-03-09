using Maps.Debugging;

namespace Maps
{
    public class MapsConsts
    {
        public const string LocalizationSourceName = "Maps";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1f8e2224418b40268d9860fb52055efb";
    }
}
