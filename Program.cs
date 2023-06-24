using EspacioEmpleado;

//instancias de Empleados
Empleado empleado1 = new Empleado();
empleado1.Nombre = "Carlos";
empleado1.Apellido = "Garcia";
empleado1.Fechadenacimiento = new DateTime(1980, 5, 15);
empleado1.Estadocivil = 'C';
empleado1.Genero = 'V';
empleado1.Fechaingreso = new DateTime(2010, 8, 20);
empleado1.Sueldobasico = 65000.0;
empleado1.Cargo = Cargos.Ingeniero;

Empleado empleado2 = new Empleado();
empleado2.Nombre = "Eugenia";
empleado2.Apellido = "Ruiz";
empleado2.Fechadenacimiento = new DateTime(1975, 3, 10);
empleado2.Estadocivil = 'S';
empleado2.Genero = 'M';
empleado2.Fechaingreso = new DateTime(2005, 6, 12);
empleado2.Sueldobasico = 55000.0;
empleado2.Cargo = Cargos.Especialista;

Empleado empleado3 = new Empleado();
empleado3.Nombre = "Juan";
empleado3.Apellido = "Avila";
empleado3.Fechadenacimiento = new DateTime(1990, 9, 25);
empleado3.Estadocivil = 'C';
empleado3.Genero = 'V';
empleado3.Fechaingreso = new DateTime(2015, 2, 8);
empleado3.Sueldobasico = 45000.0;
empleado3.Cargo = Cargos.Administrativo;

// Calcular el monto total de salarios
double montoTotalSalarios = empleado1.CalcularSalario(empleado1.CalcularAntiguedad(empleado1.Fechaingreso), empleado1.Cargo, empleado1.Estadocivil) + empleado2.CalcularSalario(empleado2.CalcularAntiguedad(empleado2.Fechaingreso), empleado2.Cargo, empleado2.Estadocivil) + empleado3.CalcularSalario(empleado3.CalcularAntiguedad(empleado3.Fechaingreso), empleado3.Cargo, empleado3.Estadocivil);
Console.WriteLine("Monto total de salarios: $" + montoTotalSalarios);

// Encontrar al empleado más próximo a jubilarse
Empleado empleadoProximoAJubilarse = empleado1;
int aniosProximoAJubilarse = empleado1.CalcularJubilacion(empleado1.Genero, empleado1.CalcularEdad(empleado1.Fechadenacimiento));

if (empleado2.CalcularJubilacion(empleado2.Genero, empleado2.CalcularEdad(empleado2.Fechadenacimiento)) < aniosProximoAJubilarse)
{
    empleadoProximoAJubilarse = empleado2;
    aniosProximoAJubilarse = empleado2.CalcularJubilacion(empleado2.Genero, empleado2.CalcularEdad(empleado2.Fechadenacimiento));
}

if (empleado3.CalcularJubilacion(empleado3.Genero, empleado3.CalcularEdad(empleado3.Fechadenacimiento)) < aniosProximoAJubilarse)
{
    empleadoProximoAJubilarse = empleado3;
    aniosProximoAJubilarse = empleado3.CalcularJubilacion(empleado3.Genero, empleado3.CalcularEdad(empleado3.Fechadenacimiento));
}

// Mostrar los datos del empleado más próximo a jubilarse
Console.WriteLine("\n------EMPLEADO MAS PROXIMO A JUBILARSE-------");
Console.WriteLine("Nombre: " + empleadoProximoAJubilarse.Nombre);
Console.WriteLine("Apellido: " + empleadoProximoAJubilarse.Apellido);
Console.WriteLine("Fecha de Nacimiento: " + empleadoProximoAJubilarse.Fechadenacimiento.Date);
Console.WriteLine("Estado Civil: " + empleadoProximoAJubilarse.Estadocivil);
Console.WriteLine("Género: " + empleadoProximoAJubilarse.Genero);
Console.WriteLine("Antiguedad en la empresa: " + empleadoProximoAJubilarse.CalcularAntiguedad(empleadoProximoAJubilarse.Fechaingreso) + " anios");
Console.WriteLine("Edad: " + empleadoProximoAJubilarse.CalcularEdad(empleadoProximoAJubilarse.Fechadenacimiento));
Console.WriteLine("Anios que faltan para jubilarse: " + empleadoProximoAJubilarse.CalcularJubilacion(empleadoProximoAJubilarse.Genero, empleadoProximoAJubilarse.CalcularEdad(empleadoProximoAJubilarse.Fechadenacimiento)));
Console.WriteLine("Cargo: " + empleadoProximoAJubilarse.Cargo);
Console.WriteLine("Salario: " + empleadoProximoAJubilarse.CalcularSalario(empleadoProximoAJubilarse.CalcularAntiguedad(empleadoProximoAJubilarse.Fechaingreso), empleadoProximoAJubilarse.Cargo, empleado1.Estadocivil));
