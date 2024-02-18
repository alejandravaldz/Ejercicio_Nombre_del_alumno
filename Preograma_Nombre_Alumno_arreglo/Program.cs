// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nombre de alumno y nota");
Console.WriteLine("");


Alumno alumno = new Alumno();

alumno.nombre = "Juan perez";
alumno.nota = 80;

alumno.ImprimirDatos();

class Alumno
{
    public string nombre;
    public int nota;

    public void ImprimirDatos()
    {
        Console.WriteLine($"su nombre es {nombre} y tiene {nota} puntos");
    }
}



