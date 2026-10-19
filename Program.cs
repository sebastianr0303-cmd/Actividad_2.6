Console.WriteLine("Inicio del programa");

//VARIABLES
int opcion, edad = 22;
string nombre = "Sebastian";
          
do
{
    //OPCIONES DE LA CONSOLA
    Console.WriteLine("\n===== MENÚ PRINCIPAL =====\n");
    Console.WriteLine("1. Mostrar nombre");
    Console.WriteLine("2. Mostrar edad");
    Console.WriteLine("3. Limpiar pantalla");
    Console.WriteLine("4. Salir");
    Console.WriteLine("\nSeleccione una opción:");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
        Console.WriteLine($"Nombre: {nombre}");
        break;

        case 2:
        Console.WriteLine($"Edad: {edad}");
        break;

        case 3:
        Console.Clear();
        break;

        case 4:
        Console.WriteLine("Saliendo del programa...");
        break;

        default:
        Console.WriteLine("Opción incorrecta");
        break;
    }

} while (opcion != 4);

Console.WriteLine("Fin del Programa");