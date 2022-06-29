
using System.Data;

namespace DTO
{
    public class EmployeeHistoryDTO
    {
        public int AccountID { get; set; }

        public string Note { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public double SalaryByCa { get; set; }

        public double Ca { get; set; }

        public double Total { get; set; }

        public EmployeeHistoryDTO()
        {

        }

        public EmployeeHistoryDTO(DataRow row)
        {
            AccountID = (int)row["ACCOUNTID"];
            Month = (int)row["MONTH"];
            Year = (int)row["YEAR"];
            SalaryByCa = (double)row["SALARYBYCA"];
            Ca = (double)row["Ca"];
            Total = (double)row["TOTAL"];
            Note = row["Note"].ToString();
        }
    }
}
