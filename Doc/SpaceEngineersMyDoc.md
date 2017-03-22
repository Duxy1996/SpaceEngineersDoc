

# Space Engineers  ![alt text](http://fukkit.net/media/SpaceEngineers.png)

by **Carlos Durán**


Generic blocks var:

```C
bool Enabled
bool ShowOnHUD
string 	CustomName
string 	CustomNameWithFaction
string 	DetailedInfo
```


Fields:

only read properties;

Terminal properties:

modifycable properties;


----------------------

##Antenna

Interface name: IMyRadioAntenna

Parent: IMyFunctionalBlock


Fields:

```C 
    float Radius
```
Terminal properties: 
* Radius -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseRadius -> Increase Broadcast radius
* DecreaseRadius -> Decrease Broadcast radius

Code Class in C# :
```C
class IMyRadioAntenna {
	/// Broadcasting/Receiving range (read-only)
	float Radius;
	/// Show shipname on hud (read-only)
	bool ShowShipName;
	/// Returns true if antena is broadcasting (read-only)
	bool IsBroadcasting;
}
```
####Code in C# set terminal values:
```C
In construction;
```
####Code in C# set Actions:
```C
IMyRadioAntenna.GetActionWithName("OnOff").Apply(IMyRadioAntenna); //change on to off and off to on 
IMyRadioAntenna.GetActionWithName("OnOff_On").Apply(IMyRadioAntenna);//turn on
IMyRadioAntenna.GetActionWithName("OnOff_Off").Apply(IMyRadioAntenna);//turn off
IMyRadioAntenna.GetActionWithName("IncreaseRadius").Apply(IMyRadioAntenna);//Increase Radius of action
IMyRadioAntenna.GetActionWithName("DecreaseRadius").Apply(IMyRadioAntenna);//Reduce Radius of action
```
####Code example in C#:
```C
var antenna_name = "name_of_your_Antenna";
void Main() 
{
	 var GridTerminalSystem = GridTerminalSystem;
     IMyRadioAntenna antenna = GridTerminalSystem.GetBlockWithName(antenna_name) as IMyRadioAntenna;     
}
```

##Arc furnace

Interface name: IMyRefinery

Parent: IMyProductionBlock

Parent: IMyFunctionalBlock

Fields:
```C
bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code in C# set terminal values:

```C
public interface IMyRefinery : IMyProductionBlock, Ingame.IMyRefinery
{

}
```

####Code in C# set Actions:
```C
In construction;
```

####Code in C# set Actions:
```C
IMyRefinery.GetActionWithName("OnOff").Apply(IMyRefinery); //change on to off and off to on 
IMyRefinery.GetActionWithName("OnOff_On").Apply(IMyRefinery);//turn on
IMyRefinery.GetActionWithName("OnOff_Off").Apply(IMyRefinery);//turn off
IMyRefinery.GetActionWithName("UseConveyor").Apply(IMyRefinery);
```

####Code example in C#
```C
var GridTerminalSystem = GridTerminalSystem;
var IMyRefinery = GridTerminalSystem.GetBlockWithName("Refinery") as IMyRefinery;
```

##Artificial Mass

Interface name: IMyVirtualMass

Parent: IMyFunctionalBlock

Fields:
* None

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off

####Code Class in C# :
```C
In construction;

```
####Code in C# set terminal values:
```C
In construction;

```
####Code in C# set Actions:
```C
IMyVirtualMass.GetActionWithName("OnOff").Apply(IMyVirtualMass); //change on to off and off to on 
IMyVirtualMass.GetActionWithName("OnOff_On").Apply(IMyVirtualMass);//turn on
IMyVirtualMass.GetActionWithName("OnOff_Off").Apply(IMyVirtualMass);//turn off
```

##Assembler

Interface name: IMyAssembler

Parent: IMyProductionBlock

Parent: IMyFunctionalBlock

Fields:
```C
 bool UseConveyorSystem
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```C
public interface IMyAssembler : IMyProductionBlock
{
    bool DisassembleEnabled { get; }
}
```
####Code in C# set terminal values:
```C
In construction;
```
####Code in C# set Actions:
```C
IMyAssembler.GetActionWithName("OnOff").Apply(IMyAssembler); //change on to off and off to on 
IMyAssembler.GetActionWithName("OnOff_On").Apply(IMyAssembler);//turn on
IMyAssembler.GetActionWithName("OnOff_Off").Apply(IMyAssembler);//turn off
IMyAssembler.GetActionWithName("UseConveyor").Apply(IMyAssembler);
```

##Battery

Interface name: IMyBatteryBlock

Parent: IMyFunctionalBlock

Fields:
```C
bool HasCapacityRemaining
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Recharge -> Recharge On/Off

####Code Class in C# :
```C
public interface IMyBatteryBlock : IMyFunctionalBlock
{
    bool HasCapacityRemaining { get; }

    float CurrentStoredPower { get; }
    float MaxStoredPower { get; }

    float CurrentInput { get; }
    float CurrentOutput { get; }
    bool IsCharging { get; }

    bool OnlyRecharge { get; set; }
    bool OnlyDischarge { get; set; }
    bool SemiautoEnabled { get; set; }
}
```
####Code in C# set terminal values:
```C
In construction;
```
####Code in C# set Actions:

```C
IMyBatteryBlock.GetActionWithName("OnOff").Apply(IMyBatteryBlock); //change on to off and off to on 
IMyBatteryBlock.GetActionWithName("OnOff_On").Apply(IMyBatteryBlock);//turn on
IMyBatteryBlock.GetActionWithName("OnOff_Off").Apply(IMyBatteryBlock);//turn off
IMyBatteryBlock.GetActionWithName("Recharge").Apply(IMyBatteryBlock);
```

##Beacon

Interface name: IMyBeacon
Parent: IMyFunctionalBlock

Fields:
```C
float Radius
```
Terminal properties:
Radius -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseRadius -> Increase Broadcast radius
* DecreaseRadius -> Decrease Broadcast radius
####Code Class in C# :
```C
public interface IMyBeacon : IMyFunctionalBlock
{
    float Radius { get; }
}
```
####Code in C# set terminal values:
```C
In construction;
```

####Code in C# set Actions:
```C
IMyBeacon.GetActionWithName("OnOff").Apply(IMyBeacon); //change on to off and off to on 
IMyBeacon.GetActionWithName("OnOff_On").Apply(IMyBeacon);//turn on
IMyBeacon.GetActionWithName("OnOff_Off").Apply(IMyBeacon);//turn off
IMyBeacon.GetActionWithName("IncreaseRadius").Apply(IMyBeacon);
IMyBeacon.GetActionWithName("DecreaseRadius").Apply(IMyBeacon);
```

##Button Panel
Interface name: IMyButtonPanel

Fields:
```C
bool AnyoneCanUse
```
Actions:
* AnyoneCanUse -> Anyone Can Use On/Off

####Code Class in C# :
```C
In construction;
```

####Code in C# set terminal values:
```C
In construction;
```

####Code in C# set Actions:
```C
IMyButtonPanel.GetActionWithName("OnOff").Apply(IMyButtonPanel);     //change on to off and off to on 
IMyButtonPanel.GetActionWithName("OnOff_On").Apply(IMyButtonPanel);  //turn on
IMyButtonPanel.GetActionWithName("OnOff_Off").Apply(IMyButtonPanel); //turn off
IMyButtonPanel.GetActionWithName("AnyoneCanUse").Apply(IMyButtonPanel);
```

##Camera

Interface name: IMyCameraBlock

Parent: IMyFunctionalBlock

Fields:
* None

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* View -> View

####Code Class in C# :
```C
	public interface IMyCameraBlock:IMyFunctionalBlock
    {

    }
```
####Code in C# set terminal values:
```C
	In construction;
