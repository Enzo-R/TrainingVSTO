﻿
using System;
            Application excelApp = Globals.ThisAddIn.getActiveApp();
            Workbook workbook = excelApp.Workbooks.Open(Excel.PathToM7DOpen);
            Worksheet Sheet = workbook.Sheets["M7"];

            string date = Excel.date.ToString("d");
            string dateValidate = date.Replace("/", ".");
            string PathToServer = @"S:\Log_Planej_Adm\CY Inventory Tracking\Relatório Estoque Geral\2022\Teste\M7 - STK "
                + dateValidate +
                " -.xlsx";

            Workbooks.M7Formulas();
            //Create Power Pivot
            Workbooks.DynimicTable();

                    .SaveAs(@"C:\Users\Enzo\OneDrive\Área de Trabalho\Joyson\M7 - STK " + dateValidate + " -.xlsx");
                }
                finally
                {
                    Clipboard.Clear();
                    Workbooks.ReleaseObject(currentSheet);
                    Workbooks.ReleaseObject(excelApp);