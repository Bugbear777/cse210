using System;

class Product
{
    private string name;
    private string productid;
    private double price;
    private int quantity;

    public Product(string name, string productid, double price, int quantity)
    {
        this.name = name;
        this.productid = productid;
        this.price = price;
        this.quantity = quantity;
    }
    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName() => name;
     public string GetProductId() => productid;
}