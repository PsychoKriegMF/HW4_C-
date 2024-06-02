using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_C_
{
    public class Product : Money
    {
        public string Type {  get; set; }
        public string Name { get; set; }    
        public Product(string type, string name)
        {
            Type = type;
            Name = name;
        }
        public double Discount(double discount) 
        { 
            return Math.Round(Total() - discount,2);
        }        
    }
}
