using System.Collections.ObjectModel;
using System.Threading.Tasks;

public class StorePageViewModel
{
    private readonly FirestoreService _firestoreService;

    public ObservableCollection<Store> Stores { get; set; } = new ObservableCollection<Store>();

    public StorePageViewModel()
    {
        _firestoreService = new FirestoreService();
        LoadStoresAsync();
    }

    private async Task LoadStoresAsync()
    {
        var stores = await _firestoreService.GetStoresAsync();
        Stores.Clear();
        foreach (var store in stores)
        {
            Stores.Add(store);
        }
    }
}
