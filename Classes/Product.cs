namespace aaaa.Classes;
public class Product
{
    public int CodProducto {get;set;}
    public string Nombre {get;set;}
    public int Stock {get;set;}
    public int StockMin {get;set;}
    public int StockMax {get;set;}
    public double PrecioVenta {get;set;}
    public double PrecioCompra {get;set;}
    public int IdCategoria {get;set;}
    
    public Product (int codProducto,string nombre, int stock, int stockMin, int stockMax, double precioVenta, double precioCompra, int idCategoria){
        this.CodProducto = codProducto;
        this.Nombre = nombre;
        this.Stock = stock;
        this.StockMin = stockMin;
        this.StockMax = stockMax;
        this.PrecioVenta = precioVenta;
        this.PrecioCompra = precioCompra;
        this.IdCategoria = idCategoria;
    }

    public static void AddProduct(){
        Console.Write("Codigo de producto: ");
        int codProducto = int.Parse(Console.ReadLine());
        Console.Write("Ingrese nombre de producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese cantidad en stock: ");
        int stock = int.Parse(Console.ReadLine());
        Console.Write("Ingrese stock mínimo: ");
        int stockMin = int.Parse(Console.ReadLine());
        Console.Write("Ingrese stock máximo: ");
        int stockMax = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio de venta: ");
        double precioVenta = double.Parse(Console.ReadLine());
        Console.Write("Precio de compra: ");
        double precioCompra = double.Parse(Console.ReadLine());
        Console.Write("******************************************************");
        Console.WriteLine("                Categorias de Producto            ");
        
        Console.Write("Id de categoria:");
        int idCategoria = int.Parse(Console.ReadLine());
    }
}