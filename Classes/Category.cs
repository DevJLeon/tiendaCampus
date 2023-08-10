namespace aaaa.Classes;
public class Category
{
    public int Id { get; set; }
    public string Descripcion { get; set; }

    public Category (int id, string descripcion){
        this.Id = id;
        this.Descripcion = descripcion;
    }
}