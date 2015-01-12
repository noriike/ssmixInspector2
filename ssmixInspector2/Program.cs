using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ssmixInspector2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            InspectController ic = new InspectController();
            ic.Execute();

        }
    }
}
