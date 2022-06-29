
using System;
using System.Data;

namespace DTO
{
    public class RevenueDTO
    {
        public int Month { get; set; }

        public int Year { get; set; }

        public double TotalBill { get; 
set; }
        public double TotalInventory { get; set; }

        public double TotalSalary { get; set; }

        public double TotalRevenue { get; set; }

        public RevenueDTO(DataRow row)
        {
            Month = row["MONTH"] == DBNull.Value ? 0 : (int)row["MONTH"];
            Year = row["YEAR"] == DBNull.Value ? 0 : (int)row["YEAR"];

            TotalBill = row["TOTALBILL"] == DBNull.Value ? 0 : (double)row["TOTALBILL"];
            TotalInventory = row["TOTALINVENTORY"] == DBNull.Value ? 0 : (double)row["TOTALINVENTORY"];
            TotalSalary = row["TOTALSALARY"] == DBNull.Value ? 0 : (double)row["TOTALSALARY"];
            TotalRevenue = row["TOTALREVENUE"] == DBNull.Value ? 0 : (double)row["TOTALREVENUE"];
        }
    }
}
