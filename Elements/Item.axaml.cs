using Avalonia.Controls;
using Shop_Bushuev.Classes;

namespace Shop_Bushuev.Elements;

public partial class Item : UserControl
{
    public Item(object ItemData)
    {
        InitializeComponent();
        
        Shop ShopData = ItemData as Shop;
        
        if (ShopData != null)
        {
            tb_Name.Text = ShopData.Name;
            tb_Price.Text = "Цена: " + ShopData.Price;
            
            if (ItemData is Children ChildrenData)
            {
                tb_Characteristic.Text = "Возраст: " + ChildrenData.Age;
            }
            if (ItemData is Sport SportData)
            {
                tb_Characteristic.Text = "Размер: " + SportData.Size;
            }
        }
    }
}