using System.Data;

namespace DTO
{
    public class DetailBillDTO
    {
        public DetailBillDTO(DataRow row)
        {
            IDbill = (int)row["IDBill"];
            IDProduct = (int)row["IDProduct"];
            Quantity = (int)row["Quantity"];
        }
        
        public int IDbill { get;set; }

        public int IDProduct { get; set; }

        public int Quantity { get; set; }
    }
}
