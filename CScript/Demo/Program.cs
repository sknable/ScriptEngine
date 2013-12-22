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
        static void Main(string[] ags)
        {

            CScriptEngine sharpEngine = new CScriptEngine();

            sharpEngine.LoadScriptFile(@"C:\Users\steve\Documents\visual studio 2013\Projects\CIMScript\CIMScript\Sample.cs");

            Console.ReadLine();
        }
    }
}
