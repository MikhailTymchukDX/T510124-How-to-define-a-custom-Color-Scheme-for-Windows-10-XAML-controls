using ColosSchemesDemo1.Themes;
using DevExpress.Core;
using DevExpress.Themes.Internal;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ColosSchemesDemo1
{
    sealed partial class App : Application {
        public App() {
            this.InitializeComponent();
            ThemeManager.RegisterColorScheme(new CustomColorScheme("Custom"));
            this.Suspending += OnSuspending;
        }

        private ColorSchemeBase CustomColorScheme(ColorSchemeBase arg)
        {
            throw new NotImplementedException();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e) {
            Frame rootFrame = Window.Current.Content as Frame;
            if(rootFrame == null) {
                rootFrame = new Frame();
                rootFrame.NavigationFailed += OnNavigationFailed;
                Window.Current.Content = rootFrame;
            }

            if(e.PrelaunchActivated == false) {
                if(rootFrame.Content == null)
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);

                Window.Current.Activate();
            }
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e) {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }
        void OnSuspending(object sender, SuspendingEventArgs e) {
            e.SuspendingOperation.GetDeferral().Complete();
        }
    }
}
