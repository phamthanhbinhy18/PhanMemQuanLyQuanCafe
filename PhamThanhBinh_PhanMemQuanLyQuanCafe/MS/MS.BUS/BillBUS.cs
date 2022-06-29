using System;
using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class BillBUS
    {
        public static List<BillDTO> GetAllListBill()
        {
            return BillDAO.GetAllListBill();
        }
        public static List<BillUpDTO> GetListBillInAboutTime(DateTime from,DateTime to)
        {
            return BillDAO.GetListBillInAboutTime(from,to);
        }
        public static int GetIDBillNoPaymentByIDTable(int id)
        {
            return BillDAO.GetIDBillNoPaymentByIDTable(id);
        }
        public static void InsertBill(DateTime ThoiGian, double TongTien, int Employ, int idTable)
        {
            BillDAO.InsertBill(ThoiGian,TongTien,Employ,idTable);
        }
        public static int GetIDBillMax()
        {
            return BillDAO.GetIDBillMax();
        }
        public static void UpdatetBill(int id, double totalbill, double promotion, double cusPrice, double outPrice, double revenue, DateTime datetime, int employ)
        {
            BillDAO.UpdatetBill(id, totalbill, promotion, cusPrice, outPrice, revenue, datetime, employ);
        }
        public static void DeleteBill(int idbill)
        {
            BillDAO.DeleteBill(idbill);
        }

        public static bool IsExistAccountInBill(int user)
        {
            return BillDAO.IsExistAccountInBill(user);
        }
        
    }
}
