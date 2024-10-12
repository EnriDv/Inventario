
public class Equipo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public Categoria Categoria { get; set; }

    public Equipo(int id, string nombre, Categoria categoria)
    {
        Id = id;
        Nombre = nombre;
        Categoria = categoria;
    }
}
