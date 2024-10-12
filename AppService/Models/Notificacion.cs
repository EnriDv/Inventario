public class Notificacion
{
    public int IdNotificacion { get; set; }
    public Usuario Destinatario { get; set; } = null!;
    public string Mensaje { get; set; } = null!;
    public DateTime FechaEnvio { get; set; }

    public void EnviarNotificacion()
    {
        
    }
}