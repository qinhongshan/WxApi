﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WXdoFor.Models;

namespace WXdoFor.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        [ActionName("getUserList")]
        public List<Models.User> GetUsers()
        {
            //雇员刚刚
            var list = new MyList();
           //急急急
            return list.userlist();
        }

        public int AddUser()
        {
            return 1;
        }

        public int AddUser()
        {
            return 8;
        }
        //liuqingyang 
    }
}