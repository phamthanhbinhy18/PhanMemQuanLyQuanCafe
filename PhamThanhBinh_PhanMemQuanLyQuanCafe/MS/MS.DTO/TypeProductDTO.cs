using System.Data;

namespace DTO
{
    public class TypeProductDTO
    {
        public TypeProductDTO()
        {

        }
        public TypeProductDTO(int ID, string NameType, int Status)
        {
            this.ID = ID;
            this.Nametype = Nametype;
            this.Status = Status;
        }
        public TypeProductDTO(DataRow row)
        {
            ID = (int)row["ID"];
            Nametype = row["NameType"].ToString();
            Status = (int)row["Status"];
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string nametype;

        public string Nametype
        {
            get { return nametype; }
            set { nametype = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        
    }
}
