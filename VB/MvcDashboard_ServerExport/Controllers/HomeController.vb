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

		<HttpPost>
		Public Function ExportDashboardToPdf(ByVal DashboardID As String, ByVal DashboardState As String) As ActionResult
			Using stream As New MemoryStream()
				Dim dbID As String = DashboardID
				Dim dbState As New DashboardState()

				dbState.LoadFromJson(DashboardState)
				Dim pdfOptions As New DashboardPdfExportOptions()
				pdfOptions.ExportFilters = True
				pdfOptions.DashboardStatePosition = DashboardStateExportPosition.Below
				Dim dateTimeNow As String = Date.Now.ToString("yyyyMMddHHmmss")
				Dim serverPath As String = Server.MapPath("~/App_Data/Export")
				If Not Directory.Exists(serverPath) Then
					Directory.CreateDirectory(serverPath)
				End If
				Dim filePath As String = Path.Combine(serverPath, dbID)
				Dim uniqueId As String = "_" & dateTimeNow & ".pdf"
				Dim exporter = New WebDashboardExporter(DashboardConfigurator.Default)
				exporter.ExportToPdf(dbID, stream, New System.Drawing.Size(1024, 768), dbState, pdfOptions)
				SaveFile(stream, filePath & uniqueId)
				Dim result As New ContentResult()
				result.Content = filePath & uniqueId
				Return result
			End Using
		End Function

		Private Sub SaveFile(ByVal stream As MemoryStream, ByVal path As String)
			Dim fileStream = System.IO.File.Create(path)
			stream.WriteTo(fileStream)
            fileStream.Close()
        End Sub
    End Class
End Namespace