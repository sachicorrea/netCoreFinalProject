namespace Hospital.App.Dominio
{
    public class Persona 
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string Numerotelefono {get; set;}
        public Genero Genero {get; set;}
    }
}