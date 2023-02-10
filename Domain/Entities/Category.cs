using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Category
    {
        public int Id { get; set; }
        public string Name { get; private set; }

        public ICollection<Product> Products { get; set; }
        public Category(int id, string name)
        {
            DomainExceptions.Valid(id < 0, "Invalid ID value");
            Id = id;
            Validade(name);
        }

        private void Validade(string name)
        {
            DomainExceptions.Valid(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptions.Valid(name.Length > 3, "Name invalid, required minimum 3 characters");
            Name = name;
        }
    }
}

