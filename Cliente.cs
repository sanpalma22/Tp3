class Cliente{
    public int DNI{get;private set;}
    public string Nombre{get;private set;}
    public string Apellido{get;private set;}
    public DateTime FechaInscripcion{get;set;}
    public int TipoEntrada{get;set;}
    public int TotalAbonado{get;set;}
    public int obtenerTotalAbonado();
    public Cliente(int dni,string ape,string nom, int tipEnt){
        DNI=dni;
        Nombre=nom;
        Apellido=ape;
        TipoEntrada=tipEnt;
        
    }
    
}