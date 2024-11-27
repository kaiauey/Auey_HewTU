
using Google.Cloud.Firestore;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

public class FirestoreService
{
    private readonly FirestoreDb _firestoreDb;

    public FirestoreService()
    {
        // กำหนด Firebase Firestore (แทนด้วย Firebase Project ID ของคุณ)
        string projectId = "app2024-243ce";
        _firestoreDb = FirestoreDb.Create(projectId);
    }

    // ดึงข้อมูลร้านค้าจาก Collection "Stores"
    public async Task<ObservableCollection<Store>> GetStoresAsync()
    {
        var stores = new ObservableCollection<Store>();
        var querySnapshot = await _firestoreDb.Collection("Stores").GetSnapshotAsync();

        foreach (var document in querySnapshot.Documents)
        {
            if (document.Exists)
            {
                var store = document.ConvertTo<Store>();
                stores.Add(store);
            }
        }
        return stores;
    }

    // ดึงเมนูจาก Collection "menu" ของร้านค้า
    public async Task<ObservableCollection<Menu>> GetMenuAsync(string storeId)
    {
        var menuItems = new ObservableCollection<Menu>();
        var querySnapshot = await _firestoreDb.Collection("Stores").Document(storeId).Collection("menu").GetSnapshotAsync();

        foreach (var document in querySnapshot.Documents)
        {
            if (document.Exists)
            {
                var menu = document.ConvertTo<Menu>();
                menuItems.Add(menu);
            }
        }
        return menuItems;
    }
}

//app2024-243ce-firebase-adminsdk-f5r6q-ebfc85a96a
//$env:GOOGLE_APPLICATION_CREDENTIALS="C:app2024-243ce-firebase-adminsdk-f5r6q-ebfc85a96a.json"
