using System;

class Program
{
  public static int Main()
  {
    int n = 0;
    string tmp;
    bool check = false;

    do
    {
      Console.Write("Input number of numbers: ");
      tmp = Console.ReadLine();
      if (int.TryParse(tmp, out _)) {
        n = int.Parse(tmp);
        check = true;
        if (n<1){
          check = false;
        }
      } else {
        check = false;
      }
    } while (!check);

    if (n == 1)
    {
      Console.WriteLine("F1) 0");
    }
    else if (n>=2)
    {
      
      double n_1 = 0;
      double n_2 = 1;
      Console.WriteLine("F{0}) 0", n_1);
      Console.WriteLine("F{0}) 1", n_2);

      for (int i = 3; i <= n; ++i)
      {
        double n_3 = n_1 + n_2;
        Console.WriteLine("F{0}) {1}", i, n_3);
        n_1 = n_2;
        n_2 = n_3;
      }
    }

    Console.ReadKey();
    return 0;
  }

}