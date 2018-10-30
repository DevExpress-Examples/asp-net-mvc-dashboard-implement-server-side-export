Imports System.IO
Imports System.Web.Mvc
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Namespace MvcDashboard_ServerExport.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View()
        End Function

        <HttpPost> _
        Public Function ExportDashboardToPdf(ByVal DashboardID As String, ByVal DashboardState As String) As ActionResult
            Using stream As New MemoryStream()

                Dim dashboardID_Renamed As String = DashboardID

                Dim dashboardState_Renamed As New DashboardState()
                dashboardState_Renamed.LoadFromJson(DashboardState)

                Dim pdfOptions As New DashboardPdfExportOptions()
                pdfOptions.ExportFilters = True
                pdfOptions.DashboardStatePosition = DashboardStateExportPosition.Below

                Dim dateTimeNow As String = Date.Now.ToString("yyyyMMddHHmmss")
                Dim filePath As String = "~/App_Data/Export/" & dashboardID_Renamed & "_" & dateTimeNow & ".pdf"
                Dim exporter As New WebDashboardExporter(DashboardConfigurator.Default)
                exporter.ExportToPdf(dashboardID_Renamed, stream, New System.Drawing.Size(1024, 768), dashboardState_Renamed, pdfOptions)
                SaveFile(stream, filePath)

                Dim result As New ContentResult()
                result.Content = filePath
                Return result
            End Using
        End Function

        Private Sub SaveFile(ByVal stream As MemoryStream, ByVal path As String)
            Dim fileStream = System.IO.File.Create(Server.MapPath(path))
            stream.WriteTo(fileStream)
            fileStream.Close()
        End Sub
    End Class
End Namespace