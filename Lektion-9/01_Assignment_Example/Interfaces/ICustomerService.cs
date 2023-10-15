﻿namespace _01_Assignment_Example.Interfaces
{
    public interface ICustomerService
    {
        Task AddCustomerAsync(ICustomer customer);
        IEnumerable<ICustomer> GetAllCustomers();
        ICustomer GetOneCustomer(string email);
        void Removecustomer(string email);
    }
}