using Dsw2026Ej5.Domain;

namespace Dsw2026Ej5.Views;

public class VehiculoViewModel
{
    private string _patente = string.Empty;
    private string? _vehiculo;
    private string? _tipo;
    private string? _sucursal;
    private double _capacidadCarga;
    private double _kmPorLitro;
    private int _anio;
    private double _litrosExtra;
    private double _kmARecorrer;

    public VehiculoViewModel(Vehiculo vehiculo)
    {
        if (vehiculo == null) return;
        _patente = vehiculo.GetPatente();
        _vehiculo = vehiculo.ToString();
        _tipo = vehiculo.GetTipo().ToString();
        _sucursal = vehiculo.GetSucursal().GetCodigo();
        _capacidadCarga = vehiculo.GetCapacidadCarga();
        _anio = vehiculo.GetAnio();
        _kmPorLitro = vehiculo is VehiculoCombustible combustible ? combustible.GetKilometrosPorLitro() : 0;
        _litrosExtra = vehiculo is VehiculoCombustible combustible1 ? combustible1.GetLitrosExtra() : 0;
        _kmARecorrer = 100;
    }

    public string GetPatente()
    {
        return _patente;
    }

    public string? GetVehiculo()
    {
        return _vehiculo;
    }

    public string? GetTipo()
    {
        return _tipo;
    }

    public string? GetSucursal()
    {
        return _sucursal;
    }

    public double GetCapacidadCarga()
    {
        return _capacidadCarga;
    }

    public double GetKmPorLitro()
    {
        return _kmPorLitro;
    }

    public int GetAnio()
    {
        return _anio;
    }

    public double GetLitrosExtra()
    {
        return _litrosExtra;
    }

    public double GetKmARecorrer()
    {
        return _kmARecorrer;
    }
}
