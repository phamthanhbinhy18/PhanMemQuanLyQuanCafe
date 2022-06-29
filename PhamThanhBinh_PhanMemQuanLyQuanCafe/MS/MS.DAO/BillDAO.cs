using System;
using System.Collections.Generic;
using DTO;
using System.Data;


namespace DAO
{
    public class BillDAO
    {
        public static List<BillDTO> GetAllListBill()
        {
            List<BillDTO> lstBill = new List<BillDTO>();
            string query = "SELECT * from BILL WHERE Status = 1";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BillDTO detail = new BillDTO(item);
                lstBill.Add(detail);
            }
            return lstBill;
        }

        public static int GetIDBillNoPaymentByIDTable(int idTable)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.BILL where IDTable = " + idTable + " and Status = 0");//chưa thanh toán
            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public static void InsertBill(DateTime ThoiGian, double TongTien, int Employ, int idTable)
        {
            try
            {
                string query = "Exec USP_InsertBill @thoigian , @tongtien , @employ , @idtable ";
                DataProvider.Instance.ExcuteNonQuery(query, new object[] { ThoiGian, TongTien, Employ, idTable });
            }
            catch
            {
                throw;
            }
        }

        public static int GetIDBillMax()
        {
            string re = DataProvider.Instance.ExcuteScalar("SELECT MAX(ID) FROM DBO.BILL").ToString();
            if (re != "")
                return Convert.ToInt32(re);
            return 1;
        }

        public static void UpdatetBill(int id, double totalbill,double promotion, double cusPrice,double outPrice, double revenue, DateTime datetime, int employ)
        {
            string query = "Exec USP_UpdateBill @IDBILL , @TOTALBILL , @DATETIME , @EMPLOY , @PROMOTIONPRICE , @CUSTOMERPRICE , @OUTPRICE , @REVENUE ";

            DataProvider.Instance.ExcuteNonQuery(query, new object[] { id, totalbill, datetime, employ , promotion , cusPrice , outPrice , revenue });
        }

        public static void DeleteBill(int idbill)
        {
            DataProvider.Instance.ExcuteNonQuery("Exec USP_Deletebill @idbill ", new object[] { idbill });
        }

        public static List<BillUpDTO> GetListBillInAboutTime(DateTime ThoiGianTu, DateTime ThoiGianDen)
        {
            List<BillUpDTO> lstBill = new List<BillUpDTO>();
            string query = "SELECT b.[ID] , [CREATEDAY] , [IDTABLE] , [TOTALBILL] , [EMPLOY] , b.[STATUS] , [PROMOTIONPRICE] , [CUSTOMERPRICE] , [OUTPRICE] , [REVENUE] , [NAMETABLE] FROM BILL b INNER JOIN TABLEPRODUCT t on b.IDTABLE = t.ID WHERE CREATEDAY BETWEEN @THOIGIANTU AND @THOIGIANDEN AND b.[STATUS] = 1";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { ThoiGianTu, ThoiGianDen });
            foreach (DataRow item in data.Rows)
            {
                BillUpDTO detail = new BillUpDTO(item);
                lstBill.Add(detail);
            }
            return lstBill;
        }


        public static bool IsExistAccountInBill(int user)
        {
            //load bảng chi tiết hóa đơn theo mã hóa đơn
            DataTable data = DataProvider.Instance.ExcuteQuery("select ID from BILL where Employ = " + user);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
