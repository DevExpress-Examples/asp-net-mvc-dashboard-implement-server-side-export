<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/MvcDashboard_ServerExport/Controllers/HomeController.cs)
* [DashboardExport.js](./CS/MvcDashboard_ServerExport/Scripts/DashboardExport.js)
<!-- default file list end -->

# Dashboard for MVC - How to implement server-side export

This example demonstrates how to export a dashboard displayed using the <a href="https://docs.devexpress.com/Dashboard/16977/Building-the-Designer-and-Viewer-Applications">ASP.NET MVC Dashboard extension</a> on the server side using the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.WebDashboardExporter">WebDashboardExporter</a> class. The following API is used:

* The <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.BeforeRender">ASPxClientDashboard.BeforeRender</a> event is handled to obtain the client-side <a href="https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl">DashboardControl</a> with the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.GetDashboardControl">ASPxClientDashboard.GetDashboardControl</a> method.
* The AJAX request is used to send the dashboard identifier and state to the server side. On the server side, these values are received as action method parameters and passed to the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.WebDashboardExporter.ExportToPdf.overloads">WebDashboardExporter.ExportToPdf</a> method.

## Documentation

- [Printing and Exporting](https://docs.devexpress.com/Dashboard/15181/common-features/printing-and-exporting)

## More Examples

- [Dashboard for Web Forms - How to Enable Export in Data Inspector](https://supportcenter.devexpress.com/ticket/details/t862387/aspxdashboard-how-to-enable-exporting-in-data-inspector)
- [Dashboard for Web Forms - How to export Web Dashboard into PDF with different filter values on different pages](https://supportcenter.devexpress.com/ticket/details/t511362/how-to-export-web-dashboard-into-pdf-with-different-filter-values-on-different-pages)
