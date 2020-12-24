using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XingLongWeb.Models;

namespace XingLongWeb.Controllers
{
    public class HomeController : Controller
    {
        LittleBoxContent item = new LittleBoxContent();

        // GET: Home
        public ActionResult Index()
        {
            List<LittleBoxContent> list = new List<LittleBoxContent>()
            {
                new LittleBoxContent(){ Title="服務內容", ImageName="照片要用陣列處理" },
                new LittleBoxContent(){ Title="服務案例", ImageName="照片要用陣列處理" },
                new LittleBoxContent(){ Title="塔位銷售", ImageName="照片要用陣列處理" },
                new LittleBoxContent(){ Title="政府資訊", ImageName="照片要用陣列處理" },
            };
            ViewData["Severvice"] = list[0];
            ViewData["Case"] = list[1];
            ViewData["Tower"] = list[2];
            ViewData["Government"] = list[3];
            return View();
        }
       
    }
}