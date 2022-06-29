using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class TableBUS
    {
        public static List<TableDTO> GetAllListTable()
        {
            return TableDAO.GetAllListTable();
        }
        public static int TabWidth = 110;
        public static int TabHeight = 90;
        public static void UpdateStatusTable(int status, int id)
        {
            TableDAO.UpdateStatusTable(status,id);
        }
        public static int GetStatusByIDTable(int id)
        {
            return TableDAO.GetStatusByIDTable(id);
        }
        public static List<TableDTO> GetListTableHaveStatusOne()
        {
            return TableDAO.GetListTableHaveStatusOne();
        }
        public static List<TableDTO> GetListTableDifferentID(int id)
        {
            return TableDAO.GetListTableDifferentID(id);
        }
        public static bool InsertTable(TableDTO tb)
        {
            return TableDAO.InsertTable(tb);
        }
        public static bool DeleteTable(TableDTO tb)
        {
            return TableDAO.DeleteTable(tb);
        }
    }
}
