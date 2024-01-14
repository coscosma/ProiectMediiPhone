namespace ProiectMediiPhone.Resources;
using ProiectMediiPhone.Autentificare;
using ProiectMediiPhone.Models;
using ProiectMediiPhone.Data;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
        Shell.SetTabBarIsVisible(Application.Current, false);
    }

    private async void OnSignUpButtonClicked(object sender, EventArgs e)
    {
        string email = emailEntry.Text;
        string parola = parolaEntry.Text;
        string nume = numeEntry.Text;
        string prenume = prenumeEntry.Text;


        Client newUser = new Client { Email = email, Parola = parola, Nume = nume, Prenume = prenume };
        await App.Database.SaveClientAsync((Client)newUser);

        //IUser newUser = new Barber { Email = email, Parola = parola, Nume = nume, Prenume = prenume };
        // await App.Database.SaveBarberAsync((Barber)newUser);

        await DisplayAlert("Sign reusit", "Cont creat+.", "OK");
        await Navigation.PushAsync(new MainPage());
    }
}

