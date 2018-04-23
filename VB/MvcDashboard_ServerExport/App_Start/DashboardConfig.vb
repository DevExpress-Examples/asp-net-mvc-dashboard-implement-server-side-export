Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc

Namespace MvcDashboard_ServerExport
    Public NotInheritable Class DashboardConfig

        Private Sub New()
        End Sub

        Public Shared Sub RegisterService(ByVal routes As RouteCollection)
            routes.MapDashboardRoute("dashboardControl")

            Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage)

        End Sub
    End Class
End Namespace