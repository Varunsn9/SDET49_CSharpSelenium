using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//[assembly: Parallelize(Workers = 2, Scope = ExecutionScope.MethodLevel)]

namespace SDET49_CSharpSelenium.TestScript
{
    [TestClass]
    public class Parallization
    {
        [TestMethod]
        [TestCategory("ParallelExecution")]
        public void ParallelExecution0()
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Execution no {new DateTime().Millisecond}");
        }
        [TestMethod]
        [TestCategory("ParallelExecution")]
       // [DoNotParallelize]
        public void ParallelExecution1()
        {
            Thread.Sleep(10000);
            Console.WriteLine($"Execution no {new DateTime().Millisecond}");
        }
        [TestMethod]
        [TestCategory("ParallelExecution")]
        public void ParallelExecution2()
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Execution no {DateTime.Now}");
        }

        [TestMethod]
        [TestCategory("ParallelExecution")]
        [Priority(0)]
        public void ParallelExecution3()
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Execution no {new DateTime().Millisecond}");
            // int a=Convert.ToInt32(Console.ReadLine());
        }
    }
}
