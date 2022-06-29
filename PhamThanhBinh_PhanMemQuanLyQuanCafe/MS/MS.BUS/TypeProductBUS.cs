using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public  class TypeProductBUS
    {
        public static List<TypeProductDTO> GetAllListTypeProduct()
        {
            return TypeProductDAO.GetAllListTypeProduct();
        }

        public static List<TypeProductDTO> GetListTypeProductWithStatusOne(int status)
        {
            return TypeProductDAO.GetListTypeProductWithStatusOne(status);
        }

        public static bool InsertTypeProduct(TypeProductDTO tydr)
        {
            return TypeProductDAO.InsertTypeProduct(tydr);
        }

        public static bool UpdateTypeProduct(TypeProductDTO tydr)
        {
            return TypeProductDAO.UpdateTypeProduct(tydr);
        }

        public static bool DeleteTypeProduct(TypeProductDTO tydr)
        {
            return TypeProductDAO.DeleteTypeProduct(tydr);
        }

        public static int GetIDTypeProductMax()
        {
            return TypeProductDAO.GetIDTypeProductMax();
        }
    }
}
