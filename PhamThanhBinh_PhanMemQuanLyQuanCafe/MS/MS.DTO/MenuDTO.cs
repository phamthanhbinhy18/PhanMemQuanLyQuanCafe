using System.Data;

namespace DTO
{
    public class MenuDTO
    {
        public MenuDTO(int ID,string NameProduct, int Quantity, double PriceBasic, int IDProduct, double TotalPrice = 0)
        {
            this.ID = ID;
            this.NameProduct = NameProduct;
            this.Quantity = Quantity;
            this.PriceBasic = PriceBasic;
            this.TotalPrice = TotalPrice;
            this.IdProduct = IDProduct;
          
        }

        public MenuDTO(DataRow row)
        {
            ID = (int)row["ID"];
            NameProduct = row["NameProducts"].ToString();
            Quantity = (int)row["Quantity"];
            PriceBasic = (double)row["PriceBasic"];
            TotalPrice = (double)row["TotalPrice"];
            IdProduct = (int)row["IDProduct"];
        }
      
        private int idProduct;

        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string nameProduct;

        public string NameProduct
        {
            get { return nameProduct; }
            set { nameProduct = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private double priceBasic;

        public double PriceBasic
        {
            get { return priceBasic; }
            set { priceBasic = value; }
        }
        private double totalPrice;

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
