using Task1Ef.Data;

namespace Task1Ef
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ApplicationDbContext context = new ApplicationDbContext(); 
            var category = new Models.Category(){
                Name = "Electronics"

            };
            var product = new Models.Products()
            {
                Name = "Smartphone",
                Description = "smartphone with a camera",
                Price = 999,
                Rate = 5
            };
            context.Products.Add(product);
            context.Category.Add(category);
            context.SaveChanges();
            
        }
    }
}
