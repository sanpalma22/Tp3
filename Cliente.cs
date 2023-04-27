public class Cliente{
    public int DNI{get;private set;}
    public string Nombre{get;private set;}
    public string Apellido{get;private set;}
    public DateTime FechaInscripcion{get;set;}
    public int TipoEntrada{get;set;}
    public int TotalAbonado{get;set;}
    public int obtenerPrecioAbonado(){
        int[] preciosEntradas={0,15000,30000,10000,40000};
        TotalAbonado=preciosEntradas[TipoEntrada];
        return TotalAbonado;
    }
    public Cliente(int dni,string ape,string nom, int tipEnt){
        DNI=dni;
        Nombre=nom;
        Apellido=ape;
        TipoEntrada=tipEnt;
        TotalAbonado=obtenerPrecioAbonado();
    }
    
}