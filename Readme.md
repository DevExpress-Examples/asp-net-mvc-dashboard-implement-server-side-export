<!-- default file list -->
*Files to look at*:

* [DashboardConfig.cs](./CS/MvcDashboard_ServerExport/App_Start/DashboardConfig.cs) (VB: [DashboardConfig.vb](./VB/MvcDashboard_ServerExport/App_Start/DashboardConfig.vb))
* [HomeController.cs](./CS/MvcDashboard_ServerExport/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcDashboard_ServerExport/Controllers/HomeController.vb))
* [Global.asax.cs](./CS/MvcDashboard_ServerExport/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_ServerExport/Global.asax.vb))
* [DashboardExport.js](./CS/MvcDashboard_ServerExport/Scripts/DashboardExport.js) (VB: [DashboardExport.js](./VB/MvcDashboard_ServerExport/Scripts/DashboardExport.js))
* [Index.cshtml](./CS/MvcDashboard_ServerExport/Views/Home/Index.cshtml)
* [_rootLayout.cshtml](./CS/MvcDashboard_ServerExport/Views/Shared/_rootLayout.cshtml)
<!-- default file list end -->
# ASP.NET MVC Dashboard - How to implement server-side export


This example demonstrates how to export a dashboard displayed using the <a href="https://documentation.devexpress.com/Dashboard/16977/Building-the-Designer-and-Viewer-Applications">ASP.NET MVC Dashboard extension</a> on the server side using the <a href="https://documentation.devexpress.com/Dashboard/clsDevExpressDashboardWebASPxDashboardExportertopic.aspx">ASPxDashboardExporter</a> class. The following API is used to implement this capability

* The <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.BeforeRender.event">ASPxClientDashboard.BeforeRender</a> event is handled to obtain the client-side <a href="https://documentation.devexpress.com/ClientDashboard/api/DevExpress.Dashboard.DashboardControl.html">DashboardControl</a> using the <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.GetDashboardControl.method">GetDashboardControl</a> method.
* The AJAX request is used to send the dashboard identifier and state to the server side. On the server side, these values are received as action method parameters and passed to the <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboardExporter.ExportToPdf.overloads">ASPxDashboardExporter.ExportToPdf</a> method.

<br/>


