namespace ProiectMediiPhone;
using ProiectMediiPhone.Data;
using ProiectMediiPhone.Models;

public partial class MasiniListPage : ContentPage
{
	public MasiniListPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadMasini();
    }

    private async void LoadMasini()
    {
        List<Masina> masini = await App.Database.GetMasiniAsync();
        masinaListView.ItemsSource = masini;
    }

    private async void OnAddMasinaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MasiniEntryPage());
    }

    private async void OnMasinaSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Masina selectedMasina)
        {
            await Navigation.PushAsync(new MasiniDetailPage(selectedMasina));
            masinaListView.SelectedItem = null;
        }
    }
}



