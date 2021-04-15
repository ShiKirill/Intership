using System;
using System.IO;
using Newtonsoft.Json.Linq;


class Program
{
  static void Main()
  {


    string jsonString = File.ReadAllText("test.json");
    var o = JObject.Parse(jsonString);


    foreach (var x in o)
    {
      string name = x.Key;
      JToken value = x.Value;
      foreach (var i in value)
      {
        Console.WriteLine("{0,-20} || {1,15}", name, i);
      }
    }

  }


}
