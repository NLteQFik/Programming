using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LR6
{
    internal abstract class ComputerEquipment
    {
        protected bool onPower;
        protected string modelNumber;
        protected int powerConsumption;
        protected (int, int) resolution;
        public bool OnPower
        {
            get { return onPower; }
            set { onPower = value; }
        }
        public string ModelNumber
        {
            get { return modelNumber; }
            set { modelNumber = value; }
        }
        public int PowerConsumption
        {
            get { return powerConsumption; }
            set { powerConsumption = value; }
        }
        public (int, int) Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }

        public ComputerEquipment()
        {
            onPower = false;
            modelNumber = String.Empty;
            powerConsumption = 0;
            resolution = (0, 0);
        }
        public ComputerEquipment(bool onPower, string modelNumber, int powerConsumption, (int, int) resolution)
        {
            this.onPower = onPower;
            this.modelNumber = modelNumber;
            this.powerConsumption = powerConsumption;
            this.resolution = resolution;
        }

        public abstract void DisplayInfo();

        public virtual void TurnOn()
        {
            if (!OnPower)
            {
                OnPower = true;
            }
        }
        public void TurnOff()
        {
            if (OnPower)
            {
                OnPower = false;
            }
        }

        public int GetCurrentPowerConsumption()
        {
            return OnPower
                ? PowerConsumption
                : 0;
        }

        public int GetSize()
        {
            return Resolution.Item1 * Resolution.Item2;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine("Device status:");
            Console.WriteLine($"Is working? {(OnPower ? "Yes" : "No")}");
        }
    }
}
