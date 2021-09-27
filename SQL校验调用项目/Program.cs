using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL校验调用项目
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //测试SQLserver数据库
            using (SqlConnection db = new SqlConnection(@"Data Source=LAPTOP-INNCV6MO;Initial Catalog=Test;Integrated Security=True"))
            {
                db.Open();
                //测试名以及数据类型
                SqlCommand sqlCommand = new SqlCommand($"select * from Numeber1 ", db);
                var SqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                SqlDataAdapter.FillSchema(ds, System.Data.SchemaType.Mapped);
                Console.Read();

                db.Close();
            }
        }
    }
}
