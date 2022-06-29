using DTO;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class RevenueDAO
    {
        public static List<RevenueDTO> GetRevenueByMonth(int fromMonth, int fromYear, int toMonth, int toYear)
        {
            List<RevenueDTO> List = new List<RevenueDTO>();

            string query = " EXEC [dbo].[USP_GETREVENUEBYMONTH] @FROMMONTH , @FROMYEAR , @TOMONTH , @TOYEAR ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query,new object[] { fromMonth, fromYear, toMonth, toYear });
            foreach (DataRow item in data.Rows)
            {
                RevenueDTO rev = new RevenueDTO(item);
                List.Add(rev);
            }
            return List;
        }
    }
}
