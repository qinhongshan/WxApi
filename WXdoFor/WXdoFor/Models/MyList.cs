using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WXdoFor.Models
{
    public class MyList
    {
        public List<Models.User> userlist()
        {
            return new List<Models.User>() {
                new Models.User(){ ID=1,Name="秦红山"},
                new Models.User(){ ID=2,Name="田思琪"},
                new Models.User(){ ID=3,Name="水嘉毅"}
            };
        }
    }
}