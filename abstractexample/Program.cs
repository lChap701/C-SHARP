using AbstractExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class ClassA
    {
        //public abstract void Method1(); // does not work, only works in abstract classes

        public static void Method2()
        {
            // must provide implementation of non-abstract method
        }

        static void Method3()
        {

        }

        protected static void Method4() // only used by child classes
        {
            Method3();
        }
    }

    /// <summary>
    /// Cannot instiate objects, only inherit
    /// </summary>
    public abstract class ClassB
    {
        public abstract void Method1(); // cannot have a body

        protected void Method2()
        {
            ClassA.Method2();
            // ClassA.Method3(); // cannot access private methods
            // ClassA.Method4(); // cannot access protected methods because ClassB is not a child of ClassA
        }
    }

    public class ClassC : ClassB
    {
        public override void Method1()
        {
            Method2();  // addressed via class name due to the method being static
        }
    }
}