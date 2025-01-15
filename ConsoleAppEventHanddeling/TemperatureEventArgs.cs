using System;

public class TemperatureEventArgs : EventArgs
{
    public int Temperature { get; }

    public TemperatureEventArgs(int temperature)
    {
        Temperature = temperature;
    }
}