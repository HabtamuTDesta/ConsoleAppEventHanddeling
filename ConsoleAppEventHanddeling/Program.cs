using System;

class Program
{
    static void Main(string[] args)
    {
        TemperatureMonitor monitor = new TemperatureMonitor();
        TemperatureAlert alert = new TemperatureAlert();

        
        monitor.TemperatureExceeded += alert.OnTemperatureExceeded;

        monitor.UpdateTemperature(25);  
        monitor.UpdateTemperature(35);  
        monitor.UpdateTemperature(40);  
    }
}
