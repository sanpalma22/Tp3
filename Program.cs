Cliente unCliente;
int[] preciosEntradas = { 0, 15000, 30000, 10000, 40000 };
int opcion;
do
{
    Menu();
    opcion = IngresarEntero("Ingresa la opción del menú que desea realizar");
    Console.Clear();
    switch (opcion)
    {
        case 1:
            NuevaInscripcion();
            break;
        case 2:
            ObtenerEstadisticas();
            break;
        case 3:
            BuscarCliente();
            break;
        case 4:
            CambiarEntrada();
            break;
        case 5:
            break;
        default:
            Console.WriteLine("Opción ingresada inexistente. Intente de nuevo");
            break;
    }
} while (opcion != 5);

void Menu()
{
    Console.WriteLine("1. Nueva Inscripción");
    Console.WriteLine("2. Obtener Estadísticas del Evento");
    Console.WriteLine("3. Buscar Cliente");
    Console.WriteLine("4. Cambiar entrada de un Cliente");
    Console.WriteLine("5. Salir.");
}
void TiposEntradas()
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
    text = Console.ReadLine().ToUpper();
    return text;
}
void NuevaInscripcion()
{
    int dni = IngresarEntero("Ingrese su DNI");
    string ape = IngresarTexto("Ingrese su apellido");
    string nom = IngresarTexto("Ingrese su nombre");
    TiposEntradas();
    int tipEnt = IngresarEntero("Ingrese el tipo de entrada que desea");
    int prec = preciosEntradas[tipEnt];
    unCliente = new Cliente(dni, ape, nom, tipEnt, prec);
    Tiquetera.AgregarCliente(unCliente);
    Tiquetera.DevolverUltimoId();
}
void ObtenerEstadisticas()
{
    foreach (string dato in Tiquetera.EstadisticasTicketera(preciosEntradas))
    {
        Console.WriteLine(dato);
    }
}
void BuscarCliente()
{
    int idBuscado = IngresarEntero("Ingrese el ID del cliente que desea buscar");
    unCliente = Tiquetera.BuscarCliente(idBuscado);
    if (unCliente == null) Console.WriteLine("Ese ID todavía no está creado");
    else
    {
        Console.WriteLine("DNI: " + unCliente.DNI);
        Console.WriteLine("Nombre: " + unCliente.Nombre);
        Console.WriteLine("Apellido: " + unCliente.Apellido);
        Console.WriteLine("Fecha de inscripción: " + unCliente.FechaInscripcion);
        Console.WriteLine("Tipo entrada: " + unCliente.TipoEntrada);
        Console.WriteLine("Total abonado: " + unCliente.TotalAbonado);
    }
}
void CambiarEntrada()
{
    int idBuscado = IngresarEntero("Ingrese el ID del cliente que desea buscar");
    TiposEntradas();
    int tipEnt = IngresarEntero("Ingrese el tipo de entrada que desea; debe ser más cara que la adquirida");
    bool posibleCambio = Tiquetera.CambiarEntrada(idBuscado, tipEnt, preciosEntradas[tipEnt]);
    if (posibleCambio) Console.WriteLine("Cambio realizado con exito");
    else Console.WriteLine("Cambio negado.");
}