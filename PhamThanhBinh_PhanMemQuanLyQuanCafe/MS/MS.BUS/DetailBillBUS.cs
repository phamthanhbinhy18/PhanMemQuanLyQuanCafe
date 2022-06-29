using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public static class DetailBillBUS
    {
        public static bool IsExistDrinlInBillByIDBill(int id)
        {
            return DetailBillDAO.IsExistProductInBillByIDBill(id);
        }
        public static List<DetailBillDTO> GetListProductByIDBill(int idBill)
        {
            return DetailBillDAO.GetListProductByIDBill(idBill);
        }
        
        public static void InsertDetailBill(int idbill, int idProduct, int quantity)
        {
            DetailBillDAO.InsertDetailBill(idbill, idProduct, quantity);
        }
        public static int GetQuantityProduct(int idbill, int idProduct)
        {
           return DetailBillDAO.GetQuantityProduct(idbill, idProduct);
        }
        public static void DeleteOneProduct(int idbill, int idProduct)
        {
            DetailBillDAO.DeleteOneProduct(idbill,idProduct);
        }
        public static int IsExistProduct(int id)
        {
            return DetailBillDAO.IsExistProduct(id);  
        }
        public static int GetTotalDetailBillByIDBill(int idBill)
        {
            return DetailBillDAO.GetTotalDetailBillByIDBill(idBill);
        }
        public static bool IsExistProductByIDBillAndIDProduct(int idbill, int idProduct)
        {
            return DetailBillDAO.IsExistProductByIDBillAndIDProduct(idbill, idProduct);
        }
        public static bool IsEmpty(int idbill)
        {
            return DetailBillDAO.IsEmpty(idbill);
        }
   
    }
}
