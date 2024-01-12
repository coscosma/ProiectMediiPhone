using ProiectMediiPhone.Data;

namespace ProiectMediiPhone;

public partial class App : Application
{

    static InchirieriDatabase database;
    public static InchirieriDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               InchirieriDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "InchirieriDatabase.db3"));
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
