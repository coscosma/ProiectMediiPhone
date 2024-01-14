namespace ProiectMediiPhone;

public partial class AgentMainPg : ContentPage
{
    public AgentMainPg(int loggedInUserId)
    {
        InitializeComponent();
    }

    //  redirect to ProgramariListPage
    private async void OnViewInchirieriClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InchiriereListPg());
    }

    private async void OnViewClientiClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientListPg());
    }

    private async void OnViewAgentiClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AgentListPg());
    }
}