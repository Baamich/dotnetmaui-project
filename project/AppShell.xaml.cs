using project.Models;
using project.Views;

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
            Routing.RegisterRoute(AppRoutes.maintPageRoute, typeof(MainPage));
        }
    }
}