using System;
using System.Collections.Generic;
using DTO;
using System.Data;

namespace DAO
{
    public class TypeProductDAO
    {
        public static List<TypeProductDTO> GetListTypeProductWithStatusOne(int status)
        {
            List<TypeProductDTO> listtype = new List<TypeProductDTO>();// 0 ẩn , 1 hiện
            string query = "select * from TYPEProduct where Status = " + status;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                TypeProductDTO type = new TypeProductDTO(item);
                listtype.Add(type);
            }
            return listtype;
        }

        public static List<TypeProductDTO> GetAllListTypeProduct()
        {
            List<TypeProductDTO> listtypeProduct = new List<TypeProductDTO>();
            string query = "select * from TYPEProduct";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TypeProductDTO typeProduct = new TypeProductDTO(item);
                listtypeProduct.Add(typeProduct);
            }
            return listtypeProduct;
        }

        public static bool InsertTypeProduct(TypeProductDTO tydr)
        {
            string query = "Exec USP_InsertTypeProduct @nametype , @status ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { tydr.Nametype, tydr.Status }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateTypeProduct(TypeProductDTO tydr)
        {
            string query = "Exec USP_UpdateTypeProduct @id , @nametype , @status ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { tydr.ID, tydr.Nametype, tydr.Status }) == 1)
            {
                return true;
            }
            else
                return false;
        }

        public static bool DeleteTypeProduct(TypeProductDTO tydr)
        {
            string query = "Exec USP_DeleteTypeProduct @id";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { tydr.ID }) == 1)
            {
                return true;
            }
            return false;
        }

        public static int GetIDTypeProductMax()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetIDTypeProduct");//chưa thanh toán
            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["ID"].ToString()) + 1;
            }
            return -1;
        }
        
    }
}
