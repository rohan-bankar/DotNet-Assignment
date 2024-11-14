public class Program
{
    public static void Main(string[] args)
    {
        ProductCRUD crud = new ProductCRUD();
        try
        {
            int a = 1;
            do
            {
                Console.WriteLine("1 product List");
                Console.WriteLine("2 Add Product");
                Console.WriteLine("3 Modify Product");
                Console.WriteLine("4 Delete Product");
                Console.WriteLine("5 Get Product by ID");
                Console.WriteLine("Select option from above");

                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        List<Product>products = crud.ProductList();
                        Console.WriteLine("ID  Name  Price");
                        foreach(var item in products)
                        {
                            Console.WriteLine(item);
                        }
                    break;

                    case 2:
                        Product p1 = new Product();
                        Console.WriteLine("Enter ID");
                        p1.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        p1.name = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        p1.price = Convert.ToInt32(Console.ReadLine());
                        crud.AddProduct(p1);
                        Console.WriteLine("Product added");
                    break;

                    case 3:
                        Product p2 = new Product();
                        Console.WriteLine("Enter Existing ID");
                        p2.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new Name");
                        p2.name = Console.ReadLine();
                        Console.WriteLine("Enter new Price");
                        p2.price = Convert.ToInt32(Console.ReadLine());
                        crud.ModifyProduct(p2);
                        Console.WriteLine("Product updated");
                    break;

                    case 4:
                        Console.WriteLine("Enter Existing ID to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProduct(id);
                        Console.WriteLine("Product Deleted");
                    break;

                    case 5:
                        Console.WriteLine("Enter Existing ID");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Product p = crud.GetProductById(id1);
                        Console.WriteLine(p);
                    break;
                }
                Console.WriteLine("Press 1 to continue or 0 to exit");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while(a == 1);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}