using System;

abstract class Engine { }
abstract class CarPart { }
class ElectricEngine: Engine { }

class GasEngine: Engine { }

class Battery: CarPart { }

class Differential: CarPart { }

class Wheel: CarPart { }

abstract class Car <TEngine> where TEngine : Engine
{
    public TEngine Engine;

    public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
    {
    }
}
class ElectricCar: Car<ElectricEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}
class GasCar: Car<GasEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}