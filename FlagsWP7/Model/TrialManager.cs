namespace Flags
{
    public class TrialManager
    {
        public static bool IsTrial { get; private set; }

        public static void DetermineIsTrail()
        {
                #if TRIAL
                IsTrial = true;
            #else
                var license = new Microsoft.Phone.Marketplace.LicenseInformation();
                IsTrial = license.IsTrial();
            #endif
        }
    }
}
