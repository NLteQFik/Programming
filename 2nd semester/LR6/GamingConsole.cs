using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    internal class GamingConsole : ComputerEquipment
    {
        private int storage;
        private bool isProVersion;

        public int Storage
        {
            get { return storage; }
            set { storage = value; }
        }
        public bool IsProVersion
        {
            get { return isProVersion; }
            set { isProVersion = value; }
        }

        public GamingConsole() : base() 
        {
            storage = 0;
            isProVersion = false;
        }
        public GamingConsole (bool onPower, bool isProVersion, string modelNumber, int powerConsumption, (int, int) resolution, int storage) : base(onPower, modelNumber, powerConsumption, resolution)
        {
            this.storage = storage;
            this.isProVersion = isProVersion;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("This is console with charasteristics:");
            Console.WriteLine($"Model number: {modelNumber}");
            Console.WriteLine($"Storage: {storage} GB");
            Console.WriteLine($"Consumtion: {powerConsumption} W");
            Console.WriteLine($"Resolution: {resolution.Item1} X {resolution.Item2}");
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Is pro version? {(isProVersion ? "Yes" : "No")}");
        }

        public void ChangeStorage(int value)
        {
            Storage += value;
        }

        public void ChangeVersion(bool value)
        {
            IsProVersion = value;
        }
    }
}
