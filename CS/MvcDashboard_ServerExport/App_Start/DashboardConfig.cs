using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using System.Web.Routing;

namespace MvcDashboard_ServerExport {
    public static class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute("dashboardControl");

            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage);          

        }
    }
}