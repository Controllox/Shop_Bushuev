using System.Collections.Generic;
using Avalonia.Controls;
using Shop_Bushuev.Classes;

namespace Shop_Bushuev;

public partial class MainWindow : Window
{
    List<object> AllItems = RepoItems.AllItems();
    public MainWindow()
    {
        InitializeComponent();
        CreateUI();
    }
    public void CreateUI()
    {
        foreach(object Item in AllItems)
        {
            parent.Children.Add(new Elements.Item(Item));
        }
    }
}