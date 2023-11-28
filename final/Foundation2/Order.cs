public class Order {
    private List<Product> _products;
    private Customer _customer;
    private double _total;
    private double _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public double ComputeShippingCost()
    {
        if (_customer.CheckUSA())
        {
            _shippingCost = 5.00;
        }
        else
        {
            _shippingCost = 35.00;
        }
        return _shippingCost;
    }

    public double ComputeTotalPrice()
    {
        _total = _products.Sum(product => product.ComputeProductPrice()) + _shippingCost;
        return _total;
    }

    public void DisplayTotal()
    {
        Console.WriteLine($"${Math.Round(_total, 2)}");
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void GeneratePackingLabel()
    {
        foreach (var product in _products)
        {
            Console.WriteLine($"{product.GetProductName()} ({product.GetProductID()}) - Quantity: {product.GetQuantity()} - Price: ${product.ComputeProductPrice()}");
        }
    }

    public void GenerateShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetCustomerAddress());
    }
}