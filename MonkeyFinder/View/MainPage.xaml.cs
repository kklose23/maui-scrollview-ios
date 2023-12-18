namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{
	public MainPage(MonkeysViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}


  public static readonly BindableProperty ShowProperty = BindableProperty.Create(nameof(Show), typeof(bool), typeof(MainPage), defaultValue: true);

  public bool Show
  {
    get => (bool)GetValue(ShowProperty);
    set => SetValue(ShowProperty, value);
  }

  private void Button_Clicked(object sender, EventArgs e)
  {
    Show = false;
  }
}



