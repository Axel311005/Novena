using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace Novena
{
    public class ExportarExcel
    {
        //public void ExportarAExcel(DataGridView dataGridView)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
        //    saveFileDialog.Title = "Guardar archivo de Excel";
        //    saveFileDialog.FileName = "MiArchivo.xlsx";

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string rutaArchivo = saveFileDialog.FileName;

        //        Excel.Application excelApp = new Excel.Application();
        //        Excel.Workbook workbook = excelApp.Workbooks.Add();
        //        ExportarDataGridViewAExcel(dataGridView, workbook);

        //        workbook.SaveAs(rutaArchivo);
        //        workbook.Close();
        //        excelApp.Quit();

        //        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
        //        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        //    }
        //}

        //private void ExportarDataGridViewAExcel(DataGridView dataGridView, Excel.Workbook workbook)
        //{
        //    Excel.Worksheet worksheet = workbook.Sheets.Add();
        //    worksheet.Name = GenerarNombreUnico(workbook, "Hoja1");


        //    for (int i = 1; i <= dataGridView.Columns.Count; i++)
        //    {
        //        worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
        //    }


        //    for (int i = 0; i < dataGridView.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dataGridView.Columns.Count; j++)
        //        {
        //            var cellValue = dataGridView.Rows[i].Cells[j].Value;
        //            if (cellValue is DateOnly dateOnlyValue)
        //            {
        //                worksheet.Cells[i + 2, j + 1] = dateOnlyValue.ToString("yyyy-MM-dd");
        //            }
        //            else
        //            {
        //                worksheet.Cells[i + 2, j + 1] = cellValue;
        //            }
        //        }
        //    }
        //}

        //private string GenerarNombreUnico(Excel.Workbook workbook, string baseName)
        //{
        //    int counter = 1;
        //    string sheetName = baseName;
        //    while (NombreHojaExistente(workbook, sheetName))
        //    {
        //        sheetName = baseName + counter;
        //        counter++;
        //    }
        //    return sheetName;
        //}

        //private bool NombreHojaExistente(Excel.Workbook workbook, string sheetName)
        //{
        //    foreach (Excel.Worksheet sheet in workbook.Sheets)
        //    {
        //        if (sheet.Name.Equals(sheetName, StringComparison.OrdinalIgnoreCase))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //EPPlus

        public void ExportarAExcelConEPPlus(DataGridView dataGridView)
        {
            // Configuración inicial de EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar archivo de Excel";
            saveFileDialog.FileName = "MiArchivoConChecks.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;

                using (var package = new ExcelPackage())
                {
                    // Crear una hoja de Excel
                    var worksheet = package.Workbook.Worksheets.Add("Hoja1");

                    // Encabezados
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridView.Columns[col].HeaderText;
                    }

                    // Datos
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridView.Columns.Count; col++)
                        {
                            var cellValue = dataGridView.Rows[row].Cells[col].Value;

                            if (cellValue is bool) // Si es un valor booleano
                            {
                                worksheet.Cells[row + 2, col + 1].Value = (bool)cellValue ? "✔" : ""; // Check si es verdadero
                            }
                            else
                            {
                                worksheet.Cells[row + 2, col + 1].Value = cellValue; // Otro tipo de datos
                            }
                        }
                    }

                    // Guardar el archivo Excel
                    var fileInfo = new FileInfo(rutaArchivo);
                    package.SaveAs(fileInfo);

                    MessageBox.Show("Exportación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
