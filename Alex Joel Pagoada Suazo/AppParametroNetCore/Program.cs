namespace AppParametroNetCore;

class Program
{
  static void Main(string[] args)
  {
    Object[] parametros = { "Jolberth", 34, true };
    new Program().metodo(parametros);
    Console.WriteLine("Hola mundo");
    Console.ReadLine();
  }

  private void metodo(object[] parametros)
  {
    String nombre = (string)parametros[0];
    int edad = (int)parametros[1];
    bool valor = (bool)parametros[2];
  }
}
