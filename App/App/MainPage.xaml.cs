namespace App;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnPushClicked(object sender, EventArgs e)
    {
        VisualStateManager.GoToState(_border1, $"State{count}");
        VisualStateManager.GoToState(_border2, $"State{count}");
        ++count;
        if (count > 5)
            count = 1;
    }
}

