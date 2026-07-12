using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalValue();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("Packing Label:");
        foreach (Product product in _products)
        {
            packingLabel.AppendLine($"Product Name: {product.GetName()}, Product ID: {product.GetProductId()}");
        }
        return packingLabel.ToString();
    }
}
