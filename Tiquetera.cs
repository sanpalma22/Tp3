public static class Tiquetera
{
static private Dictionary<int,Cliente>DicClientes=new Dictionary<int, Cliente>();
static private int ultimoId=1;
static public int DevolverUltimoId();
static public int AgregarCliente(Cliente);
static public Cliente BuscarCliente(int idEntrada);
static public bool CambiarEntrada(int idEntrada,int tipo, int total);
List<string> EstadisticasTicketera();
}