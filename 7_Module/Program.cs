using System;

class Engine { }
class CarPart { }
class ElectricEngine: Engine { }

class GasEngine: Engine { }

class Battery: CarPart { }

class Differential: CarPart { }

class Wheel: CarPart { }

class Car <TEngine> where TEngine : Engine
{
    public TEngine Engine;

    public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
    {
    }
}