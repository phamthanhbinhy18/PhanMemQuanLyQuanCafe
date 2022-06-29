using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class AccountBUS
    {
        public static bool IsLogin(int id, string password)
        {
            return AccountDAO.IsLogin(id,password);
        }
        public static List<AccountDTO> GetAllListAccount()
        {
            return AccountDAO.GetAllListAccount();
        }

        public static List<AccountDTO> GetListAccountOnStatus(int status)
        {
            return AccountDAO.GetListAccountOnStatus(status);
        }
        public static bool InsertAccount(AccountDTO ac)
        {
            return AccountDAO.InsertAccount(ac);
        }
        public static bool UpdateAccount(AccountDTO ac)
        {
            return AccountDAO.UpdateAccount(ac);
        }
        public static bool DeleteAccount(AccountDTO ac)
        {
            return AccountDAO.DeleteAccount(ac);
        }
        public static bool IsExistAccount(int id)
        {
            return AccountDAO.IsExistAccount(id);
        }
        public static bool ResetAccount(int user)
        {
            return AccountDAO.ResetAccount(user);
        }
        public static int GetRightByAccount(int user)
        {
            return AccountDAO.GetRightByAccount(user);
        }
        public static string GetNameByAccount(int user)
        {
            return AccountDAO.GetNameByAccount(user);
        }

        public static AccountDTO GetAccount(int user)
        {
            return AccountDAO.GetAccount(user);
        }
    }
}
