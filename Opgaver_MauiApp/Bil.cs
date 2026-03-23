using System.ComponentModel;
using Microsoft.UI.Xaml;
using PropertyChangingEventArgs = Microsoft.Maui.Controls.PropertyChangingEventArgs;

namespace Opgaver_MauiApp;

public class Bil : INotifyPropertyChanged
{
    private string model;
    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            if (model != value)
            {
                model = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Model"));
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(DisplayText)));
            }
        }
    }
    private int heste;
    public int Heste {
        get
        {
            return heste;
        }
        set
        {
            if (heste != value)
            {
                heste = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Heste"));
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(DisplayText)));
            }
        }
        
    }

    private bool elbil;
    public bool Elbil
    {
        get
        {
            return elbil;
        }
        set
        {
            if (elbil != value)
            {
                elbil = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Elbil"));
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(DisplayText)));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged = delegate { };
    
    public Bil(string model, int heste, bool elbil)
    {
        Model = model;
        Heste = heste;
        Elbil = elbil;
    }
    
    public string DisplayText
    {
        get
        {
            if (Elbil)
                return $"{Model} (El bil) - {Heste} hk";
            else
                return $"{Model} - {Heste} hk";
        }
    }

    // public override string ToString()
    // {
    //     if (Elbil)
    //     {
    //         return Model + " (El bil) - " + Heste + " hk";;
    //     }
    //     else
    //     {
    //         return Model + " - " + Heste + " hk";
    //     }
    //     
    // }
}