```
####Code in C# set Actions:
```C
IMyCameraBlock.GetActionWithName("OnOff").Apply(IMyCameraBlock); //change on to off and off to on 
IMyCameraBlock.GetActionWithName("OnOff_On").Apply(IMyCameraBlock);//turn on
IMyCameraBlock.GetActionWithName("OnOff_Off").Apply(IMyCameraBlock);//turn off
IMyCameraBlock.GetActionWithName("View").Apply(IMyCameraBlock);
```

##Cockpit

Interface name: IMyCockpit 
Parent: IMyShipController


Fields:

```C
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride
```
Actions:
* ControlThrusters -> Control thrusters On/Off
* ControlWheels -> Control wheels On/Off
* HandBrake -> Handbrake On/Off
* DampenersOverride -> Inertia dampeners On/Off

##Collector##

Interface name: IMyCollector

Parent: IMyFunctionalBlock

Fields:
```C
bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```C
public interface IMyCockpit : IMyShipController
{

}
```
####Code in C# set terminal values:
```C
	In construction;

```
####Code in C# set Actions:
```C
IMyCollector.GetActionWithName("OnOff").Apply(IMyCollector);     //change on to off and off to on 
IMyCollector.GetActionWithName("OnOff_On").Apply(IMyCollector);  //turn on
IMyCollector.GetActionWithName("OnOff_Off").Apply(IMyCollector); //turn off
IMyCollector.GetActionWithName("UseConveyor").Apply(IMyCollector);
```

##Connector##

Interface name: IMyShipConnector

Parent: IMyFunctionalBlock

Fields:

```C
bool ThrowOut 
bool CollectAll 
bool IsLocked 
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* ThrowOut -> Throw Out On/Off
* CollectAll -> Collect All On/Off
* SwitchLock -> Switch lock

####Code in C# set terminal values:
```C
public interface IMyShipConnector:IMyFunctionalBlock
{
    bool ThrowOut { get; }
    bool CollectAll { get; }
    bool IsLocked { get; }
    bool IsConnected { get; }
    IMyShipConnector OtherConnector { get; }
}
```
####Code in C# set Actions:
```C
IMyShipConnector.GetActionWithName("OnOff").Apply(IMyShipConnector);     //change on to off and off to on 
IMyShipConnector.GetActionWithName("OnOff_On").Apply(IMyShipConnector);  //turn on
IMyShipConnector.GetActionWithName("OnOff_Off").Apply(IMyShipConnector); //turn off
IMyShipConnector.GetActionWithName("ThrowOut").Apply(IMyShipConnector);
IMyShipConnector.GetActionWithName("CollectAll").Apply(IMyShipConnector);
IMyShipConnector.GetActionWithName("SwitchLock").Apply(IMyShipConnector);
```

##Control Panel

Interface name: IMyControlPanel

Fields:
* None

Actions: 
* None

####Code Class in C# :
```C
In construction;
```
####Code in C# set terminal values:
```C
In construction;
```
####Code in C# set Actions:
```C
IMyControlPanel.GetActionWithName("OnOff").Apply(IMyControlPanel);     //change on to off and off to on 
IMyControlPanel.GetActionWithName("OnOff_On").Apply(IMyControlPanel);  //turn on
IMyControlPanel.GetActionWithName("OnOff_Off").Apply(IMyControlPanel); //turn off
```

##Control Station

Interface name: IMyCockpit

Parent: IMyShipController

Fields:

```C
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride
```
Actions:
* ControlThrusters -> Control thrusters On/Off
* ControlWheels -> Control wheels On/Off
* HandBrake -> Handbrake On/Off
* DampenersOverride -> Inertia dampeners On/Off

####Code Class in C# :
```C
In construction;
```
####Code in C# set terminal values:
```C
In construction;
```
####Code in C# set Actions:
```C
IMyCockpit.GetActionWithName("OnOff").Apply(IMyCockpit);     //change on to off and off to on 
IMyCockpit.GetActionWithName("OnOff_On").Apply(IMyCockpit);  //turn on
IMyCockpit.GetActionWithName("OnOff_Off").Apply(IMyCockpit); //turn off
IMyCockpit.GetActionWithName("ControlThrusters").Apply(IMyCockpit);
IMyCockpit.GetActionWithName("ControlWheels").Apply(IMyCockpit);
IMyCockpit.GetActionWithName("HandBrake").Apply(IMyCockpit);
IMyCockpit.GetActionWithName("DampenersOverride").Apply(IMyCockpit);
```

##Door##

Interface name: IMyDoor

Parent: IMyFunctionalBlock

Fields:
* bool Open

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Open -> Open/Closed
* Open_On -> Open
* Open_Off -> Closed

####Code Class in C# :
```C
public interface IMyDoor : IMyFunctionalBlock
{
        /// <summary>
        /// Indicates whether door is opened or closed. True when door is opened.
        /// </summary>
        bool Open { get; }

        /// <summary>
        /// Door state, zero is fully closed. One is fully opened.
        /// </summary>
        float OpenRatio { get; }
}	
```
####Code in C# set Actions:
```C
door1.GetActionWithName("Open_Off").Apply(door1);
door2.GetActionWithName("OnOff_On").Apply(door2);
door2.GetActionWithName("Open").Apply(door2);
```

##Drill##

Interface name: IMyShipDrill

Parent: IMyFunctionalBlock


Fields:

```C
 bool UseConveyorSystem

```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```C
In construction;
```
####Code in C# set terminal values:
```C
In construction;
```
####Code in C# set Actions:
```C
IMyShipDrill.GetActionWithName("OnOff").Apply(IMyShipDrill);     //change on to off and off to on 
IMyShipDrill.GetActionWithName("OnOff_On").Apply(IMyShipDrill);  //turn on
IMyShipDrill.GetActionWithName("OnOff_Off").Apply(IMyShipDrill); //turn off
IMyShipDrill.GetActionWithName("UseConveyor").Apply(IMyShipDrill);
```

##Flight Seat##

Interface name: IMyCockpit

Parent: IMyShipController


Fields:

```C
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride
```
Actions:
* ControlThrusters -> Control thrusters On/Off
* ControlWheels -> Control wheels On/Off
* HandBrake -> Handbrake On/Off
* DampenersOverride -> Inertia dampeners On/Off

####Code Class in C# :
```C
In construction;
```
####Code in C# set terminal values:
```C
In construction;
```
####Code in C# set Actions:
```C
IMyCockpit.GetActionWithName("OnOff").Apply(IMyCockpit);     //change on to off and off to on 
IMyCockpit.GetActionWithName("OnOff_On").Apply(IMyCockpit);  //turn on
IMyCockpit.GetActionWithName("OnOff_Off").Apply(IMyCockpit); //turn off
IMyCockpit.GetActionWithName("ControlThrusters").Apply(IMyCockpit);
IMyCockpit.GetActionWithName("ControlWheels").Apply(IMyCockpit);
IMyCockpit.GetActionWithName("HandBrake").Apply(IMyCockpit);
IMyCockpit.GetActionWithName("DampenersOverride").Apply(IMyCockpit);
```

##Gatling Turret

Interface name: IMyLargeGatlingTurret

Parent: IMyLargeConveyorTurretBase

Parent: IMyLargeTurretBase

Parent: IMyFunctionalBlock


Fields:

```C
bool UseConveyorSystem 
bool CanControl
float Range
```

Terminal properties:
* Radius -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Control -> Control
* IncreaseRange -> Increase Radius
* DecreaseRange -> Decrease Radius
* UseConveyor -> Use Conveyor System On/Off
* Terminal block and action name list - 2/5

####Code Class in C# :
```C
	In construction;
```
####Code in C# set terminal values:
```C
	In construction;

