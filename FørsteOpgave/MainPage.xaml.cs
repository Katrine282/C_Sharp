
namespace FørsteOpgave;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    
    private void OnCheckboxClicked(object? sender, EventArgs e)
    {
        if (CheckBox.IsChecked)
        {
            CounterBtn.IsVisible = true;
        }
        else
        {
            CounterBtn.IsVisible = false;
        }
        
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}