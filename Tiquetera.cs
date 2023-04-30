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
    public static Cliente BuscarCliente(int id)
    {
        if (DicClientes.ContainsKey(id))
        {
            return DicClientes[id];
        }
        else return null;
    }
    public static bool CambiarEntrada(int id, int tipoEntNueva, int precio)
    {
        bool posibleCambio = precio > DicClientes[id].TotalAbonado;
        if (posibleCambio)
        {
            DicClientes[id].TotalAbonado = precio;
            DicClientes[id].TipoEntrada = tipoEntNueva;
            DicClientes[id].FechaInscripcion = DateTime.Now;
        }
        return posibleCambio;

    }
    public static List<string> EstadisticasTicketera(int[] preciosEntradas)
    {
        List<string> estadisticas = new List<string>();
        if (DicClientes.Count() != 0)
        {
            int[] cantEntradas = { 0, 0, 0, 0, 0 };
            int[] porcentajeEntradas = new int[5];
            int totalRecaudado = 0;
            string textPorcentajes = "";
            foreach (Cliente unCliente in DicClientes.Values)
            {
                cantEntradas[unCliente.TipoEntrada]++;
            }
            for (int i = 1; i < cantEntradas.Length; i++)
            {
                porcentajeEntradas[i] = cantEntradas[i] * 100 / DicClientes.Count;
                textPorcentajes += ("   Porcentaje Opcion " + i + " %" + porcentajeEntradas[i]);
                totalRecaudado += cantEntradas[i] * preciosEntradas[i];
            }
            estadisticas.Add(textPorcentajes);
            estadisticas.Add("Cantidad de clientes: " + DicClientes.Count);
            estadisticas.Add("Total recaudado: $" + totalRecaudado);
        }
        else estadisticas.Add("Aún no se anotó nadie");
        return estadisticas;
    }
}