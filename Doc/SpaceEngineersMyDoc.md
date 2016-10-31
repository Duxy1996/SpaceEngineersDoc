Generic blocks var:
bool Enabled
string 	CustomName
string 	CustomNameWithFaction
string 	DetailedInfo
bool 	ShowOnHUD

Fields: only read properties;
Terminal properties: modifycable properties;

####Antenna####

Interface name: IMyRadioAntenna
Parent: IMyFunctionalBlock

Fields: 
float Radius

Terminal properties: 
Radius -> Single

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Broadcast radius
DecreaseRadius -> Decrease Broadcast radius

Code in c# execute orders:

IMyRadioAntenna.GetActionWithName("OnOff").Apply(IMyRadioAntenna); //change on to off and off to on 
IMyRadioAntenna.GetActionWithName("OnOff_On").Apply(IMyRadioAntenna);//turn on
IMyRadioAntenna.GetActionWithName("OnOff_Off").Apply(IMyRadioAntenna);//turn off
IMyRadioAntenna.GetActionWithName("IncreaseRadius").Apply(IMyRadioAntenna);//Increase Radius of action
IMyRadioAntenna.GetActionWithName("DecreaseRadius").Apply(IMyRadioAntenna);//Reduce Radius of action

code in c# :

class IMyRadioAntenna {
	/// Broadcasting/Receiving range (read-only)
	float Radius;
	/// Show shipname on hud (read-only)
	bool ShowShipName;
	/// Returns true if antena is broadcasting (read-only)
	bool IsBroadcasting;
}

Code example in C#:

var antenna_name = "name_of_your_LCD";
//LCD must be plugged on public mode
void Main() {

     IMyRadioAntenna antenna = GridTerminalSystem.GetBlockWithName(antenna_name) as IMyRadioAntenna;
     
}


####Arc furnace####

Interface name: IMyRefinery
Parent: IMyProductionBlock
Parent: IMyFunctionalBlock
Fields: bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

code in c# :

class IMyRefinery {
	bool UseConveyorSystem;
}

####Artificial Mass####

Interface name: IMyVirtualMass
Parent: IMyFunctionalBlock
Fields: None
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off

####Assembler####

Interface name: IMyAssembler
Parent: IMyProductionBlock
Parent: IMyFunctionalBlock
Fields: bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

####Battery####

Interface name: IMyBatteryBlock
Parent: IMyFunctionalBlock
Fields: bool HasCapacityRemaining
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Recharge -> Recharge On/Off

####Beacon####

Interface name: IMyBeacon
Parent: IMyFunctionalBlock
Fields: float Radius
Terminal properties:
Radius -> Single
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Broadcast radius
DecreaseRadius -> Decrease Broadcast radius

####Button Panel####
Interface name: IMyButtonPanel
Fields: bool AnyoneCanUse
Actions:
AnyoneCanUse -> Anyone Can Use On/Off

####Camera####
Interface name: IMyCameraBlock
Parent: IMyFunctionalBlock
Fields: None
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
View -> View

####Cockpit####

Interface name: IMyCockpit
Parent: IMyShipController
Fields:
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride
Actions:
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off

####Collector####

Interface name: IMyCollector
Parent: IMyFunctionalBlock
Fields: bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

####Connector####

Interface name: IMyShipConnector
Parent: IMyFunctionalBlock
Fields:
bool ThrowOut 
bool CollectAll 
bool IsLocked 
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
ThrowOut -> Throw Out On/Off
CollectAll -> Collect All On/Off
SwitchLock -> Switch lock

####Control Panel####

Interface name: IMyControlPanel
Fields: None
Actions: None

####Control Station####

Interface name: IMyCockpit
Parent: IMyShipController
Fields:
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride
Actions:
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off

####Door####

Interface name: IMyDoor
Parent: IMyFunctionalBlock
Fields: bool Open
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Open -> Open/Closed
Open_On -> Open
Open_Off -> Closed

code for gettin actions:

	door1.GetActionWithName("Open_Off").Apply(door1);
    door2.GetActionWithName("OnOff_On").Apply(door2);
    door2.GetActionWithName("Open").Apply(door2);

####Drill####

