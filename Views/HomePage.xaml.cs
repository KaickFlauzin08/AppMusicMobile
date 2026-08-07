namespace AppMusic.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
	public async void PaginaCadastro(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("CadastroPage");
	}

}