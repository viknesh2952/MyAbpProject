using MyAbpProject.Debugging;

namespace MyAbpProject
{
    public class MyAbpProjectConsts
    {
        public const string LocalizationSourceName = "MyAbpProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a6ba3d91d41247c69110a181ee24d571";
    }
}
