using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using PLC通讯基础控件项目.控件类基.PLC基础接口.报警表_TO_Json;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
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

        /// <summary>
        /// 从指定路径导入报警表 目前指定导入威纶通导出的报警表
        /// </summary>
        /// <returns></returns>
        public async Task<List<Event_message>> ExportImportData()
        {
            List<Event_message> EventsLits = new List<Event_message>();
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                string FilePath = String.Empty;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var T = Task.Run(() =>
                    {

                        FilePath = openFileDialog.FileName;                      
                  //openFileDialog.OpenFile();
                  //根据路径通过已存在的excel来创建HSSFWorkbook，即整个excel文档
                  HSSFWorkbook workbook = new HSSFWorkbook(File.Open(@FilePath, FileMode.Open));
                  //获取excel的第一个sheet
                  HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);                   
                        //获取Excel的最大行数和列数
                        int rowsCount = sheet.PhysicalNumberOfRows;
                        int colsCount = sheet.GetRow(0).PhysicalNumberOfCells;
                        int pointerId = 0;
                        int content = 0;
                  //第一行为标题行，即从第二行开始循环
                  for (int x = 1; x < rowsCount; x++)
                        {
                            int.TryParse(sheet.GetRow(x).GetCell(19).ToString(), out content);

                            EventsLits.Add(new Event_message
                            {

                                ID = pointerId,
                                位触发条件 = BoolJudge(sheet.GetRow(x).GetCell(18).ToString()),
                                字触发条件 = DJudge(sheet.GetRow(x).GetCell(18).ToString()),
                                字触发条件_具体 = sheet.GetRow(x).GetCell(19).ToString(),
                                报警内容 = sheet.GetRow(x).GetCell(20).ToString(),
                                类型 = content == 0 ? 0 : 1,
                                设备 = IsPLCType(sheet.GetRow(x).GetCell(3).ToString()).ToString(),
                                设备_地址 = sheet.GetRow(x).GetCell(4).ToString(),
                                设备_具体地址 = sheet.GetRow(x).GetCell(7).ToString()

                            });

                            pointerId += 1;
                        }
                        return EventsLits;
                    });
                    return await T;
                }
                return EventsLits;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("从威纶通导入失败");
                MessageBox.Show("从威纶通导入失败"+ex.Message);
                return EventsLits;
            }
            bool BoolJudge(string Value)
            {
                if (string.IsNullOrWhiteSpace(Value))
                    return false;

                switch (Value)
                {
                    case "bt: 1":
                        return true;
                    case "bt: 0":
                        return false;
                    case "bt: 0 -> 1":
                        return true;
                    case "bt: 1 -> 0":
                        return false;
                    default:
                        return false;
                }
            }
            string DJudge(string Value)
            {
                if (string.IsNullOrWhiteSpace(Value))
                    return ">";

                switch (Value)
                {
                    case "wd: >":
                        return ">";
                    case "wd: <":
                        return "<";
                    case "wd: >=":
                        return ">=";
                    case "wd: <=":
                        return "<=";
                    case "wd: ==":
                        return "==";
                    case "wd: <>":
                        return "<>";
                    default:
                        return ">";
                }
            }
            PLC IsPLCType(string Type)
            {
                Regex rq = new Regex(Type.ToLower());
                foreach (var typeName in Enum.GetNames(typeof(PLC)))
                {
                    MatchCollection mc = Regex.Matches(Type.ToLower(), typeName.ToLower());
                    if (mc.Count>0)
                    {
                        return (PLC)Enum.Parse(typeof(PLC), typeName);
                    }
                }
                return PLC.Mitsubishi;
            }
        }
    }
}
