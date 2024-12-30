namespace LearnBlazor.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool IsActive  { get; set; }

        public IEnumerable<Product_Prop> ProductProperties { get; set; }

    }
}
