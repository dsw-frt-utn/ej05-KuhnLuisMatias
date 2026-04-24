namespace Dsw2026Ej5.Domain;

public abstract class Vehiculo
{
    private string _patente;
    private string _marca;
    private string _modelo;
    private int _anio;
    private double _capacidadCarga;
    private Sucursal _sucursal;
    private VehiculoTipo _tipo;

    protected Vehiculo(VehiculoTipo tipo, string patente, string marca, string modelo, int anio, double capacidadCarga, Sucursal sucursal)
    {
        _patente = patente;
        _marca = marca;
        _modelo = modelo;
        _anio = anio;
        _capacidadCarga = capacidadCarga;
        _sucursal = sucursal;
        _tipo = tipo;
    }

    public string GetPatente()
    {
        return _patente;
    }

    public string GetMarca()
    {
        return _marca;
    }

    public string GetModelo()
    {
        return _modelo;
    }

    public int GetAnio()
    {
        return _anio;
    }

    public double GetCapacidadCarga()
    {
        return _capacidadCarga;
    }

    public Sucursal GetSucursal()
    {
        return _sucursal;
    }

    public VehiculoTipo GetTipo()
    {
        return _tipo;
    }

    public abstract double CalcularConsumo(double kilometros);

    public bool EsDe(VehiculoTipo tipo)
    {
        return this._tipo == tipo;
    }

    public override string ToString()
    {
        return $"{GetMarca()} {GetModelo()}";
    }
}