Interface name: IMyShipDrill
Parent: IMyFunctionalBlock
Fields: bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

####Flight Seat####

Interface name: IMyCockpit
Parent: IMyShipController

Fields:
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride

Actions:
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off

####Gatling Turret####

Interface name: IMyLargeGatlingTurret
Parent: IMyLargeConveyorTurretBase
Parent: IMyLargeTurretBase
Parent: IMyFunctionalBlock

Fields:
bool UseConveyorSystem 
bool CanControl
float Range
Terminal properties:
Radius -> Single

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Control -> Control
IncreaseRange -> Increase Radius
DecreaseRange -> Decrease Radius
UseConveyor -> Use Conveyor System On/Off
Terminal block and action name list - 2/5

####Gravity Generator####

Interface name: IMyGravityGenerator
Parent: IMyGravityGeneratorBase
Parent: IMyFunctionalBlock

Fields:
float FieldWidth 
float FieldHeight 
float FieldDepth 
float Gravity

Terminal properties:
Width -> Single
Height -> Single
Depth -> Single
Gravity -> Single

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseWidth -> Increase Field width
DecreaseWidth -> Decrease Field width
IncreaseHeight -> Increase Field height
DecreaseHeight -> Decrease Field height
IncreaseDepth -> Increase Field depth
DecreaseDepth -> Decrease Field depth
IncreaseGravity -> Increase Acceleration
DecreaseGravity -> Decrease Acceleration

code in c# to set values to fields:

IMyGravityGenerator.SetValueFloat("Gravity", 1.0f);
IMyGravityGenerator.SetValueFloat("Width", 60.0f);
IMyGravityGenerator.SetValueFloat("Height", 60.0f);
IMyGravityGenerator.SetValueFloat("Depth", 60.0f);

####Grinder####

Interface name: IMyShipGrinder
Parent: IMyShipToolBase
Parent: IMyFunctionalBlock
Fields: None

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

####Gyroscope####

Interface name: IMyGyro
Parent: IMyFunctionalBlock

Fields:
float GyroPower 
bool GyroOverride 
float Yaw 
float Pitch 
float Roll 

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreasePower -> Increase Power
DecreasePower -> Decrease Power
Override -> Override controls On/Off
IncreaseYaw -> Increase Yaw override
DecreaseYaw -> Decrease Yaw override
IncreasePitch -> Increase Pitch override
DecreasePitch -> Decrease Pitch override
IncreaseRoll -> Increase Roll override
DecreaseRoll -> Decrease Roll override

####Interior Light####

Interface name: IMyInteriorLight
Parent: IMyLightingBlock
Parent: IMyFunctionalBlock

Fields:
float Radius
float Intensity
float BlinkIntervalSeconds
float BlinkLenght
float BlinkOffset

Terminal properties:
Color -> Color
Radius -> Single
Falloff -> Single
Intensity -> Single
Blink Interval -> Single
Blink Lenght -> Single
Blink Offset -> Single
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Radius
DecreaseRadius -> Decrease Radius
IncreaseBlink Interval -> Increase Blink Interval
DecreaseBlink Interval -> Decrease Blink Interval
IncreaseBlink Lenght -> Increase Blink Length
DecreaseBlink Lenght -> Decrease Blink Length
IncreaseBlink Offset -> Increase Blink Offset
DecreaseBlink Offset -> Decrease Blink Offset

code in c# to set values to fields:

IMyInteriorLight.SetValueColor("Color", Color);
IMyInteriorLight.SetValueFloat("Radius", 60.0f);
IMyInteriorLight.SetValueFloat("Falloff", 60.0f);
IMyInteriorLight.SetValueFloat("Intensity", 60.0f);
IMyInteriorLight.SetValueFloat("Blink Interval", 60.0f);
IMyInteriorLight.SetValueFloat("Blink Lenght", 60.0f);
IMyInteriorLight.SetValueFloat("Blink Offset", 60.0f);

####Interior Turret####

Interface name: IMyLargeInteriorTurret
Parent: IMyLargeTurretBase
Parent: IMyFunctionalBlock

Fields:
bool CanControl
float Range
Terminal properties:
Radius -> Single

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Control -> Control
IncreaseRange -> Increase Radius
DecreaseRange -> Decrease Radius

