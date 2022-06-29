using System.Data;

namespace DTO
{
    public class AccountDTO
    {
        public AccountDTO()
        {

        }

        public AccountDTO(DataRow row)
        {
            ID = (int)row["ID"];
            PassWord = row["Pass"].ToString();
            Name = row["Name"].ToString();
            PassPort = row["PassPort"].ToString();
            PlaceOfBirth= row["PlaceOfBirth"].ToString();
            Telephone = row["Telephone"].ToString();
            Address = row["Address"].ToString();
            Right = (int)row["Rights"];
            Status = (int)row["Status"];
            SalaryByCa = (double)row["SALARY_BY_CA"];
        }

        public double SalaryByCa { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }
        
        public string PassPort { get; set; }

        public string PassWord { get; set; }

        public string PlaceOfBirth { get; set; }

        public string Telephone { get; set; }

        public string Address { get; set; }

        public int Right { get; set; }

        public int Status { get; set; }
    }
}
