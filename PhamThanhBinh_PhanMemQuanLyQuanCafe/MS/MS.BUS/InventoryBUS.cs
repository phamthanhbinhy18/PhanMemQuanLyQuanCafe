using DAO;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class InventoryBUS
    {
        public static List<InventoryDTO> GetInventoryByTimeNow()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            return InventoryDAO.GetInventoryByTimeNow(month, year);
        }

        public static bool Add(InventoryDTO invent)
        {
            return InventoryDAO.Add(invent);
        }

        public static bool Update(InventoryDTO invent)
        {
            return InventoryDAO.Update(invent);
        }

        public static bool Delete(int idInventory)
        {
            return InventoryDAO.Delete(idInventory);
        }
    }
}
