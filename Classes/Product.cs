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
}