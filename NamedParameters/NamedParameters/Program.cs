using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        public void GetCohortDetails(string cohort_name, int genc_count, string mode, string track, string current_module)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}\n", cohort_name, genc_count, track, mode, current_module);
        }

        static void Main(string[] args)
        {
            //object
            Program p = new Program();
            //In the oder of method
            p.GetCohortDetails("INTADM21DF008", 17, "OBL", ".Net", "C# handson");
            //incorrect order
            p.GetCohortDetails(".Net", 17, "OBL", "INTADM21DF008", "C# handson");
            //Named parameter
            p.GetCohortDetails(track: ".Net", mode: "OBL", cohort_name: "INTADM21DF008", current_module: "C# handson", genc_count: 17);
            Console.ReadLine();
        }
    }
}
