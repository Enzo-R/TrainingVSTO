﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingVSTO.Models
{
    public static class Excel
    {
        public static object Data { get; set; }
        public static string PathToM7Open
        {
            get { return "C:\\Users\\Enzo\\OneDrive\\Área de Trabalho\\Joyson\\Model.xlsx"; }
        }
        public static string PathToM7DModel
        {
            get { return "C:\\Users\\Enzo\\OneDrive\\Área de Trabalho\\Joyson\\AbreModelo7 - Rev1.xlsm"; }
        }
    }
}
