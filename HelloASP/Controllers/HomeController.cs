﻿using Microsoft.AspNetCore.Mvc;

namespace HelloASP.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            string userid = Request.Query["userid"];
            string age = Request.Query["age"];

            return "응답입니다." + userid + age;
        }

        public IActionResult Test() {

            return View(); // 사용자 요청에 대한 응답으로 ViewResult를 return
        }
    }
}
