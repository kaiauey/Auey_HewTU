using Google.Cloud.Firestore;

[FirestoreData]
public class Store
{
    [FirestoreProperty]
    public string Id { get; set; }

    [FirestoreProperty]
    public string Name { get; set; }
}