```
####Code in C# set Actions:
```C
IMyLargeGatlingTurret.GetActionWithName("OnOff").Apply(IMyLargeGatlingTurret);     //change on to off and off to on 
IMyLargeGatlingTurret.GetActionWithName("OnOff_On").Apply(IMyLargeGatlingTurret);  //turn on
IMyLargeGatlingTurret.GetActionWithName("OnOff_Off").Apply(IMyLargeGatlingTurret); //turn off
IMyLargeGatlingTurret.GetActionWithName("Control").Apply(IMyLargeGatlingTurret);
IMyLargeGatlingTurret.GetActionWithName("IncreaseRange").Apply(IMyLargeGatlingTurret);
IMyLargeGatlingTurret.GetActionWithName("DecreaseRange").Apply(IMyLargeGatlingTurret);
IMyLargeGatlingTurret.GetActionWithName("UseConveyor").Apply(IMyLargeGatlingTurret);
```

##Gravity Generator

Interface name: IMyGravityGenerator

Parent: IMyGravityGeneratorBase

Parent: IMyFunctionalBlock


Fields:

```C
float FieldWidth 
float FieldHeight 
float FieldDepth 
float Gravity
```

Terminal properties:
* Width -> Single
* Height -> Single
* Depth -> Single
* Gravity -> Single

Actions:

* OnOff -> Toggle block On/Off 
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseWidth -> Increase Field width
* DecreaseWidth -> Decrease Field width
* IncreaseHeight -> Increase Field height
* DecreaseHeight -> Decrease Field height
* IncreaseDepth -> Increase Field depth
* DecreaseDepth -> Decrease Field depth
* IncreaseGravity -> Increase Acceleration
* DecreaseGravity -> Decrease Acceleration

####Code Class in C# :
```C
	In construction;
```

####Code in C# set Actions:
```C
IMyGravityGenerator.SetValueFloat("Gravity", 1.0f);
IMyGravityGenerator.SetValueFloat("Width", 60.0f);
IMyGravityGenerator.SetValueFloat("Height", 60.0f);
IMyGravityGenerator.SetValueFloat("Depth", 60.0f);
```
##Grinder##

Interface name: IMyShipGrinder

Parent: IMyShipToolBase

Parent: IMyFunctionalBlock

Fields:
* None

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```C
public interface IMyShipGrinder : IMyShipToolBase
{

}
```
####Code in C# set terminal values:
```C
In construction;
```
####Code in C# set Actions:
```C
IMyShipGrinder.GetActionWithName("OnOff").Apply(IMyShipGrinder);     //change on to off and off to on 
IMyShipGrinder.GetActionWithName("OnOff_On").Apply(IMyShipGrinder);  //turn on
IMyShipGrinder.GetActionWithName("OnOff_Off").Apply(IMyShipGrinder); //turn off
IMyShipGrinder.GetActionWithName("UseConveyor").Apply(IMyShipGrinder); 
```

##Gyroscope

Interface name: IMyGyro

Parent: IMyFunctionalBlock


Fields:

```C
float GyroPower 
bool GyroOverride 
float Yaw 
float Pitch 
float Roll 
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreasePower -> Increase Power
* DecreasePower -> Decrease Power
* Override -> Override controls On/Off
* IncreaseYaw -> Increase Yaw override
* DecreaseYaw -> Decrease Yaw override
* IncreasePitch -> Increase Pitch override
* DecreasePitch -> Decrease Pitch override
* IncreaseRoll -> Increase Roll override
* DecreaseRoll -> Decrease Roll override

####Code Class in C# :
```C
	public interface IMyGyro : IMyFunctionalBlock
    {
        float GyroPower { get; }
        bool GyroOverride { get; }
        float Yaw { get; }
        float Pitch { get; }
        float Roll { get; }
    }
```

####Code in C# set terminal values:
```C
In construction;
```
####Code in C# set Actions:
```C
In construction;
```

##Interior Light##

Interface name: IMyInteriorLight
Parent: IMyLightingBlock
Parent: IMyFunctionalBlock


Fields:


```C
float Radius
float Intensity
float BlinkIntervalSeconds
float BlinkLenght
float BlinkOffset
```

Terminal properties:
* Color -> Color
* Radius -> Single
* Falloff -> Single
* Intensity -> Single
* Blink Interval -> Single
* Blink Lenght -> Single
* Blink Offset -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseRadius -> Increase Radius
* DecreaseRadius -> Decrease Radius
* IncreaseBlink Interval -> Increase Blink Interval
* DecreaseBlink Interval -> Decrease Blink Interval
* IncreaseBlink Lenght -> Increase Blink Length
* DecreaseBlink Lenght -> Decrease Blink Length
* IncreaseBlink Offset -> Increase Blink Offset
* DecreaseBlink Offset -> Decrease Blink Offset

####Code Class in C# :
```C
	In construction;
```
####Code in C# set Actions:
```C
IMyInteriorLight.SetValueColor("Color", Color);
IMyInteriorLight.SetValueFloat("Radius", 60.0f);
IMyInteriorLight.SetValueFloat("Falloff", 60.0f);
IMyInteriorLight.SetValueFloat("Intensity", 60.0f);
IMyInteriorLight.SetValueFloat("Blink Interval", 60.0f);
IMyInteriorLight.SetValueFloat("Blink Lenght", 60.0f);
IMyInteriorLight.SetValueFloat("Blink Offset", 60.0f);
```

##Interior Turret##

Interface name: IMyLargeInteriorTurret

Parent: IMyLargeTurretBase
Parent: IMyFunctionalBlock

####Code Class in C# :
```C
	In construction;
```
####Code in C# set terminal values:
```C
	In construction;

```
####Code in C# set Actions:
```C
	In construction;

```

Fields:


```C
bool CanControl
float Range
```

Terminal properties:
* Radius -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Control -> Control
* IncreaseRange -> Increase Radius
* DecreaseRange -> Decrease Radius

####Code Class in C# :
```C
	In construction;
```
####Code in C# set Actions:
```C
IMyLargeInteriorTurret.SetValueFloat("Radius", 60.0f);
```

##Landing Gear##

Interface name: IMyLandingGear
Parent: IMyFunctionalBlock


Fields:
```C
	float BreakForce
```

Terminal properties:
* BreakForce -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Lock -> Lock
* Unlock -> Unlock
* SwitchLock -> Switch lock
* Autolock -> Autolock On/Off
* IncreaseBreakForce -> Increase Break Force
* DecreaseBreakForce -> Decrease Break Force

####Code Class in C# :
```C
	In construction;
```

####Code in c# to set values to 

```C
IMyLandingGear.SetValueFloat("BreakForce", 60.0f);
```

##Small Cargo Container##

Interface name: IMyCargoContainer

Fields:
 None
Actions: None

##Medium Cargo Container##

Interface name: IMyCargoContainer

Fields:
 None
Actions:None

##Large Cargo Container##

Interface name: IMyCargoContainer

Fields:
 None
Actions: None

##Small Reactor##

Interface name: IMyReactor
Parent: IMyFunctionalBlock

Fields:

```C
bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off


####Code class in c#:

```C
class IMyReactor{
	bool UseConveyorSystem; // read only
}
```
####Code example in C#:

```C
void Main(){
	 var GridTerminalSystem = GridTerminalSystem;
	 IMyReactor  reactor  = GridTerminalSystem.GetBlockWithName("rec") as IMyReactor; 
	 bool is_fuctional = reactor.IsFuctional;// return true if reactor is working	 
     bool y = reactor.UseConveyorSystem;// if it is connect to others
}
```

##Large Reactor

Interface name: IMyReactor

Parent: IMyFunctionalBlock

Fields:
```C
 bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```C
In construction;
```

####Code in c# to set values to 
Fields:

```C
IMyReactor.SetValueFloat("UseConveyorSystem", 60.0f);
```

####Code in C# set Actions:
```C
IMyReactor.GetActionWithName("OnOff").Apply(IMyReactor);  //change on to off and off to on 
IMyReactor.GetActionWithName("OnOff_On").Apply(IMyReactor); //turn on
IMyReactor.GetActionWithName("OnOff_Off").Apply(IMyReactor); //turn off
IMyReactor.GetActionWithName("UseConveyor").Apply(IMyReactor);
```

##Small Thruster

Interface name: IMyThrust
Parent: IMyFunctionalBlock


Fields:
 
```C
float ThrustOverride
```
Terminal properties:
* Override -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseOverride -> Increase Thrust override
* DecreaseOverride -> Decrease Thrust override

