using Google.Cloud.Firestore;

[FirestoreData]
public class Menu
{
    [FirestoreProperty]
    public string MenuName { get; set; }

    [FirestoreProperty]
    public string Price { get; set; }
}
