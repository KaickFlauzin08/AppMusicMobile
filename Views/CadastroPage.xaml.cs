namespace AppMusic.Views;

public partial class CadastroPage : ContentPage
{
	public CadastroPage()
	{
		InitializeComponent();
	}
	public async void LoginPage(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("LoginPage");
    }
}