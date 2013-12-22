using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.CSharp;
using System.IO;
using System.Reflection;
namespace CScript
{
    public class CScriptEngine
    {

        private Evaluator sharpCompiler;
        private dynamic script;
        public string loadedCSharpCode { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        public CScriptEngine()
        {
            CompilerContext context = new CompilerContext(new CompilerSettings(),new ConsoleReportPrinter());
            sharpCompiler = new Evaluator(context);
            sharpCompiler.LoadAssembly("CIMCore.dll");      

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileNameAndPath"></param>
        /// <returns></returns>
        public bool LoadScriptFile(string fileNameAndPath)
        {
 
            try
            {
                loadedCSharpCode = System.IO.File.ReadAllText(fileNameAndPath);
            }
            catch 
            {
                return false;
            }

            sharpCompiler.Compile(loadedCSharpCode);

            Assembly asm = ((Type)sharpCompiler.Evaluate("typeof(Script);")).Assembly;

            script = asm.CreateInstance("Script");

            int result = script.SetupWrapupUI("1.1.1");

            Console.WriteLine(result);

            return true;
       
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public object Eval(String line)
        {

            object result;
            bool resultSet;

            sharpCompiler.Evaluate(line,out result, out resultSet);

            if (resultSet)
            {
                return result;
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public bool Run(String line)
        {

            return sharpCompiler.Run(line);
        }
    }
}
