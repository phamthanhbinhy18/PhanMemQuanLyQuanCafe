using System;
using System.Collections.Generic;
using DTO;
using System.Data;

namespace DAO
{
    public class AccountDAO
    {
        private const string _password_default = "1234567";

        public static bool IsLogin(int username, string password)
        {
            string query = "SELECT [SALARY_BY_CA],[ID],[PASS],[NAME],[PASSPORT],[PLACEOFBIRTH],[TELEPHONE],[ADDRESS],[RIGHTS],[STATUS] FROM DBO.ACCOUNT WHERE ID = @user and Pass = @pass ";
            DataTable resuft = DataProvider.Instance.ExcuteQuery(query, new object[] { username, password });
            return resuft.Rows.Count > 0;
        }

        public static int GetRightByAccount(int user)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT AC.RIGHTS FROM DBO.ACCOUNT AS AC WHERE ID = @user ", new object[] { user });//chưa thanh toán
            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["Rights"].ToString());
            }
            return -1;
        }

        public static string GetNameByAccount(int user)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT AC.NAME FROM DBO.ACCOUNT AS AC WHERE ID = @user ", new object[] { user });//chưa thanh toán
            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["Name"].ToString();
            }
            return "Chưa có nhân viên";
        }

        public static List<AccountDTO> GetListAccountOnStatus(int status)
        {
            List<AccountDTO> listaccount = new List<AccountDTO>();
            string query = "SELECT [SALARY_BY_CA],[ID],[PASS],[NAME],[PASSPORT],[PLACEOFBIRTH],[TELEPHONE],[ADDRESS],[RIGHTS],[STATUS] FROM ACCOUNT WHERE RIGHTS IN (0,1) AND STATUS = " + status;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                listaccount.Add(account);
            }
            return listaccount;
        }

        public static List<AccountDTO> GetAllListAccount()
        {
            List<AccountDTO> listaccount = new List<AccountDTO>();
            string query = "SELECT [SALARY_BY_CA],[ID],[PASS],[NAME],[PASSPORT],[PLACEOFBIRTH],[TELEPHONE],[ADDRESS],[RIGHTS],[STATUS] FROM ACCOUNT";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                listaccount.Add(account);
            }
            return listaccount;
        }

        public static AccountDTO GetAccount(int user)
        {
            string query = "SELECT [SALARY_BY_CA],[ID],[PASS],[NAME],[PASSPORT],[PLACEOFBIRTH],[TELEPHONE],[ADDRESS],[RIGHTS],[STATUS] FROM ACCOUNT WHERE  ID = @user ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { user });

            if (data.Rows.Count > 0)
            {
                return new AccountDTO(data.Rows[0]);
            }
            return null;
        }

        public static bool InsertAccount(AccountDTO ac)
        {
            string query = "EXEC USP_INSERTACCOUNT @pass , @name , @passport , @placeofbirth , @telephone , @address , @right , @status , @salary_by_ca ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { ac.PassWord, ac.Name, ac.PassPort, ac.PlaceOfBirth, ac.Telephone, ac.Address, ac.Right, ac.Status , ac.SalaryByCa }) == 1)
            {
                return true;
            }

            return false;
        }

        public static bool UpdateAccount(AccountDTO ac)
        {
            string query = "EXEC USP_UPDATEACCOUNT @user , @pass , @name , @place , @telephone , @address , @right , @status  , @passport , @salary_by_ca ";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { ac.ID, ac.PassWord, ac.Name, ac.PlaceOfBirth, ac.Telephone, ac.Address, ac.Right, ac.Status, ac.PassPort, ac.SalaryByCa }) == 1)
            {
                return true;
            }

            return false;
        }

        public static bool ResetAccount(int user)
        {
            string query = String.Format("UPDATE DBO.ACCOUNT SET PASS = {0} WHERE ID = @username ", _password_default);
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { user }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteAccount(AccountDTO ac)
        {
            string query = "EXEC USP_DELETEACCOUNT @user";
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { ac.ID }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool IsExistAccount(int user)
        {
            string query = "EXEC USP_GETUSERNAME @user ";//chưa thanh toán
            if (DataProvider.Instance.ExcuteNonQuery(query, new object[] { user }) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
