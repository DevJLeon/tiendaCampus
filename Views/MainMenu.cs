using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aaaa.Views;
public class MainMenu
{
    
    public int Menu(){
        Console.Clear();
        Console.WriteLine("Menu de Opciones");
        Console.WriteLine("1. Registro Producto");
        Console.WriteLine("2. Registro Categoria");
        Console.WriteLine("3. Listar Producto");
        Console.WriteLine("4. Listar Categoria");
        Console.WriteLine("5. Costo Inventario");
        Console.WriteLine("6. Salir");
        
        return int.Parse(Console.ReadLine());
    }
}