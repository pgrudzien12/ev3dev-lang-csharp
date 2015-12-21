/*
 * C# API to the sensors, motors, buttons, LEDs and battery of the ev3dev
 * Linux kernel for the LEGO Mindstorms EV3 hardware
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 *
 */

//~autogen autogen-header

// Sections of the following code were auto-generated based on spec v0.9.3-pre, rev 2.

//~autogen
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ev3dev
{    
//~autogen csharp-class-propertyValues classes>classes

    /// <summary> 
    /// The motor class provides a uniform interface for using motors with 
    /// positional and directional feedback such as the EV3 and NXT motors. 
    /// This feedback allows for precise control of the motors. This is the 
    /// most common type of motor, so we just call it `motor`.
    /// </summary>
    public partial class Motor : Device
    { 
        /// <summary> 
        /// Run the motor until another command is sent.
        /// </summary>
        public const string CommandRunForever = "run-forever";
        
        /// <summary> 
        /// Run to an absolute position specified by `position_sp` and then
        /// stop using the command specified in `stop_command`.
        /// </summary>
        public const string CommandRunToAbsPos = "run-to-abs-pos";
        
        /// <summary> 
        /// Run to a position relative to the current `position` value.
        /// The new position will be current `position` + `position_sp`.
        /// When the new position is reached, the motor will stop using
        /// the command specified by `stop_command`.
        /// </summary>
        public const string CommandRunToRelPos = "run-to-rel-pos";
        
        /// <summary> 
        /// Run the motor for the amount of time specified in `time_sp`
        /// and then stop the motor using the command specified by `stop_command`.
        /// </summary>
        public const string CommandRunTimed = "run-timed";
        
        /// <summary> 
        /// Run the motor at the duty cycle specified by `duty_cycle_sp`.
        /// Unlike other run commands, changing `duty_cycle_sp` while running *will*
        /// take effect immediately.
        /// </summary>
        public const string CommandRunDirect = "run-direct";
        
        /// <summary> 
        /// Stop any of the run commands before they are complete using the
        /// command specified by `stop_command`.
        /// </summary>
        public const string CommandStop = "stop";
        
        /// <summary> 
        /// Reset all of the motor parameter attributes to their default value.
        /// This will also have the effect of stopping the motor.
        /// </summary>
        public const string CommandReset = "reset";
        
        /// <summary> 
        /// Sets the normal polarity of the rotary encoder.
        /// </summary>
        public const string EncoderPolarityNormal = "normal";
        
        /// <summary> 
        /// Sets the inversed polarity of the rotary encoder.
        /// </summary>
        public const string EncoderPolarityInversed = "inversed";
        
        /// <summary> 
        /// With `normal` polarity, a positive duty cycle will
        /// cause the motor to rotate clockwise.
        /// </summary>
        public const string PolarityNormal = "normal";
        
        /// <summary> 
        /// With `inversed` polarity, a positive duty cycle will
        /// cause the motor to rotate counter-clockwise.
        /// </summary>
        public const string PolarityInversed = "inversed";
        
        /// <summary> 
        /// The motor controller will vary the power supplied to the motor
        /// to try to maintain the speed specified in `speed_sp`.
        /// </summary>
        public const string SpeedRegulationOn = "on";
        
        /// <summary> 
        /// The motor controller will use the power specified in `duty_cycle_sp`.
        /// </summary>
        public const string SpeedRegulationOff = "off";
        
        /// <summary> 
        /// Power will be removed from the motor and it will freely coast to a stop.
        /// </summary>
        public const string StopCommandCoast = "coast";
        
        /// <summary> 
        /// Power will be removed from the motor and a passive electrical load will
        /// be placed on the motor. This is usually done by shorting the motor terminals
        /// together. This load will absorb the energy from the rotation of the motors and
        /// cause the motor to stop more quickly than coasting.
        /// </summary>
        public const string StopCommandBrake = "brake";
        
        /// <summary> 
        /// Does not remove power from the motor. Instead it actively try to hold the motor
        /// at the current position. If an external force tries to turn the motor, the motor
        /// will ``push back`` to maintain its position.
        /// </summary>
        public const string StopCommandHold = "hold";
         
    } 
    
    /// <summary> 
    /// EV3 large servo motor
    /// </summary>
    public partial class LargeMotor : Motor
    {  
    } 
    
    /// <summary> 
    /// EV3 medium servo motor
    /// </summary>
    public partial class MediumMotor : Motor
    {  
    } 
    
    /// <summary> 
    /// The DC motor class provides a uniform interface for using regular DC motors 
    /// with no fancy controls or feedback. This includes LEGO MINDSTORMS RCX motors 
    /// and LEGO Power Functions motors.
    /// </summary>
    public partial class DcMotor : Device
    { 
        /// <summary> 
        /// Run the motor until another command is sent.
        /// </summary>
        public const string CommandRunForever = "run-forever";
        
        /// <summary> 
        /// Run the motor for the amount of time specified in `time_sp`
        /// and then stop the motor using the command specified by `stop_command`.
        /// </summary>
        public const string CommandRunTimed = "run-timed";
        
        /// <summary> 
        /// Run the motor at the duty cycle specified by `duty_cycle_sp`.
        /// Unlike other run commands, changing `duty_cycle_sp` while running *will*
        /// take effect immediately.
        /// </summary>
        public const string CommandRunDirect = "run-direct";
        
        /// <summary> 
        /// Stop any of the run commands before they are complete using the
        /// command specified by `stop_command`.
        /// </summary>
        public const string CommandStop = "stop";
        
        /// <summary> 
        /// With `normal` polarity, a positive duty cycle will
        /// cause the motor to rotate clockwise.
        /// </summary>
        public const string PolarityNormal = "normal";
        
        /// <summary> 
        /// With `inversed` polarity, a positive duty cycle will
        /// cause the motor to rotate counter-clockwise.
        /// </summary>
        public const string PolarityInversed = "inversed";
        
        /// <summary> 
        /// Power will be removed from the motor and it will freely coast to a stop.
        /// </summary>
        public const string StopCommandCoast = "coast";
        
        /// <summary> 
        /// Power will be removed from the motor and a passive electrical load will
        /// be placed on the motor. This is usually done by shorting the motor terminals
        /// together. This load will absorb the energy from the rotation of the motors and
        /// cause the motor to stop more quickly than coasting.
        /// </summary>
        public const string StopCommandBrake = "brake";
         
    } 
    
    /// <summary> 
    /// The servo motor class provides a uniform interface for using hobby type 
    /// servo motors.
    /// </summary>
    public partial class ServoMotor : Device
    { 
        /// <summary> 
        /// Drive servo to the position set in the `position_sp` attribute.
        /// </summary>
        public const string CommandRun = "run";
        
        /// <summary> 
        /// Remove power from the motor.
        /// </summary>
        public const string CommandFloat = "float";
        
        /// <summary> 
        /// With `normal` polarity, a positive duty cycle will
        /// cause the motor to rotate clockwise.
        /// </summary>
        public const string PolarityNormal = "normal";
        
        /// <summary> 
        /// With `inversed` polarity, a positive duty cycle will
        /// cause the motor to rotate counter-clockwise.
        /// </summary>
        public const string PolarityInversed = "inversed";
         
    } 
    
    /// <summary> 
    /// Any device controlled by the generic LED driver. 
    /// See https://www.kernel.org/doc/Documentation/leds/leds-class.txt 
    /// for more details.
    /// </summary>
    public partial class Led : Device
    {  
    } 
    
    /// <summary> 
    /// Provides a generic button reading mechanism that can be adapted 
    /// to platform specific implementations. Each platform's specific 
    /// button capabilites are enumerated in the 'platforms' section 
    /// of this specification
    /// </summary>
    public partial class Button : Device
    {  
    } 
    
    /// <summary> 
    /// The sensor class provides a uniform interface for using most of the 
    /// sensors available for the EV3. The various underlying device drivers will 
    /// create a `lego-sensor` device for interacting with the sensors. 
    ///  
    /// Sensors are primarily controlled by setting the `mode` and monitored by 
    /// reading the `value<N>` attributes. Values can be converted to floating point 
    /// if needed by `value<N>` / 10.0 ^ `decimals`. 
    ///  
    /// Since the name of the `sensor<N>` device node does not correspond to the port 
    /// that a sensor is plugged in to, you must look at the `port_name` attribute if 
    /// you need to know which port a sensor is plugged in to. However, if you don't 
    /// have more than one sensor of each type, you can just look for a matching 
    /// `driver_name`. Then it will not matter which port a sensor is plugged in to - your 
    /// program will still work.
    /// </summary>
    public partial class Sensor : Device
    {  
    } 
    
    /// <summary> 
    /// A generic interface to control I2C-type EV3 sensors.
    /// </summary>
    public partial class I2cSensor : Sensor
    {  
    } 
    
    /// <summary> 
    /// LEGO EV3 color sensor.
    /// </summary>
    public partial class ColorSensor : Sensor
    { 
        /// <summary> 
        /// Reflected light. Red LED on.
        /// </summary>
        public const string ModeColReflect = "COL-REFLECT";
        
        /// <summary> 
        /// Ambient light. Red LEDs off.
        /// </summary>
        public const string ModeColAmbient = "COL-AMBIENT";
        
        /// <summary> 
        /// Color. All LEDs rapidly cycling, appears white.
        /// </summary>
        public const string ModeColColor = "COL-COLOR";
        
        /// <summary> 
        /// Raw reflected. Red LED on
        /// </summary>
        public const string ModeRefRaw = "REF-RAW";
        
        /// <summary> 
        /// Raw Color Components. All LEDs rapidly cycling, appears white.
        /// </summary>
        public const string ModeRgbRaw = "RGB-RAW";
         
    } 
    
    /// <summary> 
    /// LEGO EV3 ultrasonic sensor.
    /// </summary>
    public partial class UltrasonicSensor : Sensor
    { 
        /// <summary> 
        /// Continuous measurement in centimeters.
        /// LEDs: On, steady
        /// </summary>
        public const string ModeUsDistCm = "US-DIST-CM";
        
        /// <summary> 
        /// Continuous measurement in inches.
        /// LEDs: On, steady
        /// </summary>
        public const string ModeUsDistIn = "US-DIST-IN";
        
        /// <summary> 
        /// Listen.  LEDs: On, blinking
        /// </summary>
        public const string ModeUsListen = "US-LISTEN";
        
        /// <summary> 
        /// Single measurement in centimeters.
        /// LEDs: On momentarily when mode is set, then off
        /// </summary>
        public const string ModeUsSiCm = "US-SI-CM";
        
        /// <summary> 
        /// Single measurement in inches.
        /// LEDs: On momentarily when mode is set, then off
        /// </summary>
        public const string ModeUsSiIn = "US-SI-IN";
         
    } 
    
    /// <summary> 
    /// LEGO EV3 gyro sensor.
    /// </summary>
    public partial class GyroSensor : Sensor
    { 
        /// <summary> 
        /// Angle
        /// </summary>
        public const string ModeGyroAng = "GYRO-ANG";
        
        /// <summary> 
        /// Rotational speed
        /// </summary>
        public const string ModeGyroRate = "GYRO-RATE";
        
        /// <summary> 
        /// Raw sensor value
        /// </summary>
        public const string ModeGyroFas = "GYRO-FAS";
        
        /// <summary> 
        /// Angle and rotational speed
        /// </summary>
        public const string ModeGyroGAnda = "GYRO-G&A";
        
        /// <summary> 
        /// Calibration ???
        /// </summary>
        public const string ModeGyroCal = "GYRO-CAL";
         
    } 
    
    /// <summary> 
    /// LEGO EV3 infrared sensor.
    /// </summary>
    public partial class InfraredSensor : Sensor
    { 
        /// <summary> 
        /// Proximity
        /// </summary>
        public const string ModeIrProx = "IR-PROX";
        
        /// <summary> 
        /// IR Seeker
        /// </summary>
        public const string ModeIrSeek = "IR-SEEK";
        
        /// <summary> 
        /// IR Remote Control
        /// </summary>
        public const string ModeIrRemote = "IR-REMOTE";
        
        /// <summary> 
        /// IR Remote Control. State of the buttons is coded in binary
        /// </summary>
        public const string ModeIrRemA = "IR-REM-A";
        
        /// <summary> 
        /// Calibration ???
        /// </summary>
        public const string ModeIrCal = "IR-CAL";
         
    } 
    
    /// <summary> 
    /// LEGO NXT Sound Sensor
    /// </summary>
    public partial class SoundSensor : Sensor
    { 
        /// <summary> 
        /// Sound pressure level. Flat weighting
        /// </summary>
        public const string ModeDb = "DB";
        
        /// <summary> 
        /// Sound pressure level. A weighting
        /// </summary>
        public const string ModeDba = "DBA";
         
    } 
    
    /// <summary> 
    /// LEGO NXT Light Sensor
    /// </summary>
    public partial class LightSensor : Sensor
    { 
        /// <summary> 
        /// Reflected light. LED on
        /// </summary>
        public const string ModeReflect = "REFLECT";
        
        /// <summary> 
        /// Ambient light. LED off
        /// </summary>
        public const string ModeAmbient = "AMBIENT";
         
    } 
    
    /// <summary> 
    /// Touch Sensor
    /// </summary>
    public partial class TouchSensor : Sensor
    {  
    } 
    
    /// <summary> 
    /// A generic interface to read data from the system's power_supply class. 
    /// Uses the built-in legoev3-battery if none is specified.
    /// </summary>
    public partial class PowerSupply : Device
    {  
    } 
    
    /// <summary> 
    /// The `lego-port` class provides an interface for working with input and 
    /// output ports that are compatible with LEGO MINDSTORMS RCX/NXT/EV3, LEGO 
    /// WeDo and LEGO Power Functions sensors and motors. Supported devices include 
    /// the LEGO MINDSTORMS EV3 Intelligent Brick, the LEGO WeDo USB hub and 
    /// various sensor multiplexers from 3rd party manufacturers. 
    ///  
    /// Some types of ports may have multiple modes of operation. For example, the 
    /// input ports on the EV3 brick can communicate with sensors using UART, I2C 
    /// or analog validate signals - but not all at the same time. Therefore there 
    /// are multiple modes available to connect to the different types of sensors. 
    ///  
    /// In most cases, ports are able to automatically detect what type of sensor 
    /// or motor is connected. In some cases though, this must be manually specified 
    /// using the `mode` and `set_device` attributes. The `mode` attribute affects 
    /// how the port communicates with the connected device. For example the input 
    /// ports on the EV3 brick can communicate using UART, I2C or analog voltages, 
    /// but not all at the same time, so the mode must be set to the one that is 
    /// appropriate for the connected sensor. The `set_device` attribute is used to 
    /// specify the exact type of sensor that is connected. Note: the mode must be 
    /// correctly set before setting the sensor type. 
    ///  
    /// Ports can be found at `/sys/class/lego-port/port<N>` where `<N>` is 
    /// incremented each time a new port is registered. Note: The number is not 
    /// related to the actual port at all - use the `port_name` attribute to find 
    /// a specific port.
    /// </summary>
    public partial class LegoPort : Device
    {  
    } 
    
    
//~autogen
}