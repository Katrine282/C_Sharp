namespace WebApplication1.Models;

public class HomeModel
{
    public string name { get; set; }
    public int age { get; set; }
    public string birthday { get; set; }

    public HomeModel(string name, int age, string birthday)
    {
        this.name = name;
        this.age = age;
        this.birthday = birthday;
    }
}