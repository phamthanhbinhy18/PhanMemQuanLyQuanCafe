using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class MenuBUS
    {
        public static List<MenuDTO> GetListMenuByIDTable(int id)
        {
            return MenuDAO.GetListMenuByIDTable(id);
        }
        public static List<MenuDTO> GetListMenuByIDBill(int idBill)
        {
            return MenuDAO.GetListMenuByIDBill(idBill);
        }

        public static List<MenuDTO> GetReviewBill(int idBill)
        {
            return MenuDAO.GetReviewBill(idBill);
        }
        
    }
}
