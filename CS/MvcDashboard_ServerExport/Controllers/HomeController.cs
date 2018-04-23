using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;
using System.IO;
using System.Web.Mvc;

namespace MvcDashboard_ServerExport.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public ActionResult ExportDashboardToPdf(string DashboardID, string DashboardState) {
            using (MemoryStream stream = new MemoryStream()) {
                string dashboardID = DashboardID;
                DashboardState dashboardState = new DashboardState();
                dashboardState.LoadFromJson(DashboardState);

                DashboardPdfExportOptions pdfOptions = new DashboardPdfExportOptions();
                pdfOptions.ExportFilters = true;
                pdfOptions.DashboardStatePosition = DashboardStateExportPosition.Below;

                string dateTimeNow = DateTime.Now.ToString("yyyyMMddHHmmss");
                string filePath = "~/App_Data/Export/" + dashboardID + "_" + dateTimeNow + ".pdf";
                ASPxDashboardExporter exporter = new ASPxDashboardExporter(DashboardConfigurator.Default);
                exporter.ExportToPdf(dashboardID, stream, new System.Drawing.Size(1024, 768), dashboardState, pdfOptions);
                SaveFile(stream, filePath);

                ContentResult result = new ContentResult();
                result.Content = filePath;
                return result;
            }
        }

        private void SaveFile(MemoryStream stream, string path) {
            var fileStream = System.IO.File.Create(Server.MapPath(path));
            stream.WriteTo(fileStream);
            fileStream.Close();
        }
    }
}