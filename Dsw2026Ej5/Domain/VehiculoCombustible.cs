namespace Dsw2026Ej5.Domain;

public class VehiculoCombustible: Vehiculo
{
    private double _kilometrosPorLitro;
    private double _litrosExtra;

    public VehiculoCombustible(string patente, string marca, string modelo, int anio, double capacidadCarga, 
        Sucursal sucursal, double kilometrosPorLitro, double litrosExtra) : base(VehiculoTipo.Combustible, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        _kilometrosPorLitro = kilometrosPorLitro;
        _litrosExtra = litrosExtra;
    }

    public double GetKilometrosPorLitro()
    {
        return _kilometrosPorLitro;
    }

    public double GetLitrosExtra()
    {
        return _litrosExtra;
    }

    public override double CalcularConsumo(double kilometros)
    {
        double total = kilometros / GetKilometrosPorLitro();
        int antiguedad = DateTime.Now.Year - GetAnio();

        if (antiguedad > 5)
        {
            total += (kilometros / 15) * GetLitrosExtra();
        }
        return total;
    }
}
