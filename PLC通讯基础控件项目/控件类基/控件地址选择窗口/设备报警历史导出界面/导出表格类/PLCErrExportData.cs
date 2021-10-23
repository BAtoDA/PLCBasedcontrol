using Newtonsoft.Json;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using PLC通讯基础控件项目.控件类基.PLC基础接口.报警表_TO_Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警历史导出界面.导出表格类
{
    /// <summary>
    /// 导出设备报警历史类
    /// 自动导出30天报警内容
    /// </summary>
    public class PLCErrExportData
    {
        #region 导出状态
        /// <summary>
        /// 导出个数
        /// </summary>
        public volatile int Count;
        /// <summary>
        /// 导出地址
        /// </summary>
        public volatile string Address;
        /// <summary>
        /// 导出内容
        /// </summary>
        public volatile string Content;
        /// <summary>
        /// 导出数据事件
        /// </summary>
        public event EventHandler ExportDataRun;
        #endregion
        /// <summary>
        /// 根据文件路径自动导出30天报警历史
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<bool> ExporData(List<Event_message> content)
        {
            string saveAddress = "PLCErr.xlsx";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            dialog.SelectedPath = System.IO.Directory.GetCurrentDirectory();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                saveAddress = dialog.SelectedPath + "\\PLCErr.xlsx";
            }
            else
                return false;
            await Task.Run(() =>
            {
                //象数据转换为Datatable，以简化逻辑。
                //Datatable是处理复杂数据类型的最简单方法，便于读取和格式化。
                DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(content), (typeof(DataTable)));
                var memoryStream = new MemoryStream();
                using (var fs = new FileStream(@saveAddress, FileMode.Create, FileAccess.Write))
                {
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet excelSheet = workbook.CreateSheet("Sheet1");
                    List<String> columns = new List<string>();
                    IRow row = excelSheet.CreateRow(0);
                    int columnIndex = 0;
                    //获取数据
                    Count = table.Rows.Count;
                    Address = @saveAddress;
                    foreach (System.Data.DataColumn column in table.Columns)
                    {
                        columns.Add(column.ColumnName);
                        row.CreateCell(columnIndex).SetCellValue(column.ColumnName);
                        columnIndex++;
                    }
                    int rowIndex = 1;
                    foreach (DataRow dsrow in table.Rows)
                    {
                        row = excelSheet.CreateRow(rowIndex);
                        int cellIndex = 0;
                        foreach (String col in columns)
                        {
                            row.CreateCell(cellIndex).SetCellValue(dsrow[col].ToString());
                            Content = dsrow[col].ToString();
                            ExportDataRun.Invoke(dsrow, new EventArgs());
                            cellIndex++;
                        }
                        rowIndex++;
                    }
                    workbook.Write(fs);
                }
            });
            return true;
        }
    }
}