####Code Class in C# :
```C
In construction;
```

####Code in c# to set values to 
Fields:

```C
IMyThrust.SetValueFloat("Override", 60.0f);
```

####Code in C# set Actions:
```C
IMyThrust.GetActionWithName("OnOff").Apply(IMyThrust);  //change on to off and off to on 
IMyThrust.GetActionWithName("OnOff_On").Apply(IMyThrust); //turn on
IMyThrust.GetActionWithName("OnOff_Off").Apply(IMyThrust); //turn off
IMyThrust.GetActionWithName("IncreaseOverride").Apply(IMyThrust);
IMyThrust.GetActionWithName("DecreaseOverride").Apply(IMyThrust);
```

##Large Thruster##

Interface name: IMyThrust

Parent: IMyFunctionalBlock


Fields:
 
```C
float ThrustOverride
```
Terminal properties:
* Override -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseOverride -> Increase Thrust override
* DecreaseOverride -> Decrease Thrust override

####Code Class in C# :
```C
	In construction;
```

####Code in c# to set values to 
Fields:

```C
IMyThrust.SetValueFloat("Override", 60.0f);
```

####Code in C# set Actions:
```C
IMyThrust.GetActionWithName("OnOff").Apply(IMyThrust);  //change on to off and off to on 
IMyThrust.GetActionWithName("OnOff_On").Apply(IMyThrust); //turn on
IMyThrust.GetActionWithName("OnOff_Off").Apply(IMyThrust); //turn off
IMyThrust.GetActionWithName("IncreaseOverride").Apply(IMyThrust);
IMyThrust.GetActionWithName("DecreaseOverride").Apply(IMyThrust);
```

##Medical Room

Interface name: IMyMedicalRoom
Parent: IMyFunctionalBlock

Fields:
 None

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off

####Code Class in C# :
```C
	In construction;
```
####Code in C# set terminal values:
```C
	In construction;
```
####Code in C# set Actions:
```C
IMyMedicalRoom.GetActionWithName("OnOff").Apply(IMyMedicalRoom);  //change on to off and off to on 
IMyMedicalRoom.GetActionWithName("OnOff_On").Apply(IMyMedicalRoom); //turn on
IMyMedicalRoom.GetActionWithName("OnOff_Off").Apply(IMyMedicalRoom); //turn off
```

##Merge Block

Interface name: IMyShipMergeBlock
Parent: IMyFunctionalBlock

Fields:
 None
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off

####Code Class in C# :
```C
	In construction;
```
####Code in C# set terminal values:
```C
	In construction;
```
####Code in C# set Actions:
```C
IMyShipMergeBlock.GetActionWithName("OnOff").Apply(IMyShipMergeBlock);  //change on to off and off to on 
IMyShipMergeBlock.GetActionWithName("OnOff_On").Apply(IMyShipMergeBlock); //turn on
IMyShipMergeBlock.GetActionWithName("OnOff_Off").Apply(IMyShipMergeBlock); //turn off
```

##Missile Turret

Interface name: IMyLargeMissileTurret

Parent: IMyLargeConveyorTurretBase

Parent: IMyLargeTurretBase

Parent: IMyFunctionalBlock

Fields:

```C
bool UseConveyorSystem 
bool CanControl
float Range
```
Terminal properties:
* Range -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Control -> Control
* IncreaseRange -> Increase Radius
* DecreaseRange -> Decrease Radius
* UseConveyor -> Use Conveyor System On/Of

####Code Class in C# :
```C
	In construction;
```
####Code in C# set terminal values:
```C
IMyLargeMissileTurret.SetValueFloat("Range", 60.0f);
```
####Code in C# set Actions:
```C
IMyLargeMissileTurret.GetActionWithName("OnOff").Apply(IMyLargeMissileTurret);  //change on to off and off to on 
IMyLargeMissileTurret.GetActionWithName("OnOff_On").Apply(IMyLargeMissileTurret); //turn on
IMyLargeMissileTurret.GetActionWithName("OnOff_Off").Apply(IMyLargeMissileTurret); //turn off
IMyLargeMissileTurret.GetActionWithName("Control").Apply(IMyLargeMissileTurret);
IMyLargeMissileTurret.GetActionWithName("IncreaseRange").Apply(IMyLargeMissileTurret);
IMyLargeMissileTurret.GetActionWithName("DecreaseRange").Apply(IMyLargeMissileTurret);
IMyLargeMissileTurret.GetActionWithName("UseConveyor").Apply(IMyLargeMissileTurret);
```

##Ore Detector##

Interace name: IMyOreDetector

Parent: IMyFunctionalBlock

Fields:

```C
float Range 
bool BroadcastUsingAntennas 
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Terminal block and action name list - 3/5

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
	In construction;

```
####Code in C# set Actions:
```C
IMyOreDetector.GetActionWithName("OnOff").Apply(IMyOreDetector);  //change on to off and off to on 
IMyOreDetector.GetActionWithName("OnOff_On").Apply(IMyOreDetector); //turn on
IMyOreDetector.GetActionWithName("OnOff_Off").Apply(IMyOreDetector); //turn off
```

##Passenger Seat##

Interface name: IMyCockpit

Parent: IMyShipController

Fields:

```C
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride
```
Actions:
* ControlThrusters -> Control thrusters On/Off
* ControlWheels -> Control wheels On/Off
* HandBrake -> Handbrake On/Off
* DampenersOverride -> Inertia dampeners On/Off

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
	In construction;

```
####Code in C# set Actions:
```C
IMyCockpit.GetActionWithName("OnOff").Apply(IMyCockpit);  //change on to off and off to on 
IMyCockpit.GetActionWithName("OnOff_On").Apply(IMyCockpit); //turn on
IMyCockpit.GetActionWithName("OnOff_Off").Apply(IMyCockpit); //turn off
IMyCockpit.GetActionWithName("ControlThrusters").Apply(IMyCockpit);
IMyCockpit.GetActionWithName("ControlWheels").Apply(IMyCockpit);
IMyCockpit.GetActionWithName("HandBrake").Apply(IMyCockpit);
IMyCockpit.GetActionWithName("DampenersOverride").Apply(IMyCockpit);
```

##Piston##

Interface name: IMyPistonBase
Parent: IMyFunctionalBlock


Fields:

```C
float Velocity 
float MinLimit 
float MaxLimit
```
Terminal properties:
Velocity -> Single
UpperLimit -> Single
LowerLimit -> Single 

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Reverse -> Reverse
* IncreaseVelocity -> Increase Velocity
* DecreaseVelocity -> Decrease Velocity
* ResetVelocity -> Reset Velocity
* IncreaseUpperLimit -> Increase Maximal distance
* DecreaseUpperLimit -> Decrease Maximal distance
* IncreaseLowerLimit -> Increase Minimal distance
* DecreaseLowerLimit -> Decrease Minimal distance

####Code Class in C# :
```C
	public interface IMyPistonBase : IMyFunctionalBlock

    {
        /// <summary>
        /// Param - limit is top
        /// </summary>
        float Velocity { get; }
        float MinLimit { get; }
        float MaxLimit { get; }

        /// <summary>
        /// Gets the current position of the piston head relative to the base.
        /// </summary>
        float CurrentPosition { get; }

        /// <summary>
        /// Gets the current status.
        /// </summary>
        PistonStatus Status { get; }

        /// <summary>
        /// Gets if the piston base is attached to the top piece
        /// </summary>
        bool IsAttached { get; }

        /// <summary>
        /// Gets if the piston is safety locked (welded)
        /// </summary>
        bool IsLocked { get; }

        /// <summary>
        /// Gets if the piston is looking for a top part
        /// </summary>
        bool PendingAttachment { get; }

        /// <summary>
        /// Attaches a nearby top part to the piston block
        /// </summary>
        void Attach();

        /// <summary>
        /// Detaches the top from the piston
        /// </summary>
        void Detach();
    }
}
```
####Code in C# set terminal values:

```C
IMyPistonBase.SetValueFloat("Velocity", 60.0f);
IMyPistonBase.SetValueFloat("UpperLimit", 60.0f);
IMyPistonBase.SetValueFloat("LowerLimit", 60.0f);
```
####Code in C# set Actions:
```C
IMyPistonBase.GetActionWithName("OnOff").Apply(IMyPistonBase);  //change on to off and off to on 
IMyPistonBase.GetActionWithName("OnOff_On").Apply(IMyPistonBase); //turn on
IMyPistonBase.GetActionWithName("OnOff_Off").Apply(IMyPistonBase); //turn off
IMyPistonBase.GetActionWithName("Reverse").Apply(IMyPistonBase);
IMyPistonBase.GetActionWithName("IncreaseVelocity").Apply(IMyPistonBase);
IMyPistonBase.GetActionWithName("DecreaseVelocity").Apply(IMyPistonBase);
IMyPistonBase.GetActionWithName("ResetVelocity").Apply(IMyPistonBase);
IMyPistonBase.GetActionWithName("IncreaseUpperLimit").Apply(IMyPistonBase);
IMyPistonBase.GetActionWithName("DecreaseUpperLimit").Apply(IMyPistonBase);
IMyPistonBase.GetActionWithName("IncreaseLowerLimit").Apply(IMyPistonBase);
IMyPistonBase.GetActionWithName("DecreaseLowerLimit").Apply(IMyPistonBase);
```

##Programmable block

Interface name: IMyProgrammableBlock
Parent: IMyFunctionalBlock

Fields:
 
```C
bool IsRunning
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Run -> Run

