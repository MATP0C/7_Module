using System;

class ElectricEngine { }

class GasEngine { }

class Battery { }

class Differential { }

class Wheel { }

class Car<T1>
{
    public T1 Engine;

    public virtual void ChangePart<T2>(T2 newPart)
    {

    }
}