using System;
using System.IO;
using System.Windows.Forms;
using DataModel;
using Microsoft.Reporting.WebForms;

namespace ReportsApplication {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            //var f = new Form1();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            var lr =
                new LocalReport();

            string deviceInfo =
                "<DeviceInfo>" +
                "<SimplePageHeaders>True</SimplePageHeaders>" +
                "</DeviceInfo>";

            lr.ReportPath = @"Report1.rdlc";

            CustomerDb db = CustomerDb.Create();
            Customer cust = db.Customers[0];
            var ds1 = new ReportDataSource { DataSourceId = "DataModel_Customer" };
            lr.DataSources.Add(ds1);
            lr.DataSources.Add(new ReportDataSource("DataModel_Order"));


            string mimeType;
            string encoding;
            string fileNameExtension;
            string[] streams;
            Warning[] warnings;
            byte[] bytes = lr.Render("PDF", deviceInfo, 
                out mimeType,
                                     out encoding, out fileNameExtension,
                                     out streams,
                                     out warnings);

            using (var fs = new FileStream(@"Report.pdf", FileMode.Create)) {
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
        }
    }
}
