using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using testclient1.smarteboka.com.Models;

namespace testclient1.smarteboka.com.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LogOut()
        {
            return new SignOutResult(new string[] { "oidc", "Cookies" });
        }
    }
}
