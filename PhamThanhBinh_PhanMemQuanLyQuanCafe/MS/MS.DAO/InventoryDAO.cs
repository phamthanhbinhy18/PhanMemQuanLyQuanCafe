using DTO;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class InventoryDAO
    {
        public static List<InventoryDTO> GetInventoryByTimeNow(int month,int year)
        {
            List<InventoryDTO> List = new List<InventoryDTO>();
            string query = string.Format("SELECT * FROM INVENTORY e " +
                "WHERE MONTH(CREATEDATE) = {0}" +
                "AND YEAR(CREATEDATE) = {1}",month,year);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                InventoryDTO inven = new InventoryDTO(item);
                List.Add(inven);
            }
            return List;
        }

        public static bool Add(InventoryDTO ac)
        {
            string query = "EXEC [USP_INSERTEINVENTORY] @NAME , @NOTE , @PRICEBASE ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { ac.Name, ac.Note, ac.PriceBase }) == 1)
            {
                return true;
            }

            return false;
        }

        public static bool Update(InventoryDTO ac)
        {
            string query = "EXEC [USP_UPDATEINVENTORY] @ID , @NAME , @NOTE , @PRICEBASE ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { ac.ID ,ac.Name , ac.Note, ac.PriceBase }) == 1)
            {
                return true;
            }

            return false;
        }

        public static bool Delete(int idInventory)
        {
            string query = "DELETE FROM INVENTORY WHERE ID = @id ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { idInventory }) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
