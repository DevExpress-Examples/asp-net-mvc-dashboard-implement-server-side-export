function onBeforeRender(sender) {
    var control = sender.getDashboardControl();
    control.registerExtension(new DevExpress.Dashboard.DashboardPanelExtension(control));
    $("#buttonContainer").dxButton({
        text: "Export to PDF",
        onClick: function (param) {
            var dashboardID = control.dashboardContainer().id;
            var dashboardStateJson = control.getDashboardState();

            $.ajax({
                url: 'Home/ExportDashboardToPdf',
                data: {
                    DashboardID: dashboardID,
                    DashboardState: dashboardStateJson
                },
                type: 'POST',
                success: function (result) {
                    DevExpress.ui.notify({ message: 'A dashboard was exported to ' + result, shading: true }, "success", 5000);
                }
            });
        }
    });
}