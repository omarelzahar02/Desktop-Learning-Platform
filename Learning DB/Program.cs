using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_DB
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Inst1(10008));
            //Application.Run(new StudentClasses(50002));
            Application.Run(new Classroom(7));


            //Application.Run(new CreateExam(1, new DateTime(2022, 12,24)));
        }
    }
}
