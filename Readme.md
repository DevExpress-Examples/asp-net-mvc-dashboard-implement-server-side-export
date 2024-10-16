<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579131/21.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590027)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# BI Dashboard for MVC - How to implement server-side export

This example demonstrates how to export a dashboard displayed using the <a href="https://docs.devexpress.com/Dashboard/16977/Building-the-Designer-and-Viewer-Applications">ASP.NET MVC Dashboard extension</a> on the server side using the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.WebDashboardExporter">WebDashboardExporter</a> class. The following API is used:

* The <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.BeforeRender">ASPxClientDashboard.BeforeRender</a> event is handled to obtain the client-side <a href="https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl">DashboardControl</a> with the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.Scripts.ASPxClientDashboard.GetDashboardControl">ASPxClientDashboard.GetDashboardControl</a> method.
* The AJAX request is used to send the dashboard identifier and state to the server side. On the server side, these values are received as action method parameters and passed to the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.WebDashboardExporter.ExportToPdf.overloads">WebDashboardExporter.ExportToPdf</a> method.

<!-- default file list -->
## Files to look at

* [HomeController.cs](./CS/MvcDashboard_ServerExport/Controllers/HomeController.cs)
* [DashboardExport.js](./CS/MvcDashboard_ServerExport/Scripts/DashboardExport.js)
<!-- default file list end -->

## Documentation

- [Printing and Exporting](https://docs.devexpress.com/Dashboard/15181/common-features/printing-and-exporting)

## More Examples

- [Dashboard for Web Forms - How to Enable Export in Data Inspector](https://supportcenter.devexpress.com/ticket/details/t862387/aspxdashboard-how-to-enable-exporting-in-data-inspector)
- [Dashboard for Web Forms - How to export Web Dashboard into PDF with different filter values on different pages](https://supportcenter.devexpress.com/ticket/details/t511362/how-to-export-web-dashboard-into-pdf-with-different-filter-values-on-different-pages)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-dashboard-implement-server-side-export&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-dashboard-implement-server-side-export&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
