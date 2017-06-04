using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimexDAL.Model
{
    public class DbParameter
    {
        public string dataSource { get; set; }
        public string initialCatalog { get; set; }
        public bool IntegratedSecurity { get; set; }
        public string dbUserId { get; set; }
        public string dbPassword { get; set; }

        public DbParameter getParam()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.dataSource))
                setDefaultParam();
            dataSource = Properties.Settings.Default.dataSource;
            initialCatalog = Properties.Settings.Default.initialCatalog;
            IntegratedSecurity = Properties.Settings.Default.IntegratedSecurity;
            dbUserId = Properties.Settings.Default.dbUserId;
            dbPassword = Properties.Settings.Default.dbPassword;

            return this;
        }
        private void setDefaultParam()
        {
            Properties.Settings.Default.dataSource = "(LocalDb)\\v11.0";
            Properties.Settings.Default.initialCatalog = "AlimexQUESTIONS";
            Properties.Settings.Default.IntegratedSecurity = true;
            Properties.Settings.Default.Save();
        }
        public void setParam()
        {
            Properties.Settings.Default.dataSource = dataSource;
            Properties.Settings.Default.initialCatalog = initialCatalog;
            Properties.Settings.Default.IntegratedSecurity = IntegratedSecurity;
            Properties.Settings.Default.dbUserId=dbUserId;
            Properties.Settings.Default.dbPassword=dbPassword;
            Properties.Settings.Default.Save();
        }

    }
}
