using System;
using Microsoft.Maui.Controls;
namespace HewTU;

public partial class StorePage : ContentPage
{
    public StorePage()
    {
        InitializeComponent();
        BindingContext = new StorePageViewModel();
    }

    private async void NavigateToMenu(object sender, EventArgs e)
    {
        if (sender is ImageButton imageButton && imageButton.BindingContext is Store selectedStore)
        {
            await Navigation.PushAsync(new MenuPage(selectedStore.Id));
        }
    }

    // Event handler for TextChanged
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        // Logic ที่คุณต้องการใส่เมื่อ Text ถูกเปลี่ยน
        Console.WriteLine($"Text changed to: {e.NewTextValue}");
    }
    private async void NavigateToNewMenu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewMenu());
    }
    private async void NavigateToSteakMenu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SteakMenu());
    }
    private async void NavigateToMalaMenu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MalaMenu());
    }
    private async void NavigateToCakeMenu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CakeMenu());
    }

}