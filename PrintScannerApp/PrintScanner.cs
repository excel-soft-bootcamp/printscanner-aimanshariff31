using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerApp
{
    class PrintScanner
    {
        IPrint print;
        IScan scan;

        public PrintScanner(IPrint print, IScan scan)
        {
            this.print = print;
            this.scan = scan;

        }
        public void PrintScan()
        {
            print.Print();
            scan.Scan();
        }

    }

}