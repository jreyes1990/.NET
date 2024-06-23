namespace cursoNetCore;

class Program
{
  static void Main(string[] args)
  {
    // int year = 10;
    int year = Convert.ToInt16("12"); // Convirtiendo la cadena de texto a entero
    double doble = 2.5; // Variable (double) con valor decimal
    string nombre = "Jolberth"; // Variable (string) con valor texto
    String nombres = "Jolberth Alberto"; // Variable (string) con valor cadena de texto
    decimal decimales = 2.08M; // Variable (decimal) con valor decimal
    float flotante = 8.34F; // Variable (float) con valor decimal
    Console.WriteLine("Hola Jolberth Reyes, bienvenido al mundo de la programación");
    Console.WriteLine("float [7 digitos, 32 bits] \ndouble [15-16 digitos, 64 bits] \ndecimal [28-29 digitos, 128 bits]");
    Console.WriteLine("Año: {0}, double: {1} Nombre: {2} Nombres: {3} decimal: {4} flotante: {5}", year, doble, nombre, nombres, decimales, flotante);
    Console.ReadLine();
  }
}
