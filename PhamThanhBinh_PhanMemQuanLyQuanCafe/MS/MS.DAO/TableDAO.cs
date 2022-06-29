using DTO;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class TableDAO
    {
        public static List<TableDTO> GetAllListTable()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            DataTable resuft = DataProvider.Instance.ExcuteQuery("Select * from TABLEProduct");
            foreach (DataRow item in resuft.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public static void UpdateStatusTable(int status, int id)
        {
            string query = "USP_UpdateStatusTable  @status , @idtable ";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { id ,status});
            
        }
        public static int GetStatusByIDTable(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.TABLEProduct as t where ID = "+ id);
            if (data.Rows.Count > 0)
            {
                TableDTO table = new TableDTO(data.Rows[0]);
                return table.Status;
            }
            return -1;
        }
        public static List<TableDTO> GetListTableHaveStatusOne()
        {
            List<TableDTO> tablelist = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.TABLEProduct where Status = 1");
            foreach(DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tablelist.Add(table);
            }
            return tablelist;
        }

        public static List<TableDTO> GetListTableDifferentID(int id)
        {
            List<TableDTO> tableList = new List<TableDTO>();
            DataTable resuft = DataProvider.Instance.ExcuteQuery("Select * from TABLEProduct where ID != @id ", new object[] { id });
            foreach (DataRow item in resuft.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
        
        public static bool InsertTable(TableDTO tb)
        {
            string query = "Exec USP_InsertTable @nametable , @status ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { tb.NameTable, tb.Status }) == 1)
            {
                return true;
            }
            return false;
        }
        public static bool DeleteTable(TableDTO tb)
        {
            string query = "Exec USP_DeleteTable @idtable";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { tb.ID }) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
