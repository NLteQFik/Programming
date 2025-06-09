using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    internal sealed class Printer : ComputerEquipment
    {
        private string printerType;
        private bool isColor;
        private int printingSpeed;
        private int inkLevel;

        public string PrinterType
        {
            get { return printerType; }
            set { printerType = value; }
        }
        public bool IsColor
        {
            get { return isColor; }
            set { isColor = value; }
        }
        public int PrintingSpeed
        {
            get { return printingSpeed; }
            set { printingSpeed = value; }
        }
        public int InkLevel
        {
            get { return inkLevel; }
            set { inkLevel = value; }
        }

        public Printer() : base()
        {
            printerType = string.Empty;
            isColor = true;
            printingSpeed = 0;
            inkLevel = 0;
        }
        public Printer(bool onPower, bool isColor, string modelNumber, int powerConsumption, (int, int) resolution, string printerType, int printingSpeed, int inkLevel) : base(onPower, modelNumber, powerConsumption, resolution)
        {
            this.printerType = printerType;
            this.isColor = isColor;
            this.printingSpeed = printingSpeed;
            this.inkLevel = inkLevel > 100 
                ? 100 
                : inkLevel;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("This is printer with charasteristics:");
            Console.WriteLine($"Model number: {modelNumber}");
            Console.WriteLine($"Type: {printerType}");
            Console.WriteLine($"Consumption: {powerConsumption} W");
            Console.WriteLine($"Resolution: {resolution.Item1} X {resolution.Item2}");
            Console.WriteLine($"Printing speed: {printingSpeed} pages per minute");
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Is Color? {(isColor ? "Yes" : "No")}");
            Console.WriteLine($"Ink level: {inkLevel}");
        }

        public void UpdateInkLevel()
        {    
            if (OnPower == true)
            {
                inkLevel -= 2;
                if (inkLevel < 0)
                    inkLevel = 0;
            }
        }

        public void UpdateInkLevel(int value)
        {
            InkLevel += value;
            if (InkLevel < 0) 
                InkLevel = 0;
            if (InkLevel > 100)
                InkLevel = 100;
        }
    }
}
