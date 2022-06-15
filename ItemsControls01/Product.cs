using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsControls01
{
    class Product
    {
        #region Fields
        private int id;
        private string name;
        private decimal price;

        public Product()
        {
        }
        #endregion

        #region Contructors
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool  Isexpired { get; set; }
        public int Amount { get; set; }
        #endregion


        public override string ToString()
        {
            return $"Product Id {id},Product Name: {name}, Product Price: {price}";
        }
    }
}
