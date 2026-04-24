using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class Sucursal
{
    private string _codigo;
    private string _direccion;
    private string _ciudad;
    private Responsable _responsable;

    public Sucursal(string codigo, string direccion, string ciudad, Responsable responsable)
    {
        _codigo = codigo;
        _direccion = direccion;
        _ciudad = ciudad;
        _responsable = responsable;
    }

    public string GetCodigo()
    {
        return _codigo;
    }

    public string GetDireccion()
    {
        return _direccion;
    }

    public string GetCiudad()
    {
        return _ciudad;
    }

    public Responsable GetResponsable()
    {
        return _responsable;
    }
}
