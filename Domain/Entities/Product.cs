using Domain.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int Category { get; set; }

        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptions.Valid(id < 0, "Invalid ID value");
            Id = id;
            Validade(name, description, price, stock, image);
        }
        public Product(string name, string description, decimal price, int stock, string image)
        {
            Validade(name, description, price, stock, image);
        }
        public void Update(string name, string description, decimal price, int stock, string image, int categoryid)
        {
            Validade(name, description, price, stock, image);
            Category= categoryid;
        }
        private void Validade(string name, string description, decimal price,int stock, string image)
        {
            DomainExceptions.Valid(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptions.Valid(name.Length < 3, "Name invalid, required minimum 3 characters");
            DomainExceptions.Valid(description.Length < 5, "Description invalid, required minimum 5 characters");
            DomainExceptions.Valid(price < 0, "Price invalid, value minimum zero");
            DomainExceptions.Valid(stock < 0, "Stock invalid, value minimum zero");
            DomainExceptions.Valid(image?.Length > 250, "Image invalid,  maximum 250 characteres");
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

    }
}
