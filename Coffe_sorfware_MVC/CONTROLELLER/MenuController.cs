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
    public class MenuController
    {
        MenuModel menuM = new MenuModel();

        public List<Menu> getDSMenu()
        {
            List<Menu> menuLst = new List<Menu>();
            DataSet ds = menuM.layDanhSachMenu();
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                menuLst.Add(new Menu() { 
                ID = (int)row["ID"],
                tenMon = (string)row["tenMon"],
                gia = (int)row["gia"],
                loai = (int)row["loai"]
                });
            }
            return menuLst;
        }

        public DataSet getDanhSachMon()
        {
            return menuM.layDanhSachMenu();
        }

        public void themMon(string tenMon, int loaiMon, int giaMon)
        {
            menuM.themMenu(tenMon, loaiMon, giaMon);
        }

        public void xoaMon(int IDMon)
        {
            menuM.xoaMon(IDMon);
        }

        public void suaMon(int ID,string tenMon, int loaiMon, int giaMon)
        {
            menuM.suaMon(ID,tenMon, loaiMon, giaMon);
        }
    }//end
}
