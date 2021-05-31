using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetNgProducts.Models
{
    public sealed class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte[] Base64Picture { get; set; }
    }
}
