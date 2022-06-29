using System;
using System.Data;

namespace DTO
{
    public class BillUpDTO : BillDTO
    {
        public double PromotionPrice { get; set; }

        public double CustomerPrice { get; set; }

        public double OutPrice { get; set; }

        public double Revenue { get; set; }

        public string TableName { get; set; }

        public BillUpDTO(DataRow row) : base(row)
        {
            PromotionPrice = (double)row["PROMOTIONPRICE"];
            CustomerPrice = (double)row["CUSTOMERPRICE"];
            OutPrice = (double)row["OUTPRICE"];
            Revenue = (double)row["REVENUE"];
            TableName = row["NAMETABLE"] == DBNull.Value ? "" : row["NAMETABLE"].ToString();
        }
    }
    public class BillDTO
    {
        public BillDTO(int id, DateTime createDay, double total,int idtable,int employ, int status)
        {
            this.ID = id;
            CreateDay = createDay;
            Total = total;
            Idtable = idtable;
            Employ = employ;
            Status = status;
        }
        public BillDTO (DataRow row)
        {
            ID = (int)row["ID"];
            CreateDay = Convert.ToDateTime(row["CreateDay"]);
            Total = (double)row["TotalBill"];
            Idtable = (int)row["IDTable"];
            Employ = (int)row["Employ"];
            Status = (int)row["Status"];
        }

        public int Idtable { get; set; }

        public double Total { get; set; }

        public DateTime CreateDay { get; set; }

        public int ID { get; set; }

        public int Employ { get; set; }

        public int Status { get; set; }
    }
}
