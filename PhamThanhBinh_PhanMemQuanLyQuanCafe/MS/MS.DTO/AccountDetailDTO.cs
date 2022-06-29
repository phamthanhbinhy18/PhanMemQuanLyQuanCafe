using System;
using System.Data;

namespace DTO
{
    public class AccountDetailDTO
    {
        public int AccountID { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public double SalaryByCa { get; set; }

        public int Ca { get; set; }

        public double Total { get; set; }

        public string Name { get; set; }

        public string Telephone { get; set; }

        public string Address { get; set; }

        public string Note { get; set; }

        public AccountDetailDTO()
        {

        }

        public AccountDetailDTO(DataRow row)
        {
            var d = row["CA"];
            AccountID = row["ID"] == DBNull.Value ? 0 : (int)row["ID"];
            Month = row["MONTH"] == DBNull.Value ? 0 :  (int)row["MONTH"];
            Year = row["YEAR"] == DBNull.Value ? 0 :  (int)row["YEAR"];
            SalaryByCa = row["SALARY_BY_CA"] == DBNull.Value ? 0 :  (double)row["SALARY_BY_CA"];
            Ca = row["CA"] == DBNull.Value ? 0 :  (int)row["CA"];
            Total = row["TOTAL"] == DBNull.Value ? 0 :  (double)row["TOTAL"];

            Name =  row["Name"].ToString();
            Telephone =  row["Telephone"].ToString();
            Address = row["Address"].ToString();
            Note = row["NOTE"].ToString();
        }
    }
}
