using project.Models;

namespace project
{    
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(AppRoutes.logginPageRoute, typeof(LogginPage));
            Routing.RegisterRoute(AppRoutes.singUpPageRoute, typeof(SignUpPage));
            Routing.RegisterRoute(AppRoutes.loadingPageRoute, typeof(LoadingPage));
            Routing.RegisterRoute(AppRoutes.mainPageRoute, typeof(MainPage));
            Routing.RegisterRoute(AppRoutes.settingsPageRoute, typeof(SettingsPage));
            Routing.RegisterRoute(AppRoutes.appLogsPageRoute, typeof(LogsCheckerPage));
        }
    }
}