namespace EspacioEmpleado;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado{

    //atributos
    private string? nombre;
    private string? apellido;
    private DateTime fechadenacimiento;
    private char estadocivil;
    private char genero;
    private DateTime fechaingreso;
    private double sueldobasico;
    private Cargos cargo;
    private int edad;
    private int antiguedad;
    private int jubilacion;
    private double adicional;
    private double salario;

    //propiedades
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
    public char Estadocivil { get => estadocivil; set => estadocivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
    public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Antiguedad { get => antiguedad; set => antiguedad = value; }
    public int Jubilacion { get => jubilacion; set => jubilacion = value; }
    public double Adicional { get => adicional; set => adicional = value; }
    public double Salario { get => salario; set => salario = value; }


    //metodos
    public int CalcularAntiguedad(DateTime Fechaingreso){
        Antiguedad = DateTime.Now.Year - Fechaingreso.Year; //si quiero el año pongo "DateTime.Year" devuelve entero
        return Antiguedad;
    }
    public int CalcularEdad(DateTime Fechadenacimiento){
        Edad = DateTime.Now.Year - Fechadenacimiento.Year;
        return Edad;
    }
    public int CalcularJubilacion(char Genero, int Edad){
        if (Genero == 'M' || Genero == 'm')  //M=mujer
        {
            if (Edad < 60)
            {
                Jubilacion = 60 - Edad;
            } else
            {
                Jubilacion = 0;
            }
        } else
        {
            if (Edad < 65)
            {
                Jubilacion = 65 - Edad;
            } else
            {
                Jubilacion = 0;
            }
        }
        return Jubilacion;
    }

    public double CalcularSalario(int Antiguedad, Cargos Cargo, char Estadocivil)
    {
        Adicional = 0.0;

        if (Antiguedad <= 20)
        {
            Adicional = Sueldobasico * (Antiguedad * 0.01);
        } else
        {
            Adicional = Sueldobasico * 0.25;
        }
        if ((Cargo == Cargos.Ingeniero) || (Cargo == Cargos.Especialista))
        {
            Adicional *= 1.5;
        }
        if (Estadocivil == 'C' || Estadocivil == 'c') //casado
        {
            Adicional += 15000.0;
        }

        return (Sueldobasico + Adicional);
    }

}
