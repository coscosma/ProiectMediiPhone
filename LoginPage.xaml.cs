using ProiectMediiPhone.Autentificare;
using ProiectMediiPhone.Models;
using ProiectMediiPhone.Resources;
namespace ProiectMediiPhone;

public partial class LoginPage : ContentPage
{
    private Login login = new Login();
    public LoginPage()
    {
        InitializeComponent();
        Shell.SetTabBarIsVisible(Application.Current, false);
    }

    // logica de log in
    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string email = emailEntry.Text;
        string parola = parolaEntry.Text;

        int? userId = await App.Database.GetUserIdByEmailAndPasswordAsync(email, parola);

        Agent authenticatedAgent = await login.AuthenticateAgentAsync(email, parola);
        Client authenticatedClient = await login.AuthenticateClientAsync(email, parola);

        if (authenticatedAgent != null)
        {
            int loggedInUserId = userId.Value;
            ItsAgent.isAgent = true;
            await Navigation.PushAsync(new AgentMainPg(loggedInUserId));
        }
        else if (authenticatedClient != null)
        {
            int loggedInUserId = userId.Value;
            ItsAgent.isAgent = false;
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            await DisplayAlert("Login nereusit", "Emailul sau parola este gresita", "OK");
        }
    }


    private async void OnSignButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}