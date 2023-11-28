public class Customer {
    private string _name;
    private Address _customerAddress;

    public Customer(string name, Address customerAddress)
    {
        _name = name;
        _customerAddress = customerAddress;
    }

    public bool CheckUSA()
    {
        return _customerAddress.IsUSA();
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerAddress()
    {
        return _customerAddress.FormatAddress();
    }
}