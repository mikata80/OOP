using System;

class LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string graphicscard;
        private double screensize;
        private double price;
        private Battery bat;

        public Laptop(string model, string manufacturer, string processor, string graphicscard, Battery bat, double screensize = 0.00, double price = 0.00)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Graphicscard = graphicscard;
            this.bat = bat;
            this.ScreenSize = screensize;
            this.Price = price;
            //this.CheckString = manufacturer;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be empty!");
                }
                this.model = value;

            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer cannot be empty!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Processor cannot be empty!");
                }
                else
                {
                    this.processor = value;
                }
            }
        }
        public string Graphicscard
        {
            get
            {
                return this.graphicscard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Graphic card cannot be empty!");
                }
                else
                {
                    this.graphicscard = value;
                }
            }
        }
        public double ScreenSize
        {
            get
            {
                return this.screensize;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The screen size must be > 0!");
                }

                this.screensize = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be > 0!");
                }

                this.price = value;
            }
        }
        public void PrintLapTop()
        {
            Console.WriteLine("Model = {0},\nManufacturer = {1},\nProcessor = {2},\nGraphic card = {3},\nBattery = {4},\nBattery Life = {5} h,\nScreen Size = {6},\nPrice = {7}"
                , model, manufacturer, processor, graphicscard, bat.BatteryName, String.Format("{0:0.##}", bat.BatteryLife), String.Format("{0:0.##}", screensize), String.Format("{0:0.##}", price));
        }
        public override string ToString()
        {
            return String.Format("Model = {0},\nManufacturer = {1},\nProcessor = {2},\nGraphic card = {3},\nBattery = {4},\nBattery Life = {5} h,\nScreen Size = {6},\nPrice = {7}"
                 , model, manufacturer, processor, graphicscard, bat.BatteryName, String.Format("{0:0.##}", bat.BatteryLife), String.Format("{0:0.##}", screensize), String.Format("{0:0.##}", price));
        }
    }

    class Battery
    {
        private string batteryName;
        private double batteryLife;
        public Battery(string batteryName, double batteryLife)
        {
            this.BatteryName = batteryName;
            this.BatteryLife = batteryLife;
        }

        public string BatteryName
        {
            get
            {
                return this.batteryName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battety name cannot be empty!");
                }

                this.batteryName = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery life size must be > 0!");
                }

                this.batteryLife = value;
            }

        }
        public void PrintBattery()
        {
            Console.WriteLine("\nBattery Name = {0},\nbattery Life= {1}", batteryName, String.Format("{0:0.##}", batteryLife));
        }

    }

    static void Main()
    {
        Battery bat = new Battery("Varta", 8.8);
        bat.PrintBattery();
        Console.WriteLine();
        Laptop lap = new Laptop("Lenovo CF-2514787", "Lenovo", "Intel i5 2.5 Mhz", "Nvidia", bat, 17.53, 1500.32123);
        lap.PrintLapTop();
        Console.WriteLine();
        Console.WriteLine("override:\n" + lap);
    }

}

