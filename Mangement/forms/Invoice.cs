using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management.forms
{
    public partial class Invoice : Form
    {
        public Invoice(string invoiceNumber)
        {
            InitializeComponent();
            CenterToScreen();
            var adapter = new DataSet1TableAdapters.DataTable1TableAdapter();
            adapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["SyncDB"].ToString();
            var table = new DataSet1.DataTable1DataTable();
            adapter.FillByInvoiceNumber(table, invoiceNumber);
            var newDataSource = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(newDataSource);
            ReportParameter[] parameters = new ReportParameter[13];
            using (var context = new ManagementDbEntities())
            {
                double totalAmount;
                totalAmount = 0;
                var StockOutRecords = context.StockOutRecords.Where(r => r.InvoiceNumber == invoiceNumber).ToList();
                foreach (var record in StockOutRecords)
                {
                    totalAmount += record.ProductTotalAmount.GetValueOrDefault();
                }
                var firstRecord = StockOutRecords.FirstOrDefault();
                var currentUser = context.Users.FirstOrDefault();
                parameters[0] = new ReportParameter("CustomerName", firstRecord.CustomerName);
                parameters[1] = new ReportParameter("CustomerContactPerson", firstRecord.CustomerContactPerson);
                parameters[2] = new ReportParameter("CustomerContactNumber", firstRecord.CustomerContact);
                parameters[3] = new ReportParameter("CustomerAddress", firstRecord.CustomerAddress);
                parameters[4] = new ReportParameter("InvoiceDate", firstRecord.Date.GetValueOrDefault().ToString("yyyy-MM-dd"));
                parameters[5] = new ReportParameter("Amount", totalAmount.ToString());
                parameters[6] = new ReportParameter("InvoiceNumber", firstRecord.InvoiceNumber);
                parameters[7] = new ReportParameter("CapitalAmount", GetCapitalAmount(totalAmount));
                parameters[8] = new ReportParameter("CompanyName", currentUser.CompanyName);
                parameters[9] = new ReportParameter("CompanyAddress", currentUser.CompanyAddress);
                parameters[10] = new ReportParameter("CompanyTel", currentUser.CompanyContact);
                parameters[11] = new ReportParameter("CompanyFax", currentUser.CompanyFax);
                parameters[12] = new ReportParameter("MadeBy", currentUser.InvoiceCreator);
            }
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private string GetCapitalAmount(double Amount)
        {
            var s = Amount.ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A");
            var d = Regex.Replace(s, @"((?<=-|^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))", "${b}${z}");
            var r = Regex.Replace(d, ".", m => "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰"[m.Value[0] - '-'].ToString());
            if (Amount.ToString().IndexOf('.') < 0)
            {
                r = r + "整";
            }
            return r;
        }
    }
}