code in c# to set values to fields:

IMyLargeInteriorTurret.SetValueFloat("Radius", 60.0f);

####Landing Gear####

Interface name: IMyLandingGear
Parent: IMyFunctionalBlock

Fields:
float BreakForce

Terminal properties:
BreakForce -> Single

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Lock -> Lock
Unlock -> Unlock
SwitchLock -> Switch lock
Autolock -> Autolock On/Off
IncreaseBreakForce -> Increase Break Force
DecreaseBreakForce -> Decrease Break Force

code in c# to set values to fields:

IMyLandingGear.SetValueFloat("BreakForce", 60.0f);

####Small Cargo Container####

Interface name: IMyCargoContainer
Fields: None
Actions: None

Medium Cargo Container
Interface name: IMyCargoContainer
Fields: None
Actions:None

####Large Cargo Container####

Interface name: IMyCargoContainer
Fields: None
Actions: None

####Small Reactor####

Interface name: IMyReactor
Parent: IMyFunctionalBlock
Fields:
bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

code in c#:

class IMyReactor{



}

code example in c#:

void Main(){
	 IMyReactor  reactor  = GridTerminalSystem.GetBlockWithName("rec") as IMyReactor; 
	 bool is_fuctional = reactor.IsFuctional;// return true if reactor is working	 
     bool y = reactor.UseConveyorSystem;// if it is connect to others
}


####Large Reactor####

Interface name: IMyReactor
Parent: IMyFunctionalBlock
Fields: bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

####Small Thruster####
Interface name: IMyThrust
Parent: IMyFunctionalBlock

Fields: float ThrustOverride

Terminal properties:
Override -> Single

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseOverride -> Increase Thrust override
DecreaseOverride -> Decrease Thrust override

code in c# to set values to fields:

IMyThrust.SetValueFloat("Override", 60.0f);



####Large Thruster####

Interface name: IMyThrust
Parent: IMyFunctionalBlock

Fields: 
float ThrustOverride

Terminal properties:
Override -> Single
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseOverride -> Increase Thrust override
DecreaseOverride -> Decrease Thrust override

code in c# to set values to fields:

IMyThrust.SetValueFloat("Override", 60.0f);

####Medical Room####

Interface name: IMyMedicalRoom
Parent: IMyFunctionalBlock
Fields: None
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off

####Merge Block####

Interface name: IMyShipMergeBlock
Parent: IMyFunctionalBlock
Fields: None
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off

####Missile Turret####

Interface name: IMyLargeMissileTurret
Parent: IMyLargeConveyorTurretBase
Parent: IMyLargeTurretBase
Parent: IMyFunctionalBlock

Fields:
bool UseConveyorSystem 
bool CanControl
float Range

Terminal properties:
Range -> Single

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Control -> Control
IncreaseRange -> Increase Radius
DecreaseRange -> Decrease Radius
UseConveyor -> Use Conveyor System On/Of

code in c# to set values to fields:

IMyLargeMissileTurret.SetValueFloat("Range", 60.0f);

####Ore Detector####

Interace name: IMyOreDetector
Parent: IMyFunctionalBlock
Fields:
float Range 
bool BroadcastUsingAntennas 
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Terminal block and action name list - 3/5
Passenger Seat
Interface name: IMyCockpit
Parent: IMyShipController
Fields:
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride
Actions:
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off

####Piston####

Interface name: IMyPistonBase
Parent: IMyFunctionalBlock

Fields:
float Velocity 
float MinLimit 
float MaxLimit

Terminal properties:
Velocity -> Single
UpperLimit -> Single
LowerLimit -> Single 

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Reverse -> Reverse
IncreaseVelocity -> Increase Velocity
DecreaseVelocity -> Decrease Velocity
ResetVelocity -> Reset Velocity
IncreaseUpperLimit -> Increase Maximal distance
DecreaseUpperLimit -> Decrease Maximal distance
IncreaseLowerLimit -> Increase Minimal distance
DecreaseLowerLimit -> Decrease Minimal distance

code in c# to set values to fields:

IMyPistonBase.SetValueFloat("Velocity", 60.0f);
IMyPistonBase.SetValueFloat("UpperLimit", 60.0f);
IMyPistonBase.SetValueFloat("LowerLimit", 60.0f);

