using System;

namespace MapaDeclases
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public MiembroDeLaComunidad(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;

        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");

        }

        
    }

    public class Empleado: MiembroDeLaComunidad
    {
        public string Cargo { get; set; }
        public Empleado(string nombre, int edad, string cargo) 
            : base(nombre, edad)
        {
            Cargo = cargo;
        }


        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Cargo: {Cargo}");
        }
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, int edad, string carrera)
            : base(nombre, edad)
        {
            Carrera = carrera;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public string AñoDeGraduacion { get; set; }

        public ExAlumno(string nombre, int edad, string añoDeGraduacion)
            : base(nombre, edad)
        {
            AñoDeGraduacion = añoDeGraduacion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduacion: {AñoDeGraduacion}");
        }

    }

    public class Docente : Empleado
    {
        public string Materia { get; set; }

        public Docente(string nombre, int edad, string cargo, string materia)
            : base(nombre, edad, cargo)
        {
            Materia = materia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Materia: {Materia}");
        }
    }

    public class Administrativo : Empleado
    {
        public string Departamento { get; set; }

        public Administrativo(string nombre, int edad, string cargo, string departamento)
            : base(nombre, edad, cargo)
        {
            Departamento = departamento;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }

    public class Administrador : Docente
    {
        public string AreaDeAdministracion { get; set; }

        public Administrador(string nombre, int edad, string cargo, string materia, string areaDeAdministracion)
            : base(nombre, edad, cargo, materia)
        {
            AreaDeAdministracion = areaDeAdministracion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área de Administración: {AreaDeAdministracion}");
        }
    }

    // Clase Maestro, hereda de Docente
    public class Maestro : Docente
    {
        public string NivelEducativo { get; set; }

        public Maestro(string nombre, int edad, string cargo, string materia, string nivelEducativo)
            : base(nombre, edad, cargo, materia)
        {
            NivelEducativo = nivelEducativo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Nivel Educativo: {NivelEducativo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MiembroDeLaComunidad miembro = new MiembroDeLaComunidad("Juan Pérezz", 39);
            miembro.MostrarInformacion();

            Empleado empleado = new Empleado("Analiz Gómez", 38, "Recepcionista");
            empleado.MostrarInformacion();

            Estudiante estudiante = new Estudiante("Carlos López", 37, "Ingeniería");
            estudiante.MostrarInformacion();

            ExAlumno exAlumno = new ExAlumno("Marta Gómez Sánchez", 27, "2020");
            exAlumno.MostrarInformacion();

            Docente docente = new Docente("Lucía mari Ramírez", 40, "Profesor", "Matemáticas secundarias");
            docente.MostrarInformacion();

            Administrativo administrativo = new Administrativo("Pedro Martín", 35, "Secretario", "Administración");
            administrativo.MostrarInformacion();

            Administrador administrador = new Administrador("Claudia Torres", 45, "Administrador", "Historia", "Finanzas");
            administrador.MostrarInformacion();

            Maestro maestro = new Maestro("Roberto Díaz", 50, "Maestro", "Física", "Secundaria");
            maestro.MostrarInformacion();

            Console.ReadLine();
      
        }
    }




}