####Code Class in C# :
```C
	In construction;
```
####Code in C# set terminal values:
```C
	In construction;
```
####Code in C# set Actions:
```C
IMyProgrammableBlock.GetActionWithName("OnOff").Apply(IMyProgrammableBlock);  //change on to off and off to on 
IMyProgrammableBlock.GetActionWithName("OnOff_On").Apply(IMyProgrammableBlock); //turn on
IMyProgrammableBlock.GetActionWithName("OnOff_Off").Apply(IMyProgrammableBlock); //turn off
IMyProgrammableBlock.GetActionWithName("Run").Apply(IMyProgrammableBlock);
```

##Projector##

Interface name: IMyProjector

Parent: IMyFunctionalBlock


Fields:

```C
int ProjectionOffsetX 
int ProjectionOffsetY 
int ProjectionOffsetZ 
int ProjectionRotX 
int ProjectionRotY 
int ProjectionRotZ 
```

Terminal properties:
* X -> Single
* Y -> Single
* Z -> Single
* RotX -> Single
* RotY -> Single
* RotZ -> Single

Actions:
* OnOff->Toggle block On/Off
* OnOff_On->Toggle block On
* OnOff_Off->Toggle block Off
* IncreaseX->Increase Horizontal offset
* DecreaseX->Decrease Horizontal offset
* IncreaseY->Increase Vertical offset
* DecreaseY->Decrease Vertical offset
* IncreaseZ->Increase Forward offset
* DecreaseZ->Decrease Forward offset
* IncreaseRotX->Increase Pitch
* DecreaseRotX->Decrease Pitch
* IncreaseRotY->Increase Yaw
* DecreaseRotY->Decrease Yaw
* IncreaseRotZ->Increase Roll
* DecreaseRotZ->Decrease Roll

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
IMyProjector.SetValueFloat("X", 60.0f);
IMyProjector.SetValueFloat("Y", 60.0f);
IMyProjector.SetValueFloat("Z", 60.0f);
IMyProjector.SetValueFloat("RotX", 60.0f);
IMyProjector.SetValueFloat("RotY", 60.0f);
IMyProjector.SetValueFloat("RotZ", 60.0f);
```
####Code in C# set Actions:
```C
	In construction;
```

##Reloadable Rocket Launcher##

Interface name: IMySmallMissileLauncherReload
Parent: IMyFunctionalBlock

Fields:
```
none;

```
 
```C
bool UseConveyorSystem
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```C
	In construction;
```
####Code in C# set terminal values:
```C
none;
```
####Code in C# set Actions:
```C
IMySmallMissileLauncherReload.GetActionWithName("OnOff").Apply(IMySmallMissileLauncherReload);  //change on to off and off to on 
IMySmallMissileLauncherReload.GetActionWithName("OnOff_On").Apply(IMySmallMissileLauncherReload); //turn on
IMySmallMissileLauncherReload.GetActionWithName("OnOff_Off").Apply(IMySmallMissileLauncherReload); //turn off
IMySmallMissileLauncherReload.GetActionWithName("UseConveyor").Apply(IMySmallMissileLauncherReload);
```

##Refinery##

Interface name: IMyRefinery
Parent: IMyFunctionalBlock
Parent: IMyProductionBlock


Fields:
```C
bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```C
	In construction;
```
####Code in C# set terminal values:
```C
IMyRefinery.SetValueFloat("UseConveyorSystem", 60.0f);
```
####Code in C# set Actions:
```C
IMyRefinery.GetActionWithName("OnOff").Apply(IMyRefinery);  //change on to off and off to on 
IMyRefinery.GetActionWithName("OnOff_On").Apply(IMyRefinery); //turn on
IMyRefinery.GetActionWithName("OnOff_Off").Apply(IMyRefinery); //turn off
IMyRefinery.GetActionWithName("UseConveyor").Apply(IMyRefinery);
```

##Remote Control##

Interface name: IMyRemoteControl

Parent: IMyShipController

Fields:


```C
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride
```

Actions:
* ControlThrusters -> Control thrusters On/Off
* ControlWheels -> Control wheels On/Off
* HandBrake -> Handbrake On/Off
* DampenersOverride -> Inertia dampeners On/Off
* Control -> Control

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
IMyRemoteControl.SetValueFloat("ControlWheels", 60.0f);
IMyRemoteControl.SetValueFloat("ControlThrusters", 60.0f);
IMyRemoteControl.SetValueFloat("HandBrake", 60.0f);
IMyRemoteControl.SetValueFloat("DampenersOverride", 60.0f);
```
####Code in C# set Actions:
```C
IMyRemoteControl.GetActionWithName("OnOff").Apply(IMyRemoteControl);  //change on to off and off to on 
IMyRemoteControl.GetActionWithName("OnOff_On").Apply(IMyRemoteControl); //turn on
IMyRemoteControl.GetActionWithName("OnOff_Off").Apply(IMyRemoteControl); //turn off
IMyRemoteControl.GetActionWithName("ControlThrusters").Apply(IMyRemoteControl);
IMyRemoteControl.GetActionWithName("ControlWheels").Apply(IMyRemoteControl);
IMyRemoteControl.GetActionWithName("HandBrake").Apply(IMyRemoteControl);
IMyRemoteControl.GetActionWithName("DampenersOverride").Apply(IMyRemoteControl);
IMyRemoteControl.GetActionWithName("Control").Apply(IMyRemoteControl);
```

##Rocket Launcher##

Interface name: IMySmallMissileLauncher

Parent: IMyFunctionalBlock

Fields:

```C
bool UseConveyorSystem
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

##Rotor##

Interface name: IMyMotorStator
Parent: IMyMotorBase
Parent: IMyFunctionalBlock


Fields:


```C
bool IsAttached 
float Torque
float BrakingTorque 
float Velocity 
float LowerLimit 
float UpperLimit 
float Displacement
```

Terminal properties:
* Torque -> Single
* BrakingTorque -> Single
* Velocity -> Single
* LowerLimit -> Single
* UpperLimit -> Single
* Displacement -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Reverse -> Reverse
* Detach -> Detach
* Attach -> Attach
* IncreaseTorque -> Increase Torque
* DecreaseTorque -> Decrease Torque
* IncreaseBrakingTorque -> Increase Braking tor.
* DecreaseBrakingTorque -> Decrease Braking tor.
* IncreaseVelocity -> Increase Velocity
* DecreaseVelocity -> Decrease Velocity
* ResetVelocity -> Reset Velocity
* IncreaseLowerLimit -> Increase Lower limit
* DecreaseLowerLimit -> Decrease Lower limit
* IncreaseUpperLimit -> Increase Upper limit
* DecreaseUpperLimit -> Decrease Upper limit
* IncreaseDisplacement -> Increase Rotor displacement
* DecreaseDisplacement -> Decrease Rotor displacement
* Terminal block and action name list - 4/5

####Code Class in C# :
```C
	In construction;
