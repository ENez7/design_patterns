﻿namespace DesignPatterns.Factory;

public class RoadLogistics : Logistics
{
    protected override ITransport CreateTransport()
    {
        return new Truck();
    }
}