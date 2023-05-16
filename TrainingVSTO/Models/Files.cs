using System.Windows;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
            Application excelApp = Globals.ThisAddIn.getActiveApp();
        public static void CreateM7D()
            string date = Models.Excel.date.ToString();
            string dateValidate = date.Replace("/", ".");

            string PathToServer = @"S:\Log_Planej_Adm\CY Inventory Tracking\Relatório Estoque Geral\2022\Teste\M7 - STK " + dateValidate + ".xlsx";
            currentSheet.Range["A4"].PasteSpecial(XlPasteType.xlPasteAll);
            Models.Workbooks.UpFormulas();
            if (currentSheet.Cells != null)
            {
                try
                {
                    workbook.SaveAs(PathToServer);
                }
                catch (Exception)
                {
                    workbook
                    .SaveAs(@"C:\Users\Enzo\OneDrive\Área de Trabalho\Joyson\M7 - STK " + dateValidate + ".xlsx");
                }
                Workbooks.ReleaseObject(currentSheet);
                Clipboard.Clear();
            }
