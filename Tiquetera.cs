public static class Tiquetera
{
    private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente>();
    private static int ultimoId = 0;
    public static int DevolverUltimoId()
    {
        return ultimoId;
    }
    public static int AgregarCliente(Cliente unCliente)
    {
        ultimoId++;
        DicClientes.Add(ultimoId, unCliente);
        return ultimoId;
    }
    public static Cliente BuscarCliente(int idEntrada)
    {
        if (DicClientes.ContainsKey(idEntrada))
        {
            return DicClientes[idEntrada];
        }
        else return null;
    }
    public static bool CambiarEntrada(int idEntrada, int TipoEntradaNueva, int precioEntradaNueva)
    {
        bool posibleCambio = precioEntradaNueva > DicClientes[idEntrada].TotalAbonado;
        if (posibleCambio)
        {
            DicClientes[idEntrada].TotalAbonado = precioEntradaNueva;
            DicClientes[idEntrada].TipoEntrada = TipoEntradaNueva;
        }
        return posibleCambio;

    }
    List<string> EstadisticasTicketera()
    {
        int[] cantEntradas = { 0, 0, 0, 0, 0 };
        int[] porcentajeEntradas = new int[5];
        string textPorcentajes = "";
        List<string> estadisticas = new List<string>();
        foreach (Cliente unCliente in DicClientes.Values)
        {
            cantEntradas[unCliente.TipoEntrada]++;
        }
        for (int i = 1; i < cantEntradas.Length; i++)
        {
            porcentajeEntradas[i] = cantEntradas[i] / DicClientes.Count * 100;
            textPorcentajes += ("Porcentaje Opcion {0}  %{1}  1", i, porcentajeEntradas);
        }
        estadisticas.Add(textPorcentajes);
        estadisticas.Add("Cantidad de clientes: " + DicClientes.Count);
    }
}