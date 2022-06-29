using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class EmployeeHistoryBUS
    {
        public static List<AccountDetailDTO> GetEmployeeByMonth(int month, int year, bool salaried = false)
        {
            return EmployeeHistoryDAO.GetEmployeeByMonth(month, year, salaried);
        }

        public static bool Add(EmployeeHistoryDTO employee)
        {
            return EmployeeHistoryDAO.Add(employee);
        }

        public static bool Update(EmployeeHistoryDTO employee)
        {
            return EmployeeHistoryDAO.Update(employee);
        }
    }
}
