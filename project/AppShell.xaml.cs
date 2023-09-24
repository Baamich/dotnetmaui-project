using project.Views;

namespace project
{    
    public partial class AppShell : Shell
    {
        const string logginPageRoutStr = "loggin";

        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(logginPageRoutStr, typeof(LogginPage));
        }
    }
}