using Microsoft.Maui.Controls;
namespace quizdavi;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void About(object sender, EventArgs  args)
	{
		Application.Current.MainPage = new SobrePage();
	}
}

