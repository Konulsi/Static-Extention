﻿using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public bool Login(string username, string password)
        {
            if ( username == "Konul123" && password == "Konul1996")
              return true;
            return false;

        }
    }
}
