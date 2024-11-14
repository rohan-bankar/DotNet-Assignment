using System.Collections.Generic;
public class Product
{
    public int id { get; set;}
    public string name { get; set;}
    public int price{ get; set;}

    public override string ToString()
    {
        return $"{id}  {name}  {price}";
    }
}

public class ProductCRUD
{
    List<Product>Products;

    public ProductCRUD()
    {
        Products = new List<Product>();
    }

    public void AddProduct(Product prod)
    {
        Products.Add(prod);
    }

    public void ModifyProduct(Product prod)
    {
        for(int i=0;i<Products.Count;i++)
        {
            if(Products[i].id == prod.id)
            {
                Products[i].name = prod.name;
                Products[i].price = prod.price;
                break;
            }
        }
    }

    public void DeleteProduct(int id)
    {
        for(int i=0;i<Products.Count;i++)
        {
            if(Products[i].id == id)
            {
                // Products.RemoveAt(i);
                Products.Remove(Products[i]);
                break;
            }
        }
    }

    public List<Product> ProductList()
    {
        return Products;
    }

    public Product GetProductById(int id)
    {
        Product p = new Product();
        foreach(var item in Products)
        {
            if(item.id == id)
            {
                p.id = item.id;
                p.name = item.name;
                p.price = item.price;
                break;
            }
        }
        return p;
    }
}