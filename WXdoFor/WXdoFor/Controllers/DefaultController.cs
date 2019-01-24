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
            var list = new MyList();

            return list.userlist();
        }
    }
}