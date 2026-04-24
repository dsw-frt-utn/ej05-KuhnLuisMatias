using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class Responsable
{
    private string _nombre;
    private string _documento;
    private string _telefono;

    public Responsable(string nombre, string documento, string telefono)
    {
        _nombre = nombre;
        _documento = documento;
        _telefono = telefono;
    }

    public string GetNombre()
    {
        return _nombre;
    }

    public string GetDocumento()
    {
        return _documento;
    }

    public string GetTelefono()
    {
        return _telefono;
    }
}
