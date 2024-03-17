namespace Products_Domain.ViewModel
{
    public class CreateProductViewModel
    {
        public string Name { get; set; }
        public decimal Stock { get; set; }
        public decimal Value { get; set; }
    }
    public class UpdateProductsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Stock { get; set; }
        public decimal Value { get; set; }
    }

}
