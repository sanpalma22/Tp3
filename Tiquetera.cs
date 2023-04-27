public static class Tiquetera
{
static private Dictionary<int,Cliente>DicClientes=new Dictionary<int, Cliente>();
static private int ultimoId=1;
static public int DevolverUltimoId(){
    ultimoId++;
    return ultimoId;
}
static public int AgregarCliente(Cliente unCliente){
    DicClientes.Add(ultimoId,unCliente);
    
}
static public Cliente BuscarCliente(int idEntrada);
static public bool CambiarEntrada(int idEntrada,int tipo, int total);
List<string> EstadisticasTicketera();
}