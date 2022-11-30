using InspectorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProVed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp fi = new FunctionInsp();
            Console.WriteLine(fi.GetInspector());
            Console.WriteLine(fi.GetWorker());
            Console.WriteLine(fi.GetInspector());
            fi.SetInspector("Human H.H.");
            fi.AddWorker();
        }
    }
}
