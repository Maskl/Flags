using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Navigation;
using Flags;
using Flags.MVVMUtils;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FlagsWP7
{
    public partial class App : Application
    {
        public PhoneApplicationFrame RootFrame
        {
            get;
            private set;
        }

        public App()
        {
            UnhandledException += Application_UnhandledException;
            InitializeComponent();
            InitializePhoneApplication();
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Current.Host.Settings.EnableFrameRateCounter = true;
                PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
            }

            (Current.Resources["PhoneAccentBrush"] as SolidColorBrush).Color = Color.FromArgb(0xff, 0xe1, 0x9f, 0x00);
            (Current.Resources["PhoneForegroundBrush"] as SolidColorBrush).Color = Colors.White;
            (Current.Resources["PhoneBackgroundBrush"] as SolidColorBrush).Color = Colors.Black;

        }

        private void ApplicationLaunching(object sender, LaunchingEventArgs e)
        {
            TrialManager.DetermineIsTrail();
        }

        private void ApplicationActivated(object sender, ActivatedEventArgs e)
        {
            TrialManager.DetermineIsTrail();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
        }

        private void ApplicationDeactivated(object sender, DeactivatedEventArgs e)
        {
        }

        private void ApplicationClosing(object sender, ClosingEventArgs e)
        {
            ViewModelLocator.Cleanup();
        }

        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        #region Phone application initialization

        // Avoid double-initialization
        private bool phoneApplicationInitialized = false;

        // Do not add any additional code to this method
        private void InitializePhoneApplication()
        {
            if (phoneApplicationInitialized)
                return;

            // Create the frame but don't set it as RootVisual yet; this allows the splash
            // screen to remain active until the application is ready to render.
            RootFrame = new TransitionFrame();
            RootFrame.Navigated += CompleteInitializePhoneApplication;

            // Handle navigation failures
            RootFrame.NavigationFailed += RootFrame_NavigationFailed;

            // Ensure we don't initialize again
            phoneApplicationInitialized = true;
        }

        // Do not add any additional code to this method
        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            // Set the root visual to allow the application to render
            if (RootVisual != RootFrame)
                RootVisual = RootFrame;

            // Remove this handler since it is no longer needed
            RootFrame.Navigated -= CompleteInitializePhoneApplication;
        }

        #endregion
    }
}
