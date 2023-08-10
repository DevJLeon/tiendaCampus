using aaaa.Classes;
using aaaa.Views;

internal class Program
{
    private static void Main(string[] args)
    {
        MainMenu menu = new MainMenu();
        int opcion;
        do{
            opcion = menu.Menu();
            switch(opcion){
                case 1:
                    Console.ReadKey();
                    break;
                case 2:
                    Console.ReadKey();
                    break;
                case 3:
                    Console.ReadKey();
                    break;
                case 4:
                    Console.ReadKey();
                    break;
                case 5:
                    Console.ReadKey();
                    break;
                case 6:
                    break;
                
            }
        }while(opcion !=4);
    }
}