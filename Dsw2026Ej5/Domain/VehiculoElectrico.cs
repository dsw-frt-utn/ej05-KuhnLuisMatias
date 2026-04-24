namespace Dsw2026Ej5.Domain;

public class VehiculoElectrico : Vehiculo
{
    private double _kwhBase;

    public VehiculoElectrico(string patente, string marca, string modelo, int anio, double capacidadCarga,
        Sucursal sucursal, double kwhBase) : base(VehiculoTipo.Electrico, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        _kwhBase = kwhBase;
    }

    public double GetKwhBase()
    {
        return _kwhBase;
    }

    public override double CalcularConsumo(double kilometros)
    {
        double total = (kilometros / 100) * _kwhBase;

        if (GetCapacidadCarga() > 1200)
        {
            total = total * 1.15;
        }

        return total;
    }
}
