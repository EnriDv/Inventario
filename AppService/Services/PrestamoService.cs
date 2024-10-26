public class PrestamoService : IPrestamoService
{

    public List<Equipo> mostrar_equipos()
    {
        return listaEquipos;
    }
    public List<Equipo> mostrar_equipos_prestados()
    {
        List<Equipo> equiposPrestados = new List<Equipo>();
        foreach (var equipo in listaEquipos)
        {
            if (equipo.Estado_Equipo == "Prestado")
            {
                equiposPrestados.Add(equipo);
            }
        }
        return equiposPrestados;
    }

    public bool cambiar_estado_equipo(int idEquipo)
    {
        foreach (var equipo in listaEquipos)
        {
            if (equipo.idEquipo == idEquipo && equipo.Estado_Equipo != "Disponible")
            {
                equipo.Estado_Equipo = "Disponible";
                return true; // El cambio fue realizado
            }
        }
        return false; // No se encontró el equipo o ya estaba disponible
    }
    List<Equipo> listaEquipos = new List<Equipo>
        {
            new Equipo { idEquipo = 1, codigoIMT = "IMT001", Nombre_equipo = "Microscopio", Estado_Equipo = "Disponible", Detalle_equipo = "Microscopio con aumento 100x" },
            new Equipo { idEquipo = 2, codigoIMT = "IMT002", Nombre_equipo = "Osciloscopio", Estado_Equipo = "Prestado", Detalle_equipo = "Osciloscopio digital de 2 canales" },
            new Equipo { idEquipo = 3, codigoIMT = "IMT003", Nombre_equipo = "Multímetro", Estado_Equipo = "Disponible", Detalle_equipo = "Multímetro digital con medición de voltaje y resistencia" },
            new Equipo { idEquipo = 4, codigoIMT = "IMT004", Nombre_equipo = "Generador de señales", Estado_Equipo = "Disponible", Detalle_equipo = "Generador de señales de frecuencia ajustable" },
            new Equipo { idEquipo = 5, codigoIMT = "IMT005", Nombre_equipo = "Estación de soldadura", Estado_Equipo = "Prestado", Detalle_equipo = "Estación de soldadura con control de temperatura" },
            new Equipo { idEquipo = 6, codigoIMT = "IMT006", Nombre_equipo = "Fuente de alimentación", Estado_Equipo = "Disponible", Detalle_equipo = "Fuente de alimentación regulable de 0-30V" },
            new Equipo { idEquipo = 7, codigoIMT = "IMT007", Nombre_equipo = "Taladro de banco", Estado_Equipo = "Disponible", Detalle_equipo = "Taladro de banco con velocidad ajustable" },
            new Equipo { idEquipo = 8, codigoIMT = "IMT008", Nombre_equipo = "Compresor de aire", Estado_Equipo = "Prestado", Detalle_equipo = "Compresor de aire para herramientas neumáticas" },
            new Equipo { idEquipo = 9, codigoIMT = "IMT009", Nombre_equipo = "Impresora 3D", Estado_Equipo = "Disponible", Detalle_equipo = "Impresora 3D con filamento PLA" },
            new Equipo { idEquipo = 10, codigoIMT = "IMT010", Nombre_equipo = "Proyector", Estado_Equipo = "Disponible", Detalle_equipo = "Proyector Full HD" },
            new Equipo { idEquipo = 11, codigoIMT = "IMT011", Nombre_equipo = "Cámara termográfica", Estado_Equipo = "Prestado", Detalle_equipo = "Cámara para medir temperaturas en rangos altos" },
            new Equipo { idEquipo = 12, codigoIMT = "IMT012", Nombre_equipo = "Cortadora láser", Estado_Equipo = "Disponible", Detalle_equipo = "Cortadora láser para materiales de hasta 10mm de grosor" },
            new Equipo { idEquipo = 13, codigoIMT = "IMT013", Nombre_equipo = "Calibrador digital", Estado_Equipo = "Prestado", Detalle_equipo = "Calibrador digital con precisión de 0.01mm" },
            new Equipo { idEquipo = 14, codigoIMT = "IMT014", Nombre_equipo = "Router CNC", Estado_Equipo = "Disponible", Detalle_equipo = "Router CNC para corte de precisión" },
            new Equipo { idEquipo = 15, codigoIMT = "IMT015", Nombre_equipo = "Cámara de alta velocidad", Estado_Equipo = "Prestado", Detalle_equipo = "Cámara para capturar imágenes de alta velocidad" }
        };
}