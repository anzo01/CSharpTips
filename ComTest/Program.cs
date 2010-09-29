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
        private static void Sleep(double seconds) {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }
        static void Main(string[] args)
        {
            var e = new Application();

            Sleep(2);
            
            e.Visible = true;
            
            Sleep(2);
            
            e.Workbooks.Add(Missing.Value);
            var sheet = (Worksheet) e.ActiveSheet;
            
            for (int x = 1; x < 10; x++) {
                for (int y = 1; y < 10; y++) {
                    sheet.Cells[x, y] = string.Format("x={0}, y={1}", x, y);
                    Sleep(0.1);
                }
            }
            
            Sleep(2);
            e.Quit();
        }
    }
}
