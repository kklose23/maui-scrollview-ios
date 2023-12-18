using MonkeyFinder.Services;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
  public MonkeysViewModel()
  {
    Items = new List<string>()
    {
      "item with long name 1",
      "item with long name 2",
      "item with long name 3",
      "item with long name 4",
    };
  }

  [ObservableProperty]
  private IEnumerable<string> _items;

  [RelayCommand]
  async Task GoToDetails(Monkey monkey)
  {
    if (monkey == null)
      return;

    await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
    {
        {"Monkey", monkey }
    });
  }
}