```
####Code in C# set terminal values:

```C
IMyMotorStator.SetValueFloat("Torque", 60.0f);
IMyMotorStator.SetValueFloat("BrakingTorque", 60.0f);
IMyMotorStator.SetValueFloat("Velocity", 60.0f);
IMyMotorStator.SetValueFloat("LowerLimit", 60.0f);
IMyMotorStator.SetValueFloat("UpperLimit", 60.0f);
IMyMotorStator.SetValueFloat("Displacement", 60.0f);
```
####Code in c# set Actions:
```C
IMyMotorStator.GetActionWithName("OnOff").Apply(IMyMotorStator);  //change on to off and off to on 
IMyMotorStator.GetActionWithName("OnOff_On").Apply(IMyMotorStator); //turn on
IMyMotorStator.GetActionWithName("OnOff_Off").Apply(IMyMotorStator); //turn off
IMyMotorStator.GetActionWithName("Reverse").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("Detach").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("Attach").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("IncreaseTorque").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("DecreaseTorque").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("IncreaseBrakingTorque").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("DecreaseBrakingTorque").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("IncreaseVelocity").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("DecreaseVelocity").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("ResetVelocity").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("IncreaseLowerLimit").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("DecreaseLowerLimit").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("IncreaseUpperLimit").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("DecreaseUpperLimit").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("IncreaseDisplacement").Apply(IMyMotorStator);
IMyMotorStator.GetActionWithName("DecreaseDisplacement").Apply(IMyMotorStator);
```

##Sensor##

Interface name: IMySensorBlock

Parent: IMyFunctionalBlock


Fields:

```C
float LeftExtend 
float RightExtend 
float TopExtend 
float BottomExtend 
float FrontExtend 
float BackExtend 
bool DetectPlayers 
bool DetectFloatingObjects 
bool DetectSmallShips 
bool DetectLargeShips 
bool DetectStations 
bool DetectAsteroids 
bool DetectOwner 
bool DetectFriendly 
bool DetectNeutral 
bool DetectEnemy 
```
IMyEntity LastDetectedEntity

Terminal properties:
* Left -> Single
* Right -> Single
* Bottom -> Single
* Top -> Single
* Back -> Single
* Front -> Single

Actions:
* OnOff->Toggle block On/Off
* OnOff_On->Toggle block On
* OnOff_Off->Toggle block Off
* IncreaseLeft->Increase Left extent
* DecreaseLeft->Decrease Left extent
* IncreaseRight->Increase Right extent
* DecreaseRight->Decrease Right extent
* IncreaseBottom->Increase Bottom extent
* DecreaseBottom->Decrease Bottom extent
* IncreaseTop->Increase Top extent
* DecreaseTop->Decrease Top extent
* IncreaseBack->Increase Back extent
* DecreaseBack->Decrease Back extent
* IncreaseFront->Increase Front extent
* DecreaseFront->Decrease Front extent
* Detect Players->Detect players On/Off
* Detect Floating Objects->Detect floating objects On/Off
* Detect Small Ships->Detect small ships On/Off
* Detect Large Ships->Detect large ships On/Off
* Detect Stations->Detect stations On/Off
* Detect Asteroids->Detect asteroids On/Off
* Detect Owner->Detect owner On/Off
* Detect Friendly->Detect friendly On/Off
* Detect Neutral->Detect neutral On/Off
* Detect Enemy->Detect enemy On/Off

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
LastDetectedEntity.SetValueFloat("Left", 60.0f);
LastDetectedEntity.SetValueFloat("Right", 60.0f);
LastDetectedEntity.SetValueFloat("Bottom", 60.0f);
LastDetectedEntity.SetValueFloat("Top", 60.0f);
LastDetectedEntity.SetValueFloat("Back", 60.0f);
LastDetectedEntity.SetValueFloat("Front", 60.0f);

```
####Code in C# set Actions:
```C
LastDetectedEntity.GetActionWithName("OnOff").Apply(LastDetectedEntity);  //change on to off and off to on 
LastDetectedEntity.GetActionWithName("OnOff_On").Apply(LastDetectedEntity); //turn on
LastDetectedEntity.GetActionWithName("OnOff_Off").Apply(LastDetectedEntity); //turn off
LastDetectedEntity.GetActionWithName("IncreaseLeft").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("DecreaseLeft").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("IncreaseRight").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("DecreaseRight").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("IncreaseBottom").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("DecreaseBottom").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("IncreaseFront").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("DecreaseFront").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Players").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Floating Objects").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Small Ships").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Large Ships").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Stations").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Asteroids").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Owner").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Friendly").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Neutral").Apply(LastDetectedEntity);
LastDetectedEntity.GetActionWithName("Detect Enemy").Apply(LastDetectedEntity);
```

##Solar Panel

Interface name: IMySolarPanel

Fields:
```C
None
```
Actions:None

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
	In construction;

```
####Code in C# set Actions:
```C
IMySolarPanel.GetActionWithName("OnOff").Apply(IMySolarPanel);  //change on to off and off to on 
IMySolarPanel.GetActionWithName("OnOff_On").Apply(IMySolarPanel); //turn on
IMySolarPanel.GetActionWithName("OnOff_Off").Apply(IMySolarPanel); //turn off

```

##Sound Block

Interface name: IMySoundBlock
Parent: IMyFunctionalBlock

Fields:


```C
float Volume 
float Range 
bool IsSoundSelected
float LoopPeriod
```

Terminal properties:

* VolumeSlider->Single
* RangeSlider->Single
* LoopableSlider->Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseVolumeSlider -> Increase Volume
* DecreaseVolumeSlider -> Decrease Volume
* IncreaseRangeSlider -> Increase Range
* DecreaseRangeSlider -> Decrease Range
* PlaySound -> Play
* StopSound -> Stop
* IncreaseLoopableSlider -> Increase Loop time
* DecreaseLoopableSlider -> Decrease Loop time

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
IMySoundBlock.SetValueFloat("VolumeSlider", 60.0f);
IMySoundBlock.SetValueFloat("RangeSlider", 60.0f);
IMySoundBlock.SetValueFloat("LoopableSlider", 60.0f);

```
####Code in c# set Actions:
```C
IMySoundBlock.GetActionWithName("OnOff").Apply(IMySoundBlock);  //change on to off and off to on 
IMySoundBlock.GetActionWithName("OnOff_On").Apply(IMySoundBlock); //turn on
IMySoundBlock.GetActionWithName("OnOff_Off").Apply(IMySoundBlock); //turn off
IMySoundBlock.GetActionWithName("IncreaseVolumeSlider").Apply(IMySoundBlock); 
IMySoundBlock.GetActionWithName("DecreaseVolumeSlider").Apply(IMySoundBlock);
IMySoundBlock.GetActionWithName("IncreaseRangeSlider").Apply(IMySoundBlock);
IMySoundBlock.GetActionWithName("DecreaseRangeSlider").Apply(IMySoundBlock);
IMySoundBlock.GetActionWithName("PlaySound").Apply(IMySoundBlock);
IMySoundBlock.GetActionWithName("StopSound").Apply(IMySoundBlock);
IMySoundBlock.GetActionWithName("IncreaseLoopableSlider").Apply(IMySoundBlock);
IMySoundBlock.GetActionWithName("DecreaseLoopableSlider").Apply(IMySoundBlock);
```

##Spherical Gravity Generator##


Interface name: IMyGravityGeneratorSphere

Parent: IMyGravityGeneratorBase

Parent: IMyFunctionalBlock


Fields:

