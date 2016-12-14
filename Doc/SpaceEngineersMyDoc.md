

 ![alt text](http://fukkit.net/media/SpaceEngineers.png)

#                 Space Engineers

by **Carlos Durán**




Generic blocks var:
```c
bool Enabled
string 	CustomName
string 	CustomNameWithFaction
string 	DetailedInfo
bool 	ShowOnHUD
```


Fields:
only read properties;

Terminal properties:
modifycable properties;


----------------------
----------------------

##Antenna##

Interface name: IMyRadioAntenna
Parent: IMyFunctionalBlock


Fields:
```c 
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
```c
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
```c
	In construction;

```
####Code in C# set Actions:
```c
IMyRadioAntenna.GetActionWithName("OnOff").Apply(IMyRadioAntenna); //change on to off and off to on 
IMyRadioAntenna.GetActionWithName("OnOff_On").Apply(IMyRadioAntenna);//turn on
IMyRadioAntenna.GetActionWithName("OnOff_Off").Apply(IMyRadioAntenna);//turn off
IMyRadioAntenna.GetActionWithName("IncreaseRadius").Apply(IMyRadioAntenna);//Increase Radius of action
IMyRadioAntenna.GetActionWithName("DecreaseRadius").Apply(IMyRadioAntenna);//Reduce Radius of action
```
####Code example in C#:
```c
var antenna_name = "name_of_your_Antenna";

void Main() {
	 var GridTerminalSystem = GridTerminalSystem;
     IMyRadioAntenna antenna = GridTerminalSystem.GetBlockWithName(antenna_name) as IMyRadioAntenna;
     
}
```

##Arc furnace##

Interface name: IMyRefinery
Parent: IMyProductionBlock
Parent: IMyFunctionalBlock

Fields:
```c
 bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off
Code Class in C# :
```c
class IMyRefinery {

	bool UseConveyorSystem;

}
```
####Code in C# set terminal values:
```c
	public interface IMyRefinery : IMyProductionBlock, Ingame.IMyRefinery
    {

    }

```
####Code in C# set Actions:
```c
	In construction;

```
####Code example in C#
```c
	var GridTerminalSystem = GridTerminalSystem;
	var IMyRefinery = GridTerminalSystem.GetBlockWithName("Refinery") as IMyRefinery;
```

##Artificial Mass##

Interface name: IMyVirtualMass
Parent: IMyFunctionalBlock

Fields:
* None

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off

####Code Class in C# :
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Assembler##

Interface name: IMyAssembler

Parent: IMyProductionBlock

Parent: IMyFunctionalBlock

Fields:
```c
 bool UseConveyorSystem
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```c
	public interface IMyAssembler : IMyProductionBlock
    {
        bool DisassembleEnabled { get; }
    }
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Battery##

Interface name: IMyBatteryBlock

Parent: IMyFunctionalBlock

Fields:
```c
 bool HasCapacityRemaining
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Recharge -> Recharge On/Off

####Code Class in C# :
```c
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
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Beacon##

Interface name: IMyBeacon
Parent: IMyFunctionalBlock

Fields:
```c
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
```c
	public interface IMyBeacon : IMyFunctionalBlock
    {
        float Radius { get; }
    }
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Button Panel##
Interface name: IMyButtonPanel

Fields:
```c
 bool AnyoneCanUse
 ```
Actions:
* AnyoneCanUse -> Anyone Can Use On/Off

####Code Class in C# :
```c
	In construction;
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Camera##

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
```c
	public interface IMyCameraBlock:IMyFunctionalBlock
    {

    }
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Cockpit##

Interface name: IMyCockpit 
Parent: IMyShipController


Fields:

```c
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
```c
 	bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```c
	public interface IMyCockpit : IMyShipController
    {

    }
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Connector##

Interface name: IMyShipConnector

Parent: IMyFunctionalBlock

Fields:

```c
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
```c
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
```c
	In construction;

```

##Control Panel##

Interface name: IMyControlPanel

Fields:
* None

Actions: 
* None

####Code Class in C# :
```c
	In construction;
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Control Station##

Interface name: IMyCockpit

Parent: IMyShipController

Fields:

```c
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
```c
	In construction;
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

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
```c
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
```c

door1.GetActionWithName("Open_Off").Apply(door1);
door2.GetActionWithName("OnOff_On").Apply(door2);
door2.GetActionWithName("Open").Apply(door2);
```

##Drill##

Interface name: IMyShipDrill
Parent: IMyFunctionalBlock


Fields:

```c
 bool UseConveyorSystem

```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```c
	In construction;
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Flight Seat##

Interface name: IMyCockpit
Parent: IMyShipController


Fields:

```c
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
```c
	In construction;
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Gatling Turret##

Interface name: IMyLargeGatlingTurret
Parent: IMyLargeConveyorTurretBase
Parent: IMyLargeTurretBase
Parent: IMyFunctionalBlock


Fields:

```c
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
```c
	In construction;
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Gravity Generator##

Interface name: IMyGravityGenerator

Parent: IMyGravityGeneratorBase

Parent: IMyFunctionalBlock


Fields:

```c
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
```c
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
```c
	public interface IMyShipGrinder : IMyShipToolBase
    {

    }
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Gyroscope##

Interface name: IMyGyro
Parent: IMyFunctionalBlock


Fields:

```c
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
```c
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
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Interior Light##

Interface name: IMyInteriorLight
Parent: IMyLightingBlock
Parent: IMyFunctionalBlock


Fields:


```c
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
```c
	In construction;
```
####Code in C# set Actions:
```c
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
```c
	In construction;
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

Fields:


```c
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
```c
	In construction;
```
####Code in C# set Actions:
```c
IMyLargeInteriorTurret.SetValueFloat("Radius", 60.0f);
```

##Landing Gear##

Interface name: IMyLandingGear
Parent: IMyFunctionalBlock


Fields:
```c
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
```c
	In construction;
```

####Code in c# to set values to 

```c
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

```c
bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code class in c#:

```c
class IMyReactor{
	bool UseConveyorSystem; // read only
}
```
####Code example in C#:

```c
void Main(){
	 var GridTerminalSystem = GridTerminalSystem;
	 IMyReactor  reactor  = GridTerminalSystem.GetBlockWithName("rec") as IMyReactor; 
	 bool is_fuctional = reactor.IsFuctional;// return true if reactor is working	 
     bool y = reactor.UseConveyorSystem;// if it is connect to others
}
```

##Large Reactor##

Interface name: IMyReactor

Parent: IMyFunctionalBlock

Fields:
```c
 bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

##Small Thruster##

Interface name: IMyThrust
Parent: IMyFunctionalBlock


Fields:
 
```c
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
```c
	In construction;
```

####Code in c# to set values to 
Fields:

```c
	IMyThrust.SetValueFloat("Override", 60.0f);
```


##Large Thruster##

Interface name: IMyThrust

Parent: IMyFunctionalBlock


Fields:
 
```c
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
```c
	In construction;
```

####Code in c# to set values to 
Fields:

```c
IMyThrust.SetValueFloat("Override", 60.0f);
```
##Medical Room##

Interface name: IMyMedicalRoom
Parent: IMyFunctionalBlock

Fields:
 None

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off

####Code Class in C# :
```c
	In construction;
```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Merge Block##

Interface name: IMyShipMergeBlock
Parent: IMyFunctionalBlock

Fields:
 None
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off

##Missile Turret##

Interface name: IMyLargeMissileTurret

Parent: IMyLargeConveyorTurretBase

Parent: IMyLargeTurretBase

Parent: IMyFunctionalBlock

####Code Class in C# :
```c
	In construction;
```
####Code in C# set terminal values:
```c
	In construction;
```
####Code in C# set Actions:
```c
	In construction;
```

Fields:

```c
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
```c
	In construction;
```
####Code in C# set terminal values:
```c

IMyLargeMissileTurret.SetValueFloat("Range", 60.0f);

```
####Code in C# set Actions:
```c
	In construction;

```

##Ore Detector##

Interace name: IMyOreDetector

Parent: IMyFunctionalBlock

Fields:

```c
float Range 
bool BroadcastUsingAntennas 
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Terminal block and action name list - 3/5

####Code Class in C# :
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Passenger Seat##

Interface name: IMyCockpit

Parent: IMyShipController

Fields:

```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Piston##

Interface name: IMyPistonBase
Parent: IMyFunctionalBlock


Fields:

```c
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
```c

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

```c
IMyPistonBase.SetValueFloat("Velocity", 60.0f);
IMyPistonBase.SetValueFloat("UpperLimit", 60.0f);
IMyPistonBase.SetValueFloat("LowerLimit", 60.0f);
```
####Code in C# set Actions:
```c
	In construction;

```

##Programmable block##

Interface name: IMyProgrammableBlock
Parent: IMyFunctionalBlock

Fields:
 
```c
bool IsRunning
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* Run -> Run

####Code Class in C# :
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Projector##

Interface name: IMyProjector

Parent: IMyFunctionalBlock


Fields:

```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
IMyProjector.SetValueFloat("X", 60.0f);
IMyProjector.SetValueFloat("Y", 60.0f);
IMyProjector.SetValueFloat("Z", 60.0f);
IMyProjector.SetValueFloat("RotX", 60.0f);
IMyProjector.SetValueFloat("RotY", 60.0f);
IMyProjector.SetValueFloat("RotZ", 60.0f);
```
####Code in C# set Actions:
```c
	In construction;
```

##Reloadable Rocket Launcher##

Interface name: IMySmallMissileLauncherReload
Parent: IMyFunctionalBlock

Fields:
 
```c
bool UseConveyorSystem
```
Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Refinery##

Interface name: IMyRefinery
Parent: IMyFunctionalBlock
Parent: IMyProductionBlock


Fields:
```c
bool UseConveyorSystem
```

Actions:
* OnOff -> Toggle block On/Off
* OnOff_On -> Toggle block On
* OnOff_Off -> Toggle block Off
* UseConveyor -> Use Conveyor System On/Off

####Code Class in C# :
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Remote Control##

Interface name: IMyRemoteControl

Parent: IMyShipController

Fields:


```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	In construction;

```

##Rocket Launcher##

Interface name: IMySmallMissileLauncher

Parent: IMyFunctionalBlock

Fields:

```c
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


```c
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
```c
	In construction;
```
####Code in C# set terminal values:

```c
IMyMotorStator.SetValueFloat("Torque", 60.0f);
IMyMotorStator.SetValueFloat("BrakingTorque", 60.0f);
IMyMotorStator.SetValueFloat("Velocity", 60.0f);
IMyMotorStator.SetValueFloat("LowerLimit", 60.0f);
IMyMotorStator.SetValueFloat("UpperLimit", 60.0f);
IMyMotorStator.SetValueFloat("Displacement", 60.0f);
```
####Code in c# set Actions:
```c
	In construction;

```

##Sensor##

Interface name: IMySensorBlock

Parent: IMyFunctionalBlock


Fields:

```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
	LastDetectedEntity.SetValueFloat("Left", 60.0f);
	LastDetectedEntity.SetValueFloat("Right", 60.0f);
	LastDetectedEntity.SetValueFloat("Bottom", 60.0f);
	LastDetectedEntity.SetValueFloat("Top", 60.0f);
	LastDetectedEntity.SetValueFloat("Back", 60.0f);
	LastDetectedEntity.SetValueFloat("Front", 60.0f);

```
####Code in c# set Actions:
```c
	In construction;

```

##Solar Panel##

Interface name: IMySolarPanel

Fields:
```c
None
```
Actions:None

####Code Class in C# :
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in c# set Actions:
```c
	In construction;

```

##Sound Block##

Interface name: IMySoundBlock
Parent: IMyFunctionalBlock

Fields:


```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
	IMySoundBlock.SetValueFloat("VolumeSlider", 60.0f);
	IMySoundBlock.SetValueFloat("RangeSlider", 60.0f);
	IMySoundBlock.SetValueFloat("LoopableSlider", 60.0f);

```
####Code in c# set Actions:
```c
	In construction;

```

##Spherical Gravity Generator##


Interface name: IMyGravityGeneratorSphere

Parent: IMyGravityGeneratorBase

Parent: IMyFunctionalBlock


Fields:

```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
	IMyGravityGeneratorSphere.SetValueFloat("Radius", 60.0f);
	IMyGravityGeneratorSphere.SetValueFloat("Gravity", 60.0f);

```
####Code in c# set Actions:
```c
	In construction;

```

##Spotlight##

Interface name: IMyReflectorLight

Parent: IMyLightingBlock

Parent: IMyFunctionalBlock


Fields:


```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
	IMyReflectorLight.SetValueColor("Color", color_red);
	IMyReflectorLight.SetValueFloat("Radius", 60.0f);
	IMyReflectorLight.SetValueFloat("Falloff", 60.0f);
	IMyReflectorLight.SetValueFloat("Intensity", 60.0f);
	IMyReflectorLight.SetValueFloat("Blink Interval", 60.0f);
	IMyReflectorLight.SetValueFloat("Blink Lenght", 60.0f);
	IMyReflectorLight.SetValueFloat("Blink Offset", 60.0f);

```
####Code in c# set Actions:
```c
	In construction;

```

##Timer Block##

Interface name: IMyTimerBlock

Parent: IMyFunctionalBlock


Fields:


```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in c# set Actions:
```c
	In construction;

```

####Code _EXAMPLE_ for start the block with the C# Code:

```c
IMyTimerBlock.GetActionWithName("Start").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("TriggerNow").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("Stop").Apply(IMyTimerBlock);
```

##Warhead##

Interface name: IMyWarhead


Fields:

```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in c# set Actions:
```c
	In construction;

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
```c
	In construction;

```
####Code in C# set terminal values:
```c
	In construction;

```
####Code in C# set Actions:
```c
	IMyShipWelder.GetActionWithName("OnOff").Apply(IMyShipWelder); //change on to off and off to on 
    IMyShipWelder.GetActionWithName("OnOff_On").Apply(IMyShipWelder);//turn on
    IMyShipWelder.GetActionWithName("OnOff_Off").Apply(IMyShipWelder);//turn off

```

##Wheel Suspension 1x1##

Interface name: IMyMotorSuspension

Parent: IMyMotorBase

Parent: IMyFunctionalBlock


Fields:

```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
IMyMotorSuspension.SetValueFloat("Damping", 1.0f);
IMyMotorSuspension.SetValueFloat("Strength", 1.0f);
IMyMotorSuspension.SetValueFloat("Friction", 1.0f);
IMyMotorSuspension.SetValueFloat("Power", 1.0f);

```
####Code in c# set Actions:
```c
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

```c
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
```c
	In construction;

```
####Code in C# set terminal values:
```c
IMyMotorSuspension.SetValueFloat("Damping", 1.0f);
IMyMotorSuspension.SetValueFloat("Strength", 1.0f);
IMyMotorSuspension.SetValueFloat("Friction", 1.0f);
IMyMotorSuspension.SetValueFloat("Power", 1.0f);

```
####Code in c# set Actions:
```c
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

```c
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
```c
	In construction;

```

####Code in c# set terminal values:
```c
IMyMotorSuspension.SetValueFloat("Damping", 1.0f);
IMyMotorSuspension.SetValueFloat("Strength", 1.0f);
IMyMotorSuspension.SetValueFloat("Friction", 1.0f);
IMyMotorSuspension.SetValueFloat("Power", 1.0f);
```
####Code in c# get Actions:
```c
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
```c
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

```c
IMyTextPanel.GetActionWithName("OnOff").Apply(IMyTextPanel); //change on to off and off to on 
IMyTextPanel.GetActionWithName("OnOff_On").Apply(IMyTextPanel);//turn on
IMyTextPanel.GetActionWithName("OnOff_Off").Apply(IMyTextPanel);//turn off
```
####Code example in C#:
```c
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
