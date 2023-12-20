using LoginApp.Model;

namespace LoginApp.Pages;

public partial class LoginUsuarioPage : ContentPage
{

    Usuario _usuario;

	public LoginUsuarioPage()
	{
		InitializeComponent();
	}

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EditaUsuario());
    }

    private void btnEntrar_Clicked(object sender, EventArgs e)
    {

    }

    
}