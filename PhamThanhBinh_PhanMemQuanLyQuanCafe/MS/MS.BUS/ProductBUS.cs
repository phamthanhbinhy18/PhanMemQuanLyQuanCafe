using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class ProductBUS
    {
        public static List<ProductDTO> GetListProductByIDTypeProduct(int id, int status)
        {
            return ProductDAO.GetListProductByIDTypeProduct(id, status);
        }

        public static List<ProductDTO> GetListProductByID(int id)
        {
            return ProductDAO.GetListProductByID(id);
        }
        public static List<ProductDTO> GetAllListProduct()
        {
            return ProductDAO.GetAllListProduct();
        }
        public static bool InsertProduct(ProductDTO sp)
        {
            return ProductDAO.InsertProduct(sp);
        }
        public static int GetIDProductMax()
        {
            return ProductDAO.GetIDProductMax();
        }
        public static bool DeleteProduct(ProductDTO sp)
        {
            return ProductDAO.DeleteProduct(sp);
        }
        public static bool UpdateProduct(ProductDTO sp)
        {
            return ProductDAO.UpdateProduct(sp);
        }
        public static int GetIDTypeProductByIDProduct(int id)
        {
            return ProductDAO.GetIDTypeProductByIDProduct(id);
        }
        public static List<ProductDTO> GeProductByName(string name)
        {
            return ProductDAO.GeProductByName(name);
        }
    }
}
