
using System;
using System.Data;

namespace DTO
{
    public class InventoryDTO
    {
        public int ID { get; set; }

        public double PriceBase { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Note { get; set; }
        
        public InventoryDTO()
        {

        }

        public InventoryDTO(DataRow row)
        {
            ID = (int)row["ID"];
            PriceBase = row["PriceBase"] == DBNull.Value ? 0 :(double)row["PriceBase"];
            CreatedDate = (DateTime)row["CREATEDATE"];
            Name = row["Name"].ToString();
            Note = row["Note"].ToString();
        }
    }
}