####Programmable block####

Interface name: IMyProgrammableBlock
Parent: IMyFunctionalBlock
Fields: bool IsRunning
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Run -> Run

####Projector####

Interface name: IMyProjector
Parent: IMyFunctionalBlock

Fields:
int ProjectionOffsetX 
int ProjectionOffsetY 
int ProjectionOffsetZ 
int ProjectionRotX 
int ProjectionRotY 
int ProjectionRotZ 

Terminal properties:
X -> Single
Y -> Single
Z -> Single
RotX -> Single
RotY -> Single
RotZ -> Single

Actions:
OnOff->Toggle block On/Off
OnOff_On->Toggle block On
OnOff_Off->Toggle block Off
IncreaseX->Increase Horizontal offset
DecreaseX->Decrease Horizontal offset
IncreaseY->Increase Vertical offset
DecreaseY->Decrease Vertical offset
IncreaseZ->Increase Forward offset
DecreaseZ->Decrease Forward offset
IncreaseRotX->Increase Pitch
DecreaseRotX->Decrease Pitch
IncreaseRotY->Increase Yaw
DecreaseRotY->Decrease Yaw
IncreaseRotZ->Increase Roll
DecreaseRotZ->Decrease Roll

code in c# to set values to fields:

IMyProjector.SetValueFloat("X", 60.0f);
IMyProjector.SetValueFloat("Y", 60.0f);
IMyProjector.SetValueFloat("Z", 60.0f);
IMyProjector.SetValueFloat("RotX", 60.0f);
IMyProjector.SetValueFloat("RotY", 60.0f);
IMyProjector.SetValueFloat("RotZ", 60.0f);


Reloadable Rocket Launcher
Interface name: IMySmallMissileLauncherReload
Parent: IMyFunctionalBlock
Fields: bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

####Refinery####

Interface name: IMyRefinery
Parent: IMyFunctionalBlock
Parent: IMyProductionBlock
Fields: bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Remote Control
Interface name: IMyRemoteControl
Parent: IMyShipController
Fields:
bool ControlWheels
bool ControlThrusters
bool HandBrake 
bool DampenersOverride
Actions:
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off
Control -> Control

#####Rocket Launcher######

Interface name: IMySmallMissileLauncher
Parent: IMyFunctionalBlock
Fields: bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

#####Rotor######

Interface name: IMyMotorStator
Parent: IMyMotorBase
Parent: IMyFunctionalBlock

Fields:
bool IsAttached 
float Torque
float BrakingTorque 
float Velocity 
float LowerLimit 
float UpperLimit 
float Displacement

Terminal properties:
Torque -> Single
BrakingTorque -> Single
Velocity -> Single
LowerLimit -> Single
UpperLimit -> Single
Displacement -> Single

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Reverse -> Reverse
Detach -> Detach
Attach -> Attach
IncreaseTorque -> Increase Torque
DecreaseTorque -> Decrease Torque
IncreaseBrakingTorque -> Increase Braking tor.
DecreaseBrakingTorque -> Decrease Braking tor.
IncreaseVelocity -> Increase Velocity
DecreaseVelocity -> Decrease Velocity
ResetVelocity -> Reset Velocity
IncreaseLowerLimit -> Increase Lower limit
DecreaseLowerLimit -> Decrease Lower limit
IncreaseUpperLimit -> Increase Upper limit
DecreaseUpperLimit -> Decrease Upper limit
IncreaseDisplacement -> Increase Rotor displacement
DecreaseDisplacement -> Decrease Rotor displacement
Terminal block and action name list - 4/5

code in c# to set values to fields:

IMyMotorStator.SetValueFloat("Torque", 60.0f);
IMyMotorStator.SetValueFloat("BrakingTorque", 60.0f);
IMyMotorStator.SetValueFloat("Velocity", 60.0f);
IMyMotorStator.SetValueFloat("LowerLimit", 60.0f);
IMyMotorStator.SetValueFloat("UpperLimit", 60.0f);
IMyMotorStator.SetValueFloat("Displacement", 60.0f);

#####Sensor#####

Interface name: IMySensorBlock
Parent: IMyFunctionalBlock

