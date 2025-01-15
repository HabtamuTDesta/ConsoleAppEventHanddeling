using System;

public class TemperatureAlert
{
  
    public void OnTemperatureExceeded(object sender, TemperatureEventArgs e)
    {
        Console.WriteLine($"Alert! Temperature exceeded: {e.Temperature}°C.");
     
    }
}