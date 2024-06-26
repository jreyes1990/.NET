namespace AppNetCore;

class Program
{
  static void Main(string[] args)
  {
    var data = new Program();
    data.metodoPrivado();
  }

  private void metodoPrivado()
  {
    Console.WriteLine("Hello, World!");
    Console.ReadLine();
  }
}
