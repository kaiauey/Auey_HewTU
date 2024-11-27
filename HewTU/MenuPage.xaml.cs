using System;
using System.Collections.ObjectModel;
using HewTU.DescriptionMenu;
using Microsoft.Maui.Controls;

namespace HewTU;

public partial class MenuPage : ContentPage
{
    public MenuPage(string storeId)
    {
        InitializeComponent();
        BindingContext = new MenuPageViewModel(storeId);
    }
}
