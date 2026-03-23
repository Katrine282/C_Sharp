namespace Opgave6;

public partial class MainPage : ContentPage
{
   

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object? sender, EventArgs e)
    {
        Button b = (Button)sender;

        MinEditor.Text += b.Text + "\n";
    }
}