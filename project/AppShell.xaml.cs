using project.Views;

namespace project
{    
    public partial class AppShell : Shell
    {
        const string logginPageRoute = "loggin";
        const string singUpPageRoute = "singup";
        const string loadingPageRoute = "loading";

        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(logginPageRoute, typeof(LogginPage));
            Routing.RegisterRoute(singUpPageRoute, typeof(SignUpPage));
            Routing.RegisterRoute(loadingPageRoute, typeof(LoadingPage));
        }
    }
}