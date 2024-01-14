using ProiectMediiPhone.Data;
using ProiectMediiPhone.Autentificare;
namespace ProiectMediiPhone;

using System;
using System.IO;


public partial class AppShell : Shell
{
    public static readonly BindableProperty IsAgentProperty = BindableProperty.Create(nameof(IsAgent), typeof(bool), typeof(AppShell), false);

    public bool IsAgent
    {
        get { return (bool)GetValue(IsAgentProperty); }
        set { SetValue(IsAgentProperty, value); }
    }

    public AppShell()
	{
        IsAgent = ItsAgent.isAgent;
        InitializeComponent();
	}
}
