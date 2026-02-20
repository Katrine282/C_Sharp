namespace Musicstore.Models;

public class Product
{
    private string title; // field

    public string Title // property
    {
        get { return title; }
    }

    private double price; // field

    public double Price // property
    {
        // 
        set
        {
            if (value <= 0)
            {
                throw new Exception("Price is not accepted");
            }
            else
            {
                price = value;
            }
        }
        get { return price; }
    }


    private string imageUrl; // field

    public string ImageUrl // property
    {
        get { return imageUrl; }
        set { imageUrl = value; }
    }


    // constructor 1
    public Product(string title, double price)
    {
        this.title = title;
        this.price = price;
    }

}