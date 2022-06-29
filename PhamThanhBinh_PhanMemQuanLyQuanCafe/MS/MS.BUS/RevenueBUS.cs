using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class RevenueBUS
    {
        public static List<RevenueDTO> GetRevenueByMonth(int fromMonth, int fromYear, int toMonth, int toYear)
        {
            return RevenueDAO.GetRevenueByMonth(fromMonth, fromYear, toMonth, toYear);
        }
    }
}
