using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6;

public partial class opg8 : ContentPage
{
    private static List<CheckBox> boxes = new List<CheckBox>();
    
    public opg8()
    {
        InitializeComponent();
        boxes.Add(Lemon);
        boxes.Add(Orange);
        boxes.Add(Banana);
    }

    private void OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        string result = "";
        foreach (var box in boxes)
        {
            if (box.IsChecked == true)
            {
                result += box.ClassId + ", ";
            }
        }
        
        check.Text = "Status checkboxes: \n" + result;
    }

    private void RadioButton_OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
       RadioButton rb = sender as RadioButton;
       radio.Text =  "Status checkboxes: \n" + rb.Content;
    }
}