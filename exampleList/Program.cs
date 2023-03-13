using System;

namespace exampleList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> newList = new List<string>();
            // add
            newList.Add("A");
            newList.Add("B");
            newList.Add("C");
            newList.Add("D");
            newList.Add("E");
            // add range 
            string[] extraData = new string[] { "F", "G", "H" };
            newList.AddRange(extraData);
            // sort
            newList.Sort();
            // remove
            newList.Remove("A");
            // reverse sort and display
            newList.Reverse();
            foreach (string item in newList) Console.WriteLine(item);
        }
    }
}