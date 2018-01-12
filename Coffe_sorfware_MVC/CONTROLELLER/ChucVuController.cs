using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL;
using System.Data.SqlClient;
using System.Data;

namespace CONTROLELLER
{
    public class ChucVuController
    {
        ChucVuModel cvModel = new ChucVuModel();
        public List<ChucVu> layDanhSachChucVu()
        {
            List<ChucVu> cvList = new List<ChucVu>();
            DataSet ds = cvModel.layDanhSachMenu();
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                cvList.Add(new ChucVu() { 
                    ID = (int)row["ID"],
                    chucVu = (string)row["chucVu"]
                });
            }

            return cvList;
        }
    }//end
}
