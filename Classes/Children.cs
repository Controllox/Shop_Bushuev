namespace Shop_Bushuev.Classes;
public class Children : Shop
{
    public int Age;
    public Children(string Name, int Price, int Age) : base(Name, Price)
    {
        this.Age = Age;
    }
}