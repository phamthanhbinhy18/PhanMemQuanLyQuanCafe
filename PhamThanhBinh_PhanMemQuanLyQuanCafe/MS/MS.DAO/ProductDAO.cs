using System;
using System.Collections.Generic;
using DTO;
using System.Data;

namespace DAO
{
    public class ProductDAO
    {
        public static List<ProductDTO> GetListProductByIDTypeProduct(int id,int status)
        {
            List<ProductDTO> listProduct = new List<ProductDTO>();
            string query;
            if (id == 0)
                query = "SELECT TOP 10 * FROM PRODUCT WHERE STATUS = " + status + " AND PRODUCT.IDTYPEDINK NOT IN (SELECT ID FROM TYPEPRODUCT WHERE STATUS = 0)";
            else
            {
                if(status == -1)
                    query = "select * from Product where IDTypeDink = " + id;
                else 
                query = "select * from Product where IDTypeDink = " + id + " and Status = " + status;
            }
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductDTO Product = new ProductDTO(item);
                listProduct.Add(Product);
            }
            return listProduct;
        }

        public static int GetIDTypeProductByIDProduct(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select d.IDTypeDink from dbo.Product as d where IDTypeDink = " + id);//chưa thanh toán
            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["IDTypeDink"].ToString());
            }
            return -1;
        }

        public static List<ProductDTO> GetAllListProduct()
        {
            List<ProductDTO> listProduct = new List<ProductDTO>();
            string query = "select * from Product";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductDTO Product = new ProductDTO(item);
                listProduct.Add(Product);
            }
            return listProduct;
        }

        public static List<ProductDTO> GetListProductByID(int id)
        {
            List<ProductDTO> listProduct = new List<ProductDTO>();
            string query = "select * from Product where ID = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductDTO Product = new ProductDTO(item);
                listProduct.Add(Product);
            }
            return listProduct;
        }

        public static bool InsertProduct(ProductDTO sp)
        {
            
            string query = "Exec USP_InsertProduct @name , @pricebasic , @saleprice , @status , @idtype ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { sp.NameProducts, sp.PriceBasic, sp.SalePrice, sp.Status, sp.IDTypeProduct }) == 1)
            {
                return true;
            }
            return false ;
        }

        public static bool UpdateProduct(ProductDTO sp)
        {

            string query = "Exec USP_UpdateProduct @id , @name , @pricebasic , @saleprice , @status , @idtype ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { sp.ID, sp.NameProducts, sp.PriceBasic, sp.SalePrice, sp.Status, sp.IDTypeProduct }) == 1)
            {
                return true;
            }
            return false;
        }

        public static int GetIDProductMax()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetIDProduct");
            if (data.Rows.Count > 0)
            {
                    return  Convert.ToInt32(data.Rows[0]["ID"].ToString()) + 1;
            }
            return 1;
        }

        public static bool DeleteProduct(ProductDTO sp)
        {

            string query = "Exec USP_DeleteByProduct @id ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { sp.ID }) == -1)
            {
                return false;
            }
            return true;
        }
        public static List<ProductDTO> GeProductByName(string name)
        {
            List<ProductDTO> listProduct = new List<ProductDTO>();
            string query = String.Format("SELECT * FROM dbo.Product WHERE dbo.fChuyenCoDauThanhKhongDau(NameProducts) LIKE N'%' + dbo.fChuyenCoDauThanhKhongDau(N'{0}') + '%' and Product.IDTypeDink NOT IN (select ID from TYPEProduct where Status = 0)", name);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductDTO Product = new ProductDTO(item);
                listProduct.Add(Product);
            }
            return listProduct;
        }
    }
}
