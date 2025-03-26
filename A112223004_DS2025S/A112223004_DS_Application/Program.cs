//
//Project:Related DS Application
//Date:  2025/02/19
//Author: A112223004
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//=========== Namespace A112223004_DS_Application ===========//
namespace A112223004_DS_Application
{
    //====== Class ========//
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DS_Application());
        } //End of Main

    } //End of class
} //End of namespace
