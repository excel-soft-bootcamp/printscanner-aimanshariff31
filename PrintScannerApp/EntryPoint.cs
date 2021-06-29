using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintManager _printmanager = new PrintManager();
            ScanManager _scanmanager = new ScanManager();
            PrintScanner printscan = new PrintScanner(_printmanager, _scanmanager);
            printscan.PrintScan();
        }
    }
}
