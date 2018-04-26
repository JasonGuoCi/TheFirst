using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace JProject.Mvc.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData(int limit, int offset)
        {
            //var data = new List<object>(){new { ID=1, Name="Arbet", Sex="男"},
            //    new { ID= 2, Name="Arbet1", Sex="女" },
            //    new {ID=3, Name="Arbet2",Sex="男" },
            //    new {ID=4, Name="Arbet3",Sex="女" },
            //    new {ID=5, Name="Arbet4",Sex="男" },
            //    new {ID=6, Name="Arbet5",Sex="男" },
            //    new {ID=7, Name="Arbet6",Sex="女" },
            //    new {ID=8, Name="Arbet7",Sex="男" },
            //    new { ID=9, Name="Arbet1", Sex="女" },
            //    new {ID=10, Name="Arbet2",Sex="男" },
            //    new {ID=11, Name="Arbet3",Sex="女" },
            //    new {ID=12, Name="Arbet4",Sex="男" },
            //    new {ID=13, Name="Arbet5",Sex="男" },
            //    new {ID=14, Name="Arbet6",Sex="女" },
            //    new {ID=15, Name="Arbet7",Sex="男" }
            //};

            TableSvc.ListSvcClient tableSvc = new TableSvc.ListSvcClient();
            //tableSvc.Endpoint.Address = new EndpointAddress(new Uri("http://172.24.21.135:520/JProject.ServicesTest.ListSvc.svc"));
            List<object> data = tableSvc.getJsonMsg().ToList();

            var total = data.Count();
            var rows = data.Skip(offset).Take(limit).ToList();
            return Json(new { total = total, rows = rows }, JsonRequestBehavior.AllowGet);
        }
    }
}