using System.Collections.ObjectModel;

namespace Opgaver_MauiApp;

public partial class MainPage : ContentPage
{
    private ObservableCollection<Bil> biler = new ObservableCollection<Bil>();
    private Bil tempBil;
    
    public MainPage()
    {
        InitializeComponent();
        BilerListe.ItemsSource = biler;
        biler.Add(new Bil("Fiat 500", 30, true));
        biler.Add(new Bil("Kia Pikanto", 6, false));
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        Bil selected = BilerListe.SelectedItem as Bil;
        await DisplayAlert("Vis Bil", selected.DisplayText, "OK");
    }

    private void TilføjRandom_OnClicked(object? sender, EventArgs e)
    {
        biler.Add(new Bil("Berlingo", 20, false));
    }

    private void BilerListe_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        Bil selected = BilerListe.SelectedItem as Bil;

        tempBil = new Bil(selected.Model, selected.Heste, selected.Elbil);
        BindingContext = tempBil;
    }

    private async void GemÆndringerButton_OnClicked(object? sender, EventArgs e)
    {
        Bil selected = BilerListe.SelectedItem as Bil;

        selected.Model = tempBil.Model;
        selected.Heste = tempBil.Heste;
        selected.Elbil = tempBil.Elbil;

        await DisplayAlert("Vis Ændrede Bil", selected.DisplayText, "OK");
    }
}