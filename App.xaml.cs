using ProiectMediiPhone.Data;

namespace ProiectMediiPhone;

public partial class App : Application
{

    static MasiniDatabase database;
    public static MasiniDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               MasiniDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "MasiniDatabase.db3"));
            }
            return database;
        }
    }



    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
