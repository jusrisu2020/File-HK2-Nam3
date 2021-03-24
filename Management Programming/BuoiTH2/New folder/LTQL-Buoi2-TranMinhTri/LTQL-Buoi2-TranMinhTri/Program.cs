using LTQL_Buoi2_TranMinhTri.Phan1;
using LTQL_Buoi2_TranMinhTri.Phan2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LTQL_Buoi2_TranMinhTri
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bai1P2());
        }
    }
}
