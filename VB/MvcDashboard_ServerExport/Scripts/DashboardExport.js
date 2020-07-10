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
                dataType: 'json',
                success: function (result) {
                    DevExpress.ui.notify('A dashboard was exported to ' + result, 'success', 5000);
                }
            });
        }
    });
}