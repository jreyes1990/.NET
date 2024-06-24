namespace cursoNetCore;

class Program
{
  static void Main(string[] args)
  {
    String separador = "================";
    Program progra = new Program();
    // progra.functionTipoDato(separador);
    progra.functionArray(separador);
  }

  public void functionTipoDato(String separador)
  {
    // int year = 10;
    int year = Convert.ToInt16("12"); // Convirtiendo la cadena de texto a entero
    double doble = 2.5; // Variable (double) con valor decimal
    string nombre = "Jolberth"; // Variable (string) con valor texto
    String nombres = "Jolberth Alberto"; // Variable (string) con valor cadena de texto
    decimal decimales = 2.08M; // Variable (decimal) con valor decimal
    float flotante = 8.34F; // Variable (float) con valor decimal
    bool valida = false; // Variable (false|true) con valor booleano
    char letra = 'A'; // Variable (char) almacena una caracter
    Decimal de = 28.4M; // Variable (Decimal) con valor decimal
    Boolean valor = false;
    Console.WriteLine("Hola Jolberth Reyes, bienvenido al mundo de la programación");
    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Tipo de dato [string, double, float, decimal, int]:");
    Console.WriteLine("=> float [7 digitos, 32 bits] \n=> double [15-16 digitos, 64 bits] \n=> decimal [28-29 digitos, 128 bits]");
    Console.WriteLine("Año: {0}, double: {1} Nombre: {2} Nombres: {3} decimal: {4} flotante: {5}", year, doble, nombre, nombres, decimales, flotante);
    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Tipo de dato [bool, char y estructuras para almacenar datos]:");
    Console.WriteLine("Valida: {0}, Letra: {1}, Decimal: {2}, Valida2: {3}", valida, letra, de, valor);
    Console.ReadLine();
  }

  public void functionArray(String separador)
  {
    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Array Tipo String:");

    string[] cadenas = new string[5];
    cadenas[0] = "Carmen";
    cadenas[1] = "Sherly";
    cadenas[2] = "Michael";
    cadenas[3] = "Alberto";
    cadenas[4] = "Jolberth";
    string[] name = { "Carmen", "Alberto", "Michael", "Sherly", "Jolberth" };

    Console.WriteLine("Longuitud Cadena: {0}, Posicion[1]: {1}  Name: {2}, Posicion[1]: {3}", cadenas.Length, cadenas[1], name.Length, name[1]);

    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Array Tipo Int:");

    int[] age = new int[5];
    age[0] = 5;
    age[1] = 15;
    age[2] = 50;
    age[3] = 55;
    age[4] = 95;
    int[] ages = { 5, 15, 50, 95, 55 };

    Console.WriteLine("Longuitud Age: {0}, Posicion[1]: {1}, Longuitud Ages: {2}, Posicion[3]: {3}", age.Length, age[2], ages.Length, ages[3]);

    Console.ReadLine();
  }
}
