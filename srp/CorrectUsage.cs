// SRP - Single Responsibility Principle
// Her sınıfın yalnızca bir sorumluluğu olmalı.
// Doğru Kullanım

using System.Collections.Generic;

public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class CustomerRepository
{
    private List<Customer> customers = new List<Customer>();

    public void Add(Customer customer)
    {
        customers.Add(customer);
    }

    public List<Customer> GetAll()
    {
        return customers;
    }
}
