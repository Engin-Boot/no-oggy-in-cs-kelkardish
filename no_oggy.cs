using System;
using System.Collections.Generic;

class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    var listAllOggys = new List<string> {};
    
    foreach (var name in names)
    {
        if(name.StartsWith("oggy")) {
            //Console.WriteLine($"Need to remove {name}!");
            listAllOggys.Add(name);
        }
    }
    
    foreach ( var oggy in listAllOggys)
    {
        names.Remove(oggy);
    }
  }
  static bool OggyIsRemoved(List<string> names)
  {
    return names.Find(x => x.Contains("oggy")) == null;
  }
  static int Main()
  {
    var names = new List<string>
      { "nobita", "bheem", "oggy", "oggy cockroach", "ninja" };
    RemoveOggy(names);
    if(OggyIsRemoved(names)) {
      Console.WriteLine("Passed!");
      return 0;
    } else {
      Console.WriteLine("Failed!!");
      return 1;
    }
  }
}
 
