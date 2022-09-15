namespace ScrollConflicts;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		_carouselView.ItemsSource = new List<ContentView>
			{
				new Tab1(),
				new Tab2(),
				new Tab3()
			};
	}
}


