using System;
using System.Collections.Generic;

namespace basic_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var names = Arrays();
            var iceCreams = Lists();
            Dictionaries(names, iceCreams);
        }
      public static string[] Arrays() {
      Console.WriteLine("Arrays: ");
    /*
    Create an array to hold integer values 0 through 9
    Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
    Create an array of length 10 that alternates between true and false values, starting with true
    */
    int[] nums = {0,1,2,3,4,5,6,7,8,9};
    foreach(var num in nums)
    {
        Console.Write("{0} ", num);
    }
    Console.WriteLine("");
    string[] names = {"Tim", "Martin", "Nikki", "Sara"};
    foreach(string name in names)
    {
        Console.Write("{0} ", name);
    }
    Console.WriteLine();
    bool[] ten = new bool[10];
    for(int i = 0; i < 10; i++)
    {
        if(i % 2 == 0)
            ten[i] = true;
        else
            ten[i] = false;
    }
    foreach(var instance in ten)
        Console.Write("{0} ", instance);
    Console.WriteLine();

    return names;
  }

  public static List<String> Lists()
  {
    /*Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
    Output the length of this list after building it
    Output the third flavor in the list, then remove this value
    Output the new length of the list (It should just be one fewer!)
    */
    
    Console.WriteLine("########################");
    List<String> iceCreams = new List<String>();
    iceCreams.Add("Vanilla");
    iceCreams.Add("Chocolate");
    iceCreams.Add("Rocky Road");
    iceCreams.Add("Cookie Dough");
    iceCreams.Add("Mint Chocolate Chip");
    iceCreams.Add("Neopolatin");
    iceCreams.Add("Halo Top");
    Console.WriteLine("The length of the list: {0}", iceCreams.Count);
    foreach(string _ in iceCreams)
        Console.WriteLine(_);
    
    Console.WriteLine("The third flavor is {0}", iceCreams[2]);
    iceCreams.RemoveAt(2);
    Console.WriteLine("The length of the list: {0}", iceCreams.Count);

    return iceCreams;
  }

  public static void Dictionaries(string[] names, List<String> iceCreams)
  {
      Console.WriteLine("#########################");
    /*
    Create a dictionary that will store both string keys as well as string values
    Add key/value pairs to this dictionary where:
    each key is a name from your names array
    each value is a randomly select a flavor from your flavors list.
    Loop through the dictionary and print out each user's name and their associated ice cream flavor
    */
    Dictionary<string,string> favorites = new Dictionary<string, string> ();
    for(int i = 0; i < names.Length; i++)
    {
        var rand = new Random();
        int next = (rand.Next(0,iceCreams.Count));
        favorites.Add(names[i], iceCreams[next]);
    }

    foreach(var _ in favorites)
        Console.WriteLine($"{_.Key}'s favorite flavor is {_.Value}");

  }
    }
}
