using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6;

public partial class opg7 : ContentPage
{
    public opg7()
    {
        InitializeComponent();
    }

    private void MenuItem_OnClicked(object? sender, EventArgs e)
    {
        MenuFlyoutItem x = (MenuFlyoutItem)sender;

        Label.Text = x.Text;
    }
}