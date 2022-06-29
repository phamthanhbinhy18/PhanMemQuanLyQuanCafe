using System.Data;

namespace DTO
{
    public class ProductDTO
    {
        public ProductDTO()
        {
           
        }
        public ProductDTO(int ID, string NameProducts, double PriceBasic, double SalePrice, int Status, int IDTypeProduct)
        {
            this.ID = ID;
            this.NameProducts = NameProducts;
            this.PriceBasic = PriceBasic;
            this.SalePrice = SalePrice;
            this.Status = Status;
            this.IDTypeProduct = IDTypeProduct;
        }

        public ProductDTO(DataRow row)
        {
            ID = (int)row["ID"];
            NameProducts = row["NameProducts"].ToString();
            PriceBasic = (double)row["PriceBasic"];
            SalePrice = (double)row["SalePrice"];
            Status = (int)row["Status"];
            IDTypeProduct = (int)row["IDTypeDink"];
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string nameProducts;

        public string NameProducts
        {
            get { return nameProducts; }
            set { nameProducts = value; }
        }
        private double priceBasic;

        public double PriceBasic
        {
            get { return priceBasic; }
            set { priceBasic = value; }
        }
        private double salePrice;

        public double SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private int iDTypeProduct;

        public int IDTypeProduct
        {
            get { return iDTypeProduct; }
            set { iDTypeProduct = value; }
        }
    }
}
