using System;
using System.IO;

class DesafioGrandesArquivos
{
  public static void Main(string[] args)
  {
    //GerarArquivosDe100mbs();
    PrintandoArquivosGrande();
  }

  public static void GerarArquivosDe100mbs()
  {
    using (StreamWriter sw = new StreamWriter("ArquivoGrande.txt"))
    {
      for (int x = 1; x < 2500000; x++)
      {
        sw.WriteLine($"{x} - {Guid.NewGuid()}");
      }
    }
  }

  public static void PrintandoArquivosGrande()
  {
    string line = "";
    using (StreamReader sr = new StreamReader("ArquivoGrande.txt"))
    {
      while ((line = sr.ReadLine()) != null)
      {
        Console.WriteLine(line);
      }
    }
  }

}
