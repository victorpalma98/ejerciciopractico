using System;

public class Empleado
{
    public string Id;
    public string nombre;

    public Empleado()
	{
        this.Id = null;
        this.nombre = null;
    }

    public string consultar_nombre()
    {
        return nombre;
    }
    public string consultar_cc()
    {
        return Id;
    }
}
