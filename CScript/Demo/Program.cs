using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CScript;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            CScriptEngine sharpEngine = new CScriptEngine();

            Console.WriteLine(sharpEngine.Eval("int i = 0;"));
            Console.WriteLine(sharpEngine.Eval("i++;"));
            Console.WriteLine(sharpEngine.Eval("i++;"));
            Console.WriteLine(sharpEngine.Eval("i++;"));
            Console.WriteLine(sharpEngine.Eval("i++;"));

            Console.ReadLine();
        }
    }
}
