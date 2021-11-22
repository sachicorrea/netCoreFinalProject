namespace Hospital.App.Dominio
{  
    ///<summary>Class <c>Enfermera</c>
    ///Modela una persona del personal de enfermería del equipo médico de apoyo
    ///</summary>
    public class Enfermera : Persona {
        public string TarjetaProfesional {get; set;}
        public int HorasLaborales {get; set;}
    }
}