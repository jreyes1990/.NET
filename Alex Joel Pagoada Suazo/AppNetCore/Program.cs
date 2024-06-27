namespace AppNetCore;

class Program
{
  static void Main(string[] args)
  {
    var data = new Program();
    var edad = data.metodoIntRetorno();
    // var name = data.metodoStringRetorno();
    Console.WriteLine(edad);
    Console.ReadLine();
    // data.metodoPublico();
    // data.metodoPrivado();
  }

  private void metodoPrivado()
  {
    Console.WriteLine("Hello, World!");
    Console.ReadLine();
  }

  public void metodoPublico()
  {
    Console.WriteLine("Hello, Jolberth!");
    Console.ReadLine();
  }

  private string metodoStringRetorno()
  {
    return $"Jolberth Reyes {34}";
  }

  private int metodoIntRetorno()
  {
    return Convert.ToInt16("53");
  }
}
