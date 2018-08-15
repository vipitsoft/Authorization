using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authorization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Authorization.Controllers
{
    public class BaseController : Controller
    {

        public string UserId
        {
            get
            {
                if(HttpContext.User !=null && HttpContext.User.Identity!=null && HttpContext.User.Identity.Name)
            };
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }
    }
}