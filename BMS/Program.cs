using AutoMapper;
using BMS.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BMS
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

            Mapper.Initialize(cfg => cfg.CreateMap<Project, ProjectShow>());               

            Application.Run(new Main());
        }
    }
}