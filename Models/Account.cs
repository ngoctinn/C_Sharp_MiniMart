using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public string staffID { get; set; }
        public int permission { get; set; }
        public bool status { get; set; }

        public Account()
        {
            
        }
        public Account(string username, string password, string staffID, int permission, bool status)
        {
            this.username = username;
            this.password = password;
            this.staffID = staffID;
            this.permission = permission;
            this.status = status;
        }
       
        


    }

}
