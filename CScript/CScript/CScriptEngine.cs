using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.CSharp;

namespace CScript
{
    public class CScriptEngine
    {

        private Evaluator sharpCompiler;


        /// <summary>
        /// 
        /// </summary>
        public CScriptEngine()
        {
            CompilerContext context = new CompilerContext(new CompilerSettings(),new ConsoleReportPrinter());
            sharpCompiler = new Evaluator(context);
        }

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
    }
}
