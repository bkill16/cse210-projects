public class Product {
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _quantity;
    private double _price;

    public Product(string productName, string productID, double productPrice, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public double ComputeProductPrice()
    {
        _price = _productPrice * _quantity;
        return Math.Round(_price, 2);
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}