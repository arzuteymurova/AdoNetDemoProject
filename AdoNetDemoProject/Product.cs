
using System.ComponentModel.DataAnnotations;

namespace AdoNetDemoProject
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