Fields:
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
IMyEntity LastDetectedEntity

Terminal properties:
Left -> Single
Right -> Single
Bottom -> Single
Top -> Single
Back -> Single
Front -> Single

Actions:
OnOff->Toggle block On/Off
OnOff_On->Toggle block On
OnOff_Off->Toggle block Off
IncreaseLeft->Increase Left extent
DecreaseLeft->Decrease Left extent
IncreaseRight->Increase Right extent
DecreaseRight->Decrease Right extent
IncreaseBottom->Increase Bottom extent
DecreaseBottom->Decrease Bottom extent
IncreaseTop->Increase Top extent
DecreaseTop->Decrease Top extent
IncreaseBack->Increase Back extent
DecreaseBack->Decrease Back extent
IncreaseFront->Increase Front extent
DecreaseFront->Decrease Front extent
Detect Players->Detect players On/Off
Detect Floating Objects->Detect floating objects On/Off
Detect Small Ships->Detect small ships On/Off
Detect Large Ships->Detect large ships On/Off
Detect Stations->Detect stations On/Off
Detect Asteroids->Detect asteroids On/Off
Detect Owner->Detect owner On/Off
Detect Friendly->Detect friendly On/Off
Detect Neutral->Detect neutral On/Off
Detect Enemy->Detect enemy On/Off

Solar Panel
Interface name: IMySolarPanel
Fields:None
Actions:None

Sound Block
Interface name: IMySoundBlock
Parent: IMyFunctionalBlock
Fields:
float Volume 
float Range 
bool IsSoundSelected
float LoopPeriod
Terminal properties:
VolumeSlider->Single
RangeSlider->Single
LoopableSlider->Single
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseVolumeSlider -> Increase Volume
DecreaseVolumeSlider -> Decrease Volume
IncreaseRangeSlider -> Increase Range
DecreaseRangeSlider -> Decrease Range
PlaySound -> Play
StopSound -> Stop
IncreaseLoopableSlider -> Increase Loop time
DecreaseLoopableSlider -> Decrease Loop time

Spherical Gravity Generator
Interface name: IMyGravityGeneratorSphere
Parent: IMyGravityGeneratorBase
Parent: IMyFunctionalBlock

Fields:
float Radius 
float Gravity
Terminal properties:
Radius -> Single
Gravity -> Single
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Radius
DecreaseRadius -> Decrease Radius
IncreaseGravity -> Increase Acceleration
DecreaseGravity -> Decrease Acceleration

#####Spotlight######

Interface name: IMyReflectorLight
Parent: IMyLightingBlock
Parent: IMyFunctionalBlock

Fields:
float Radius
float Intensity
float BlinkIntervalSeconds
float BlinkLenght
float BlinkOffset

Terminal properties:
Color -> Color
Radius -> Single
Falloff -> Single
Intensity -> Single
Blink Interval -> Single
Blink Lenght -> Single
Blink Offset -> Single

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Radius
DecreaseRadius -> Decrease Radius
IncreaseBlink Interval -> Increase Blink Interval
DecreaseBlink Interval -> Decrease Blink Interval
IncreaseBlink Lenght -> Increase Blink Length
DecreaseBlink Lenght -> Decrease Blink Length
IncreaseBlink Offset -> Increase Blink Offset
DecreaseBlink Offset -> Decrease Blink Offset

Timer Block
Interface name: IMyTimerBlock
Parent: IMyFunctionalBlock

Fields:
bool IsCountingDown 
float TriggerDelay

Terminal properties:
TriggerDelay -> Single
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseTriggerDelay -> Increase Delay
DecreaseTriggerDelay -> Decrease Delay
TriggerNow -> Trigger now
Start -> Start
Stop -> Stop

code for start the block with the C# code:

IMyTimerBlock.GetActionWithName("Start").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("TriggerNow").Apply(IMyTimerBlock);
IMyTimerBlock.GetActionWithName("Stop").Apply(IMyTimerBlock);

Warhead
Interface name: IMyWarhead

Fields:
bool IsCountingDown 
float DetonationTime

