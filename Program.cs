// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using EspacioCalculadora;

Calculadora miCalculadora = new Calculadora();

int opcion=1, operacion;
double num1;

while (opcion != 0)
{
    Console.WriteLine("Ingrese la operacion que desea realizar: ");
    Console.WriteLine("0 - Salir");
    Console.WriteLine("1 - Suma");
    Console.WriteLine("2 - Resta");
    Console.WriteLine("3 - Multiplicacion");
    Console.WriteLine("4 - Division");

    int.TryParse(Console.ReadLine(), out operacion);

    switch (operacion)
    {
        case 0:
            opcion = 0;
            break;
        case 1:
            Console.WriteLine("Ingrese el número a sumar: ");
            double.TryParse(Console.ReadLine(), out num1);
            miCalculadora.Sumar(num1); 
            break;
        case 2: 
            Console.WriteLine("Ingrese el número a restarr: ");
            double.TryParse(Console.ReadLine(), out num1);
            miCalculadora.Restar(num1);
            break;
        case 3: 
            Console.WriteLine("Ingrese el número a multiplicar: ");
            double.TryParse(Console.ReadLine(), out num1);
            miCalculadora.Multipilicar(num1);
            break;
        case 4: 
            Console.WriteLine("Ingrese el número para dividir: ");
            double.TryParse(Console.ReadLine(), out num1);
            miCalculadora.Dividir(num1);
            break;

        default:
            Console.WriteLine("Operación inválida.");
            break;
    }

    Console.WriteLine("Resultado: " + miCalculadora.Resultado);

    Console.WriteLine(); //espacio
}

Console.WriteLine("\nCalculadora finalizada.");

    

