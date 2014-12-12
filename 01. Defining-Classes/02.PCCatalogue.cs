using System;
using System.Collections.Generic;


class PCCatalogue
{
    static void Main()
    {
        
        Component processor = new Component();
        Component hdd = new Component();
        Component mb = new Component();
        Component vc = new Component();

        processor.Name = "Intel";
        processor.Details = "2.5MHz 16MB Cash";
        processor.Price = 150.23;

        hdd.Name = "Seagate";
        hdd.Details = "500GB 16MB Cash";
        hdd.Price = 90.50;

        mb.Name = "ASUS";
        mb.Details = "";
        mb.Price = 130.69;

        vc.Name = "Nvidia";
        vc.Details = "GForce 150 MX";
        vc.Price = 35.43;
        
        
        List<Component> components = new List<Component>();

        components.Add(new Component() { 
                Details = "Asus", 
                Name = "asdasd", 
                Price = 3.14 }
            );


        components.Add(processor);
        components.Add(hdd);
        components.Add(mb);
        components.Add(vc);

        Computer compLenovo = new Computer("Lenovo", components);
        Console.WriteLine(compLenovo.ToString());
    }
}

public class Computer
{
    private string name;
    private List<Component> components;


    public Computer(string name = null)
    {
        this.name = name;
    }
    public Computer(string name, List<Component> components)
    {
        this.name = name;
        this.components = components;
    }

    public void printComp(List<Component> components)
    {
        foreach (var c in components)
        {
            Console.WriteLine(c.ToString());
        }
    }


    public override string ToString()
    {
        double price = 0;

        string res = String.Format("Computer name = {0}\n"
             , name);
        foreach (var c in components)
        {
            res += c.ToString() + "\n";
            price += c.Price;
        }
        res += String.Format("TOTAL PRICE = {0}", String.Format("{0:0.##}", price));
        return res;
    }



    internal string printComp()
    {
        throw new NotImplementedException();
    }
}

public class Component
{
    private string name;
    private string details;
    private double price;

    public Component()
    {
    }

    public Component(string name, string details, double price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Component name cannot be empty!");
            }
            this.name = value;
        }
    }
    
    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            this.details = value;
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
                Console.WriteLine("Component price cannot be < 0 !");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        return String.Format("Component name = {0},\nComponent details = {1},\nComponent price= {2}"
             , name, details, String.Format("{0:0.##}", price));
    }

}