Terminal properties:
DetonationTime -> Single 
Actions:
IncreaseDetonationTime -> Increase Detonation time
DecreaseDetonationTime -> Decrease Detonation time
StartCountdown -> Start countdown
StopCountdown -> Stop countdown
Safety -> Safety On/Off
Detonate -> Detonate

Welder
Interface name: IMyShipWelder
Parent: IMyShipToolBase
Parent: IMyFunctionalBlock
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Wheel Suspension 1x1
Interface name: IMyMotorSuspension
Parent: IMyMotorBase
Parent: IMyFunctionalBlock

Fields:
bool Steering 
bool Propulsion 
float Damping 
float Strength 
float Friction 
float Power

Terminal properties:
Damping -> Single
Strength -> Single
Friction -> Single
Power -> Single 
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Steering -> Steering On/Off
Propulsion -> Propulsion On/Off
IncreaseDamping -> Increase Damping
DecreaseDamping -> Decrease Damping
IncreaseStrength -> Increase Strength
DecreaseStrength -> Decrease Strength
IncreaseFriction -> Increase Friction
DecreaseFriction -> Decrease Friction
IncreasePower -> Increase Power
DecreasePower -> Decrease Power

Wheel Suspension 3x3
Interface name: IMyMotorSuspension
Parent: IMyMotorBase
Parent: IMyFunctionalBlock

Fields:
bool Steering 
bool Propulsion 
float Damping 
float Strength 
float Friction 
float Power

Terminal properties:
Damping -> Single
Strength -> Single
Friction -> Single
Power -> Single
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Steering -> Steering On/Off
Propulsion -> Propulsion On/Off
IncreaseDamping -> Increase Damping
DecreaseDamping -> Decrease Damping
IncreaseStrength -> Increase Strength
DecreaseStrength -> Decrease Strength
IncreaseFriction -> Increase Friction
DecreaseFriction -> Decrease Friction
IncreasePower -> Increase Power
DecreasePower -> Decrease Power

####### Wheel Suspension 5x5 ########

Interface name: IMyMotorSuspension
Parent: IMyMotorBase
Parent: IMyFunctionalBlock

Fields:
bool Steering 
bool Propulsion 
float Damping 
float Strength 
float Friction 
float Power

Terminal properties:
Damping -> Single
Strength -> Single
Friction -> Single
Power -> Single 

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Steering -> Steering On/Off
Propulsion -> Propulsion On/Off
IncreaseDamping -> Increase Damping
DecreaseDamping -> Decrease Damping
IncreaseStrength -> Increase Strength
DecreaseStrength -> Decrease Strength
IncreaseFriction -> Increase Friction
DecreaseFriction -> Decrease Friction
IncreasePower -> Increase Power
DecreasePower -> Decrease Power
Terminal block and action name list - 5/5

Code in c# get Actions:

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

Code in c# set terminal values:
IMyGravityGenerator.SetValueFloat("Damping", 1.0f);
IMyGravityGenerator.SetValueFloat("Strength", 1.0f);
IMyGravityGenerator.SetValueFloat("Friction", 1.0f);
IMyGravityGenerator.SetValueFloat("Power", 1.0f);

#####Text panel#####
// It is used to enable LCD pannel and TextPanes
Interface name: IMyTextPanel
Parent: IMyFunctionalBlock

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
Terminal properties :
FontSize -> Single
FontColor -> Color
BackgroundColor->Color

Code in c# get Actions:

IMyTextPanel.GetActionWithName("OnOff").Apply(IMyTextPanel); //change on to off and off to on 
IMyTextPanel.GetActionWithName("OnOff_On").Apply(IMyTextPanel);//turn on
IMyTextPanel.GetActionWithName("OnOff_Off").Apply(IMyTextPanel);//turn off

Code in c#:

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

Code example in C#:

var lcd_name = "name_of_your_LCD";
//LCD must be plugged on public mode
void Main() {

     IMyTextPanel LCD = GridTerminalSystem.GetBlockWithName(lcd_name) as IMyTextPanel;
     LCD.WritePublicText("Hello world",false); //clear the screen and print Hello world     
     LCD.ShowTextureOnScreen();  //show text on LCD screen
     LCD.ShowPublicTextOnScreen();  // shot text on Public mode
     LCD.GetPrivateText(); // get the private text of the private-box

}