```C
float Radius 
float Gravity
```
Terminal properties:
* Radius -> Single
* Gravity -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseRadius -> Increase Radius
* DecreaseRadius -> Decrease Radius
* IncreaseGravity -> Increase Acceleration
* DecreaseGravity -> Decrease Acceleration

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
IMyGravityGeneratorSphere.SetValueFloat("Radius", 60.0f);
IMyGravityGeneratorSphere.SetValueFloat("Gravity", 60.0f);

```
####Code in c# set Actions:
```C
IMyGravityGeneratorSphere.GetActionWithName("OnOff").Apply(IMyGravityGeneratorSphere);  //change on to off and off to on 
IMyGravityGeneratorSphere.GetActionWithName("OnOff_On").Apply(IMyGravityGeneratorSphere); //turn on
IMyGravityGeneratorSphere.GetActionWithName("OnOff_Off").Apply(IMyGravityGeneratorSphere); //turn off
IMyGravityGeneratorSphere.GetActionWithName("IncreaseRadius").Apply(IMyGravityGeneratorSphere); 
IMyGravityGeneratorSphere.GetActionWithName("DecreaseRadius").Apply(IMyGravityGeneratorSphere);
IMyGravityGeneratorSphere.GetActionWithName("IncreaseGravity").Apply(IMyGravityGeneratorSphere); 
IMyGravityGeneratorSphere.GetActionWithName("DecreaseGravity").Apply(IMyGravityGeneratorSphere);
```

##Spotlight##

Interface name: IMyReflectorLight

Parent: IMyLightingBlock

Parent: IMyFunctionalBlock


Fields:


```C
float Radius
float Intensity
float BlinkIntervalSeconds
float BlinkLenght
float BlinkOffset
```

Terminal properties:
* Color -> Color
* Radius -> Single
* Falloff -> Single
* Intensity -> Single
* Blink Interval -> Single
* Blink Lenght -> Single
* Blink Offset -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseRadius -> Increase Radius
* DecreaseRadius -> Decrease Radius
* IncreaseBlink Interval -> Increase Blink Interval
* DecreaseBlink Interval -> Decrease Blink Interval
* IncreaseBlink Lenght -> Increase Blink Length
* DecreaseBlink Lenght -> Decrease Blink Length
* IncreaseBlink Offset -> Increase Blink Offset
* DecreaseBlink Offset -> Decrease Blink Offset

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
IMyReflectorLight.SetValueColor("Color", color_red);
IMyReflectorLight.SetValueFloat("Radius", 60.0f);
IMyReflectorLight.SetValueFloat("Falloff", 60.0f);
IMyReflectorLight.SetValueFloat("Intensity", 60.0f);
IMyReflectorLight.SetValueFloat("Blink Interval", 60.0f);
IMyReflectorLight.SetValueFloat("Blink Lenght", 60.0f);
IMyReflectorLight.SetValueFloat("Blink Offset", 60.0f);

```
####Code in c# set Actions:
```C
IMyReflectorLight.GetActionWithName("OnOff").Apply(IMyReflectorLight);  //change on to off and off to on 
IMyReflectorLight.GetActionWithName("OnOff_On").Apply(IMyReflectorLight); //turn on
IMyReflectorLight.GetActionWithName("OnOff_Off").Apply(IMyReflectorLight); //turn off
IMyReflectorLight.GetActionWithName("IncreaseRadius").Apply(IMyReflectorLight); 
IMyReflectorLight.GetActionWithName("DecreaseRadius").Apply(IMyReflectorLight); 
IMyReflectorLight.GetActionWithName("IncreaseBlink Interval").Apply(IMyReflectorLight); 
IMyReflectorLight.GetActionWithName("DecreaseBlink Interval").Apply(IMyReflectorLight); 
IMyReflectorLight.GetActionWithName("IncreaseBlink Lenght").Apply(IMyReflectorLight); 
IMyReflectorLight.GetActionWithName("DecreaseBlink Lenght").Apply(IMyReflectorLight); 
IMyReflectorLight.GetActionWithName("IncreaseBlink Offset").Apply(IMyReflectorLight); 
IMyReflectorLight.GetActionWithName("DecreaseBlink Offset").Apply(IMyReflectorLight); 

```

##Timer Block##

Interface name: IMyTimerBlock

Parent: IMyFunctionalBlock


Fields:


```C
bool IsCountingDown 
float TriggerDelay
```

Terminal properties:
* TriggerDelay -> Single

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* IncreaseTriggerDelay -> Increase Delay
* DecreaseTriggerDelay -> Decrease Delay
* TriggerNow -> Trigger now
* Start -> Start
* Stop -> Stop

Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
IMyTimerBlock.SetValueColor("TriggerDelay", 60.0f);
```
####Code in c# set Actions:
```C
IMyTimerBlock.GetActionWithName("OnOff").Apply(IMyTimerBlock);  //change on to off and off to on 
IMyTimerBlock.GetActionWithName("OnOff_On").Apply(IMyTimerBlock); //turn on
IMyTimerBlock.GetActionWithName("OnOff_Off").Apply(IMyTimerBlock); //turn off
IMyTimerBlock.GetActionWithName("Start").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("TriggerNow").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("Stop").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("DecreaseTriggerDelay").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("IncreaseTriggerDelay").Apply(IMyTimerBlock);

```

####Code _EXAMPLE_ for start the block with the C# Code:

```C
IMyTimerBlock.GetActionWithName("Start").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("TriggerNow").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("Stop").Apply(IMyTimerBlock);
```

##Warhead##

Interface name: IMyWarhead


Fields:

```C
bool IsCountingDown 
float DetonationTime
```

Terminal properties:
* DetonationTime -> Single 

Actions:
* IncreaseDetonationTime -> Increase Detonation time
* DecreaseDetonationTime -> Decrease Detonation time
* StartCountdown -> Start countdown
* StopCountdown -> Stop countdown
* Safety -> Safety On/Off
* Detonate -> Detonate

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
	In construction;

```
####Code in c# set Actions:
```C
IMyWarhead.GetActionWithName("OnOff").Apply(IMyWarhead);  //change on to off and off to on 
IMyWarhead.GetActionWithName("OnOff_On").Apply(IMyWarhead); //turn on
IMyWarhead.GetActionWithName("OnOff_Off").Apply(IMyWarhead); //turn off
IMyWarhead.GetActionWithName("Detonate").Apply(IMyWarhead);
IMyWarhead.GetActionWithName("Safety").Apply(IMyWarhead);
IMyWarhead.GetActionWithName("StopCountdown").Apply(IMyWarhead);
IMyWarhead.GetActionWithName("StartCountdown").Apply(IMyWarhead);
IMyWarhead.GetActionWithName("DecreaseDetonationTime").Apply(IMyWarhead);
IMyWarhead.GetActionWithName("IncreaseDetonationTime").Apply(IMyWarhead);
```

##Welder##

Interface name: IMyShipWelder

Parent: IMyShipToolBase

Parent: IMyFunctionalBlock

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
	In construction;

```
####Code in C# set Actions:
```C
	IMyShipWelder.GetActionWithName("OnOff").Apply(IMyShipWelder); //change on to off and off to on 
    IMyShipWelder.GetActionWithName("OnOff_On").Apply(IMyShipWelder);//turn on
    IMyShipWelder.GetActionWithName("OnOff_Off").Apply(IMyShipWelder);//turn off

