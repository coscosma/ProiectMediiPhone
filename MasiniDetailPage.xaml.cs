namespace ProiectMediiPhone;
using ProiectMediiPhone.Models;

public partial class MasiniDetailPage : ContentPage
{

    private Masina currentMasina;
	public MasiniDetailPage(Masina masina)
	{
		InitializeComponent();
        currentMasina = masina;
        BindingContext = currentMasina;
    }
    private async void OnEditButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MasiniEntryPage(currentMasina));
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        bool isUserConfirmed = await DisplayAlert("Sterge Masina", "Esti sigur ca vrei sa stergi aceasta masina?", "Da", "Nu");

        if (isUserConfirmed)
        {
            await App.Database.DeleteMasinaAsync(currentMasina);
            await Navigation.PopAsync();
        }
    }
}