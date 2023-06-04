namespace EspacioEmpleado;

public enum Cargos {
    Auxiliar,
    Administrativo,
    Ingeniero, 
    Especialista,
    Investigador
}

public class Empleado {
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public char EstadoCivil { get; set; }
    public char Genero { get; set; }
    public DateTime FechaIngreso { get; set; }
    public double SueldoBasico { get; set; }
    public Cargos Cargo { get; set; }
    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, Cargos cargo) {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        EstadoCivil = estadoCivil;
        Genero = genero;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }
    public int CalcularAntiguedad() {
        TimeSpan duracion = DateTime.Today - FechaIngreso;
        int antiguedad = (int)duracion.TotalDays / 365;
        return antiguedad;
    }
    public int CalcularEdad() {
        TimeSpan duracion = DateTime.Today - FechaNacimiento;
        int edad = (int)duracion.TotalDays / 365;
        return edad;
    }
    public int CantidadAnios() {
        int edadJubilacion;
        if (Genero == 'M') {
            edadJubilacion = 65;
        } else {
            edadJubilacion = 60;
        }
        int aniosRestantes = edadJubilacion - CalcularEdad();
        if (aniosRestantes < 0) {
            return 0;
        } else {
            return aniosRestantes;
        }
    }
    public double CalcularSalario() {
        double Adicional, salario;
        int porcentaje = CalcularAntiguedad();
        if (porcentaje > 25) {
            porcentaje = 25;
        }
        Adicional = (SueldoBasico * porcentaje)/100;
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista) {
            porcentaje = 50;
            Adicional = Adicional + (Adicional * porcentaje)/100;
        }
        if (EstadoCivil == 'C') {
            Adicional += 15000;
        }
        salario = SueldoBasico + Adicional;
        return salario;
    }
}