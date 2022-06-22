using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testMVC.Models;

namespace testMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.abc = "abc";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DataTable()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxPostCall(MapModel mapdata)
        {
            MapModel map = new MapModel
            {
                Province = mapdata.Province,
                Ward = mapdata.Ward,
                soHieuToBanDo = mapdata.soHieuToBanDo,
                soThuTuThua = mapdata.soThuTuThua
            };

            if (map.soHieuToBanDo == 1 && map.Province == "tanphu" && map.Ward == "tanphu" && map.soThuTuThua == 25)
            {
                MapModel data = new MapModel
                {
                    soThuTuThua = 25,
                    soHieuToBanDo = 1,
                    maXa = "29461",
                    maLoaiDat = "DT+CLN",
                    dienTich = 927.3,
                    trangThaiDangKy = 2,
                    geo = "{\"type\"=\"Polygon\",\"coordinates\"=[[[106.257124560784,9.698294686187],[106.257145796504,9.69829608588],[106.257144226527,9.698164990785],[106.257335166298,9.698177859603],[106.257334933308,9.698155256919],[106.257195941108,9.698144714483],[106.257198229434,9.698108634719],[106.257334487622,9.698119092784],[106.257332248036,9.69793329943],[106.257354445343,9.697713547278],[106.257180448209,9.697738071923],[106.257124560784,9.698294686187]]]}"
                };

                return Json(data, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return null;
            }
        }
        [ChildActionOnly]
        public PartialViewResult Result()
        {
            return PartialView("Result");
        }

    }
}