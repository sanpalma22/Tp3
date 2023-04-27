int opcion;
do
{
    menu();
    opcion = IngresarEntero("Ingresa la opción del menú que desea realizar");
    Console.Clear();
    switch (opcion)
    {
        case 1:
            nuevaInscripcion();
            break;
        case 2:

            break;
        case 3:

            break;
        case 4:
            break;
        case 5:
            break;
        default:
            Console.WriteLine("Opción ingresada inexistente. Intente de nuevo");
            break;
    }
} while (opcion != 4);

void menu()
{
    Console.WriteLine("1. Nueva Inscripción");
    Console.WriteLine("2. Obtener Estadísticas del Evento");
    Console.WriteLine("3. Buscar Cliente");
    Console.WriteLine("4. Cambiar entrada de un Cliente");
    Console.WriteLine("Salir.");
}
void tiposEntradas()
{
    Console.WriteLine("Opción 1 - Día 1 , valor a abonar $15000");
    Console.WriteLine("Opción 2 - Día 2, valor a abonar $30000");
    Console.WriteLine("Opción 3 - Día 3, valor a abonar $10000");
    Console.WriteLine("Opción 4 - Full Pass, valor a abonar $40000");
}
int IngresarEntero(string v)
{
    int num;
    Console.WriteLine(v);
    num = int.Parse(Console.ReadLine());
    return num;
}
string IngresarTexto(string v)
{
    string text;
    Console.WriteLine(v);
    text = Console.ReadLine();
    return text;
}
void nuevaInscripcion()
{
    int dni = IngresarEntero("Ingrese su DNI");
    string ape = IngresarTexto("Ingrese su apellido");
    string nom = IngresarTexto("Ingrese su nombre");
    tiposEntradas();
    int tipEnt = IngresarEntero("Ingrese el tipo de entrada que desea");
    Cliente unCliente = new Cliente(dni, ape, nom, tipEnt);
    Tiquetera.AgregarCliente(unCliente);
    Tiquetera.DevolverUltimoId();
    
    
}