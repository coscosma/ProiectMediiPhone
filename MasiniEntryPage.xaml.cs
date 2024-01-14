namespace ProiectMediiPhone;
using ProiectMediiPhone.Models;
public partial class MasiniEntryPage : ContentPage
{
	private Masina currentMasina;
	public MasiniEntryPage()
	{
		InitializeComponent();
        currentMasina = new Masina();
    }
    public MasiniEntryPage(Masina masina)
    {
        InitializeComponent();
        currentMasina = masina;
        LoadMasiniDetails();
    }

    private void LoadMasiniDetails()
    {
        marcaEntry.Text = currentMasina.Marca;
        modelEntry.Text = currentMasina.Model;
        tipcombustibilEntry.Text = currentMasina.TipCombustibil;
        categorieEntry.Text = currentMasina.Categorie;



    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        currentMasina.Marca = marcaEntry.Text;
        currentMasina.Model = modelEntry.Text;
        currentMasina.TipCombustibil = tipcombustibilEntry.Text;
        currentMasina.Categorie = categorieEntry.Text;


        await App.Database.SaveMasinaAsync(currentMasina);
        await Navigation.PopAsync();
    }

}