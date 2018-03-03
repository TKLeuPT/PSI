using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
#region
            List<int> list = new List<int>();
            list.Capacity = 100;
            Console.WriteLine("Developer- Before you can leave you need to use the program at least once");
        Options:
            Console.WriteLine("         First List Editor         \n");
            Console.WriteLine("1. List");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Remove");
            Console.WriteLine("4. List Nr");
            Console.WriteLine("5. List Position");
            Console.WriteLine("6. Clear");
            Console.WriteLine("7. Go To Second Menu");
            Console.WriteLine("Esc. Leave");
            Console.Write("Option: ");
            int opt = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (opt)
            {
                case 1:
                    Console.WriteLine("List Size " + list.Count());
                    Console.WriteLine("List: ");
                    foreach (int i in list)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 2:
                    Console.WriteLine("How many numbers do you wish to add? ");
                    int nr = int.Parse(Console.ReadLine());
                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine("Nr to add: ");
                        int add = int.Parse(Console.ReadLine());
                        list.Add(add);
                        int pp = list.FindLast(x => x < list.Count());
                        Console.WriteLine("Nr " + add + " added to position: " + pp);
                    }
                    break;
                case 3:
                    Console.WriteLine("Which number do you wish to remove ");
                    int n = int.Parse(Console.ReadLine());
                    list.RemoveAt(n);
                    int p = list.FindLast(x => x < list.Count());
                    Console.WriteLine("Nr " + n + " removed from position: " + p);
                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:
                    Console.WriteLine("List Cleared");
                    list.Clear();
                    break;
                case 7:
                    Console.WriteLine("Are you sure? No=0/Yes=1");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == 0)
                    {
                        goto Options;
                    }
                    if (answer == 1)
                    {
                        goto Options2;
                    }
                    if (answer != 0 && answer != 1)
                    {
                        Console.WriteLine("Invalid Answer");
                        goto Options;
                    }
                    break;
            }
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
#endregion
#region
        Options2:
            List<int> list2 = new List<int>();

            int e = 0;
            int pos = 0;
            Console.WriteLine("         Second List Editor         \n");
            Console.WriteLine("1. Insert First");
            Console.WriteLine("2. Insert Last");
            Console.WriteLine("3. Remove First");
            Console.WriteLine("4. Remove Last");
            Console.WriteLine("5. Modify");
            Console.WriteLine("6. Remove Element");
            Console.WriteLine("7. Go To First Menu");
            Console.WriteLine("Esc. Leave");
            Console.Write("Option: ");
            int o = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (o)
            {
                case 1:
                    Console.WriteLine("Insert Element: ");
                    e = int.Parse(Console.ReadLine());
                    list2.Insert(0, e);
                    break;
                case 2:
                    Console.WriteLine("Insert Element: ");
                    e = int.Parse(Console.ReadLine());
                    list2.Insert(list2.Count, e);
                    break;
                case 3:
                    list2.RemoveAt(0);
                    Console.WriteLine("Removed");
                    break;
                case 4:
                    list2.RemoveAt(list2.Count);
                    Console.WriteLine("Removed");
                    break;
                case 5:
                    Console.WriteLine("Insert Element to Modify: ");
                    e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insert Position of the Element: ");
                    pos = int.Parse(Console.ReadLine());
                    list2.RemoveAt(pos);
                    list2.Insert(pos, e);
                    break;
                case 6:
                    Console.WriteLine("Element to Remove: ");
                    e = int.Parse(Console.ReadLine());

                    pos = Array.IndexOf(list2.ToArray(), e);
                    if (pos != -1)
                    {
                        Console.WriteLine("Element " + e + " in position " + (pos + 1));
                    }
                    else
                    {
                        Console.WriteLine("Position not found");
                    }
                    break;
                case 7:
                    Console.WriteLine("Are you sure? No=0/Yes=1");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == 0)
                    {
                        goto Options2;
                    }
                    if (answer == 1)
                    {
                        goto Options;
                    }
                    if (answer != 0 && answer != 1)
                    {
                        Console.WriteLine("Invalid Answer");
                        goto Options2;
                    }

                    break;
            
            }
            goto Options2;
#endregion
        }
    }
}