using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    internal class Laptop : ComputerEquipment
    {
        private string processor;
        private int ramSize;
        private int batteryCapacity;
        private int currentCharge;
        private bool onCharge;

        public string Processor
        {
            get { return processor; }
            set { processor = value; }
        }
        public int RamSize
        {
            get { return ramSize; }
            set { ramSize = value; }
        }
        public int BatteryCapacity
        {
            get { return batteryCapacity; }
            set { batteryCapacity = value; }
        }
        public int CurrentCharge
        {
            get { return currentCharge; }
            set { currentCharge = value; }
        }
        public bool OnCharge
        {
            get { return onCharge; }
            set { onCharge = value; }
        }

        public Laptop() : base()
        {
            processor = string.Empty;
            ramSize = 0;
            batteryCapacity = 0;
            currentCharge = 0;
            onCharge = false;
        }
        public Laptop(bool onPower, bool onCharge, string modelNumber, int powerConsumption, (int, int) resolution, string processor, int ramSize, int batteryCapacity, int currentCharge) : base(onPower, modelNumber, powerConsumption, resolution)
        {
            this.processor = processor;
            this.ramSize = ramSize;
            this.batteryCapacity = batteryCapacity;
            this.currentCharge = currentCharge <= batteryCapacity 
                                   ? currentCharge 
                                   : batteryCapacity;
            this.onCharge = onCharge;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("This is laptop with charasteristics:");
            Console.WriteLine($"Model number: {modelNumber}");
            Console.WriteLine($"Processor: {processor}");
            Console.WriteLine($"Consumtion: {powerConsumption} W");
            Console.WriteLine($"RAM size: {ramSize} GB");
            Console.WriteLine($"Battery: {batteryCapacity} MAh");
            Console.WriteLine($"Resolution: {resolution.Item1} X {resolution.Item2}");
        }

        public override void TurnOn()
        {
            if (!OnPower && (OnCharge || CurrentCharge > 0)) 
                {
                    OnPower = true; 
                }
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Is recharging? {(onCharge ? "Yes" : "No")}");
            Console.WriteLine($"Battery charge: {(100.0 * currentCharge / batteryCapacity)}");
        }

        public new int GetCurrentPowerConsumption()
        {
            return OnPower
                ? PowerConsumption
                : CurrentCharge > 0
                   ? 1
                   : 0;
        }

        public void UpdateCharge()
        {
            if (OnCharge)
            {
                CurrentCharge += 10;
            }
            else 
            {
                CurrentCharge -= 5; 
            }
        }

        public void UpdateCharge(int value)
        {
            CurrentCharge += value;
            if (CurrentCharge > BatteryCapacity)
                CurrentCharge = BatteryCapacity;
        }
    }
}
