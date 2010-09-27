using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.Office.Interop.Excel;

namespace ComTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new Application();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            e.Visible = true;
            Thread.Sleep(TimeSpan.FromSeconds(2));
            e.Workbooks.Add(Missing.Value);
            var sheet = (Worksheet) e.ActiveSheet;
            for (int x = 1; x < 10; x++) {
                for (int y = 1; y < 10; y++) {
                    sheet.Cells[x, y] = string.Format("x={0}, y={1}", x, y);
                    Thread.Sleep(TimeSpan.FromSeconds(0.1));
                }
            }
            Thread.Sleep(TimeSpan.FromSeconds(5));
            e.Quit();
        }
    }
}
