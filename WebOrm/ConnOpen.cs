using SqlSugar;
using WebHelper.ConfigHelper;

namespace WebOrm
{
    public class ConnOpen
    {
        public static SqlSugarClient GetInstance()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = GetConfigValue.ConnSettings,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            });
            return db;
        }
    }
}
