using System;
using System.Collections.Generic;
using DTO;
using System.Data;

namespace DAO
{
    public class DetailBillDAO
    {
        public static bool IsExistProductInBillByIDBill(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT [IDBILL], [IDProduct], [QUANTITY]  FROM DBO.DETAILBILL WHERE IDBILL = " + id);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static void InsertDetailBill(int idbill, int idProduct, int quantity)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC USP_INSERTBILLINFO @idbill , @idProduct , @quantity ", new object[] { idbill, idProduct, quantity });
        }

        public static int GetQuantityProduct(int idbill, int idProduct)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT [IDBILL], [IDProduct], [QUANTITY]  FROM DBO.DETAILBILL AS DE WHERE IDBILL = " + idbill + " and IDProduct = " + idProduct);
            if (data.Rows.Count > 0)
            {
                DetailBillDTO debill = new DetailBillDTO(data.Rows[0]);
                return debill.Quantity;
            }
            return 0;
        }

        public static int GetTotalDetailBillByIDBill(int idbill)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT [IDBILL], [IDProduct], [QUANTITY]  FROM DBO.DETAILBILL AS DE WHERE IDBILL = " + idbill);
            if (data.Rows.Count > 0)
            {
                int tongtien = 0;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DetailBillDTO debill = new DetailBillDTO(data.Rows[i]);
                    tongtien += debill.Quantity;
                }
                return tongtien;
            }
            return 0;
        }

        public static void DeleteOneProduct(int idbill, int idProduct)
        {
            string query = "EXEC USP_DELETEDETAILBILL @idbill , @idProduct ";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { idbill, idProduct });
        }

        public static int IsExistProduct(int id)
        {
            string query = "SELECT DE.IDProduct FROM DETAILBILL AS DE WHERE DE.IDProduct = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["IDProduct"].ToString());
            }
            return -1;
        }

        public static bool IsExistProductByIDBillAndIDProduct(int idbill, int idProduct)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT [IDBILL], [IDProduct], [QUANTITY]  FROM DBO.DETAILBILL AS DE WHERE IDBILL = " + idbill + " and IDProduct = " + idProduct);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEmpty(int idbill)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT [IDBILL], [IDProduct], [QUANTITY]  FROM DBO.DETAILBILL AS DE WHERE IDBILL = " + idbill);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static List<DetailBillDTO> GetListProductByIDBill(int idBill)
        {
            List<DetailBillDTO> lstProduct = new List<DetailBillDTO>();
            string query = "SELECT [IDBILL], [IDProduct], [QUANTITY]  FROM DETAILBILL WHERE IDBILL = @idBill";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { idBill });
            foreach (DataRow item in data.Rows)
            {
                DetailBillDTO detail = new DetailBillDTO(item);
                lstProduct.Add(detail);
            }
            return lstProduct;
        }
    }
}
