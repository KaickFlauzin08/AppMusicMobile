using AppMusic.Views;

namespace AppMusic
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("HomePage", typeof(HomePage));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("CadastroPage", typeof(CadastroPage));
        }
    }
}
