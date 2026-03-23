namespace AndenOpgave;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void bytOppe(object? sender, EventArgs e)
    {
        string temp = l1Oppe.Text;
        l1Oppe.Text = l2Oppe.Text;
        l2Oppe.Text = temp;
    }
    
    private void bytNede(object? sender, EventArgs e)
    {
        (l1Nede.Text, l2Nede.Text) = (l2Nede.Text, l1Nede.Text);
    }
}