```

##Wheel Suspension 1x1##

Interface name: IMyMotorSuspension

Parent: IMyMotorBase

Parent: IMyFunctionalBlock


Fields:

```C
bool Steering 
bool Propulsion 
float Damping 
float Strength 
float Friction 
float Power
```
Terminal properties:
* Damping -> Single
* Strength -> Single
* Friction -> Single
* Power -> Single 

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Steering -> Steering On/Off
* Propulsion -> Propulsion On/Off
* IncreaseDamping -> Increase Damping
* DecreaseDamping -> Decrease Damping
* IncreaseStrength -> Increase Strength
* DecreaseStrength -> Decrease Strength
* IncreaseFriction -> Increase Friction
* DecreaseFriction -> Decrease Friction
* IncreasePower -> Increase Power
* DecreasePower -> Decrease Power

####Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
IMyMotorSuspension.SetValueFloat("Damping", 1.0f);
IMyMotorSuspension.SetValueFloat("Strength", 1.0f);
IMyMotorSuspension.SetValueFloat("Friction", 1.0f);
IMyMotorSuspension.SetValueFloat("Power", 1.0f);

```
####Code in c# set Actions:
```C
IMyMotorSuspension.GetActionWithName("OnOff").Apply(IMyMotorSuspension); //change on to off and off to on 
IMyMotorSuspension.GetActionWithName("OnOff_On").Apply(IMyMotorSuspension);//turn on
IMyMotorSuspension.GetActionWithName("OnOff_Off").Apply(IMyMotorSuspension);//turn off
IMyMotorSuspension.GetActionWithName("Steering").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("IncreaseDamping").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("DecreaseDamping").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("IncreaseStrength").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("DecreaseStrength").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("IncreaseFriction").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("DecreaseFriction").Apply(IMyMotorSuspension);

```

##Wheel Suspension 3x3##

Interface name: IMyMotorSuspension

Parent: IMyMotorBase

Parent: IMyFunctionalBlock


Fields:

```C
bool Steering 
bool Propulsion 
float Damping 
float Strength 
float Friction 
float Power
```
Terminal properties:
* Damping -> Single
* Strength -> Single
* Friction -> Single
* Power -> Single

Actions:

* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Steering -> Steering On/Off
* Propulsion -> Propulsion On/Off
* IncreaseDamping -> Increase Damping
* DecreaseDamping -> Decrease Damping
* IncreaseStrength -> Increase Strength
* DecreaseStrength -> Decrease Strength
* IncreaseFriction -> Increase Friction
* DecreaseFriction -> Decrease Friction
* IncreasePower -> Increase Power
* DecreasePower -> Decrease Power

Code Class in C# :
```C
	In construction;

```
####Code in C# set terminal values:
```C
IMyMotorSuspension.SetValueFloat("Damping", 1.0f);
IMyMotorSuspension.SetValueFloat("Strength", 1.0f);
IMyMotorSuspension.SetValueFloat("Friction", 1.0f);
IMyMotorSuspension.SetValueFloat("Power", 1.0f);

```
####Code in c# set Actions:
```C
IMyMotorSuspension.GetActionWithName("OnOff").Apply(IMyMotorSuspension); //change on to off and off to on 
IMyMotorSuspension.GetActionWithName("OnOff_On").Apply(IMyMotorSuspension);//turn on
IMyMotorSuspension.GetActionWithName("OnOff_Off").Apply(IMyMotorSuspension);//turn off
IMyMotorSuspension.GetActionWithName("Steering").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("IncreaseDamping").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("DecreaseDamping").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("IncreaseStrength").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("DecreaseStrength").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("IncreaseFriction").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("DecreaseFriction").Apply(IMyMotorSuspension);

```

##Wheel Suspension 5x5##

Interface name: IMyMotorSuspension
Parent: IMyMotorBase
Parent: IMyFunctionalBlock


Fields:

```C
bool Steering 
bool Propulsion 
float Damping 
float Strength 
float Friction 
float Power
```

Terminal properties:

* Damping -> Single
* Strength -> Single
* Friction -> Single
* Power -> Single 

Actions:

* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Steering -> Steering On/Off
* Propulsion -> Propulsion On/Off
* IncreaseDamping -> Increase Damping
* DecreaseDamping -> Decrease Damping
* IncreaseStrength -> Increase Strength
* DecreaseStrength -> Decrease Strength
* IncreaseFriction -> Increase Friction
* DecreaseFriction -> Decrease Friction
* IncreasePower -> Increase Power
* DecreasePower -> Decrease Power

Terminal block and action name list - 5/5

####Code Class in C# :
```C
In construction;
```

####Code in c# set terminal values:
```C
IMyMotorSuspension.SetValueFloat("Damping", 1.0f);
IMyMotorSuspension.SetValueFloat("Strength", 1.0f);
IMyMotorSuspension.SetValueFloat("Friction", 1.0f);
IMyMotorSuspension.SetValueFloat("Power", 1.0f);
```
####Code in c# get Actions:
```C
IMyMotorSuspension.GetActionWithName("OnOff").Apply(IMyMotorSuspension); //change on to off and off to on 
IMyMotorSuspension.GetActionWithName("OnOff_On").Apply(IMyMotorSuspension);//turn on
IMyMotorSuspension.GetActionWithName("OnOff_Off").Apply(IMyMotorSuspension);//turn off
IMyMotorSuspension.GetActionWithName("Steering").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("IncreaseDamping").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("DecreaseDamping").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("IncreaseStrength").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("DecreaseStrength").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("IncreaseFriction").Apply(IMyMotorSuspension);
IMyMotorSuspension.GetActionWithName("DecreaseFriction").Apply(IMyMotorSuspension);
```
##Text panel###
It is used to enable LCD pannel and TextPanes

Interface name: IMyTextPanel
Parent: IMyFunctionalBlock

Actions:

* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

Terminal properties :

* FontSize -> Single
* FontColor -> Color
* BackgroundColor->Color

####Code Class in C# :
```C
class ImyTextPanel {

	bool WritePublicText(string value, bool append = false);
	string GetPublicText(); // return actual text in public textfield,shown or not in the panel
	bool WritePublicTitle(string value, bool append = false);
	string GetPublicTitle();
	void AddImageToSelection(string id);
	void AddImagesToSelection(List<string> ids);
	void ShowPublicTextOnScreen();
	void ShowTextureOnScreen();

}
```
####Code in C# get Actions:

```C
IMyTextPanel.GetActionWithName("OnOff").Apply(IMyTextPanel); //change on to off and off to on 
IMyTextPanel.GetActionWithName("OnOff_On").Apply(IMyTextPanel);//turn on
IMyTextPanel.GetActionWithName("OnOff_Off").Apply(IMyTextPanel);//turn off
```
####Code example in C#:
```C
var lcd_name = "name_of_your_LCD";
//LCD must be plugged on public mode

void Main() {
	 var GridTerminalSystem = GridTerminalSystem;	
     IMyTextPanel LCD = GridTerminalSystem.GetBlockWithName(lcd_name) as IMyTextPanel;
     LCD.WritePublicText("Hello world",false); //clear the screen and print Hello world     
     LCD.ShowTextureOnScreen();  //show text on LCD screen
     LCD.ShowPublicTextOnScreen();  // shot text on Public mode
     LCD.GetPrivateText(); // get the private text of the private-box
}
```
More:

|Method | Return Type | Description|
|--------|----------|----------------|
|HasLocalPlayerAccess()         | boolean | If a player has Access|
|HasPlayerAccess(long playerId) | boolean | ... | 
|RequestShowOnHUD(bool enable)  | void    | ... | 
|SetCustomName(string text)     | void    | Set name of block | 
|SetCustomName(StringBuilder text) | void | Set name of block | 
|GetActions(List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null) | void | Aviable actions | 
|GetActionWithName(string name) | ITerminalAction | ... | 
|ApplyAction(string actionName) | void    | ... | 

##Sources:

Space Engineers oficial:

http://spaceengineers.io/spaceengineers/doc/namespaceSandbox_1_1ModAPI_1_1Ingame.html

Space Engineers wiki:

* http://www.spaceengineerswiki.com/Scripting_API_Documentation
* http://www.spaceengineerswiki.com/Programming

Space Engineers Game:

http://store.steampowered.com/app/244850/

Space Engineers Workshop:

https://steamcommunity.com/workshop/browse/?appid=244850

KeenSoftwareHouse:

* https://github.com/KeenSoftwareHouse
* https://github.com/KeenSoftwareHouse/SpaceEngineers/tree/master/Sources/Sandbox.Common/ModAPI
* https://github.com/KeenSoftwareHouse/SpaceEngineers/tree/master/Sources/Sandbox.Common/ModAPI/Ingame
