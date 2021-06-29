using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerApp
{
    public class PrintManager : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Print in Action");
        }
    }
}