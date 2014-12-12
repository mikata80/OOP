using System;

class trash
{
    static void Main()
    {
        Console.WriteLine("***** Fun with Class Types *****\n");
        // Allocate and configure a Car object.
        Car myCar = new Car();
        SportsCar sCar = new SportsCar();
        
        myCar.petName = "Henry";
        myCar.currSpeed = 10;
        // Speed up the car a few times and print out the
        // new state.
        for (int i = 0; i <= 10; i++)
        {
            myCar.SpeedUp(5);
            myCar.PrintState();
        }
        Console.ReadLine();
    }
}
    class Car
    {
        public string petName;
        public int currSpeed;

        //public Car(string petName = "", int currSpeed = 0)
        //{
        //    this.PetName = petName;
        //    this.CurrSpeed = currSpeed;
        //}

        //public string PetName
        //{
        //    get
        //    {
        //        return this.petName;
        //    }
        //    set
        //    {
        //        this.petName = value;
        //    }
        //}

        //public int CurrSpeed
        //{
        //    get
        //    {
        //        return this.currSpeed;
        //    }
        //    set
        //    {
        //        this.currSpeed = value;
        //    }
        //}
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }

    }

    public class SportsCar
    {
        // OK! Nested types can be marked private.
        private enum CarColor
        {
            Red, Green, Blue
        }
    }


