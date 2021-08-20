using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ReportDocument crystalReport = new ReportDocument();
            crystalReport.Load(Server.MapPath("~/product.rpt"));
            CrystalReportViewer1.ReportSource = crystalReport;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ReportDocument crystalReport = new ReportDocument();
        crystalReport.Load(Server.MapPath("~/product.rpt"));

        crystalReport.ExportToHttpResponse(ExportFormatType.Excel, Response, true, "Crystal");
    }
}