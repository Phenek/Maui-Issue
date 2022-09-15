namespace App;

public partial class MainPage2 : ContentPage
{
	int count = 0;

	public MainPage2()
	{
		InitializeComponent();
	}

	private void OnPopClicked(object sender, EventArgs e)
	{
        Application.Current.MainPage.Navigation.PopModalAsync();
    }

    private void OnRemoveClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.RemovePage(this);
    }
}

