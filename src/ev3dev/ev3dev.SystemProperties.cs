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

//~autogen csharp-class-systemProperties classes>classes

    /// <summary> 
    /// The motor class provides a uniform interface for using motors with 
    /// positional and directional feedback such as the EV3 and NXT motors. 
    /// This feedback allows for precise control of the motors. This is the 
    /// most common type of motor, so we just call it `motor`.
    /// </summary>
    public partial class Motor : Device
    { 
        /// <summary> 
        /// Sends a command to the motor controller. See `commands` for a list of
        /// possible values.
        /// </summary>
        public string Command 
        { 
            set 
            {
                SetAttrString("command", value);
            } 
        } 
      
        /// <summary> 
        /// Returns a list of commands that are supported by the motor
        /// controller. Possible values are `run-forever`, `run-to-abs-pos`, `run-to-rel-pos`,
        /// `run-timed`, `run-direct`, `stop` and `reset`. Not all commands may be supported.
        /// 
        /// - `run-forever` will cause the motor to run until another command is sent.
        /// - `run-to-abs-pos` will run to an absolute position specified by `position_sp`
        ///   and then stop using the command specified in `stop_command`.
        /// - `run-to-rel-pos` will run to a position relative to the current `position` value.
        ///   The new position will be current `position` + `position_sp`. When the new
        ///   position is reached, the motor will stop using the command specified by `stop_command`.
        /// - `run-timed` will run the motor for the amount of time specified in `time_sp`
        ///   and then stop the motor using the command specified by `stop_command`.
        /// - `run-direct` will run the motor at the duty cycle specified by `duty_cycle_sp`.
        ///   Unlike other run commands, changing `duty_cycle_sp` while running *will*
        ///   take effect immediately.
        /// - `stop` will stop any of the run commands before they are complete using the
        ///   command specified by `stop_command`.
        /// - `reset` will reset all of the motor parameter attributes to their default value.
        ///   This will also have the effect of stopping the motor.
        /// </summary>
        public string[] Commands 
        { 
            get 
            {
                return GetAttrSet("commands");
            } 
        } 
      
        /// <summary> 
        /// Returns the number of tacho counts in one rotation of the motor. Tacho counts
        /// are used by the position and speed attributes, so you can use this value
        /// to convert rotations or degrees to tacho counts. In the case of linear
        /// actuators, the units here will be counts per centimeter.
        /// </summary>
        public int CountPerRot 
        { 
            get 
            {
                return GetAttrInt("count_per_rot");
            } 
        } 
      
        /// <summary> 
        /// Returns the name of the driver that provides this tacho motor device.
        /// </summary>
        public string DriverName 
        { 
            get 
            {
                return GetAttrString("driver_name");
            } 
        } 
      
        /// <summary> 
        /// Returns the current duty cycle of the motor. Units are percent. Values
        /// are -100 to 100.
        /// </summary>
        public int DutyCycle 
        { 
            get 
            {
                return GetAttrInt("duty_cycle");
            } 
        } 
      
        /// <summary> 
        /// Writing sets the duty cycle setpoint. Reading returns the current value.
        /// Units are in percent. Valid values are -100 to 100. A negative value causes
        /// the motor to rotate in reverse. This value is only used when `speed_regulation`
        /// is off.
        /// </summary>
        public int DutyCycleSp 
        { 
            get 
            {
                return GetAttrInt("duty_cycle_sp");
            } 
            set 
            {
                SetAttrInt("duty_cycle_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Sets the polarity of the rotary encoder. This is an advanced feature to all
        /// use of motors that send inversed encoder signals to the EV3. This should
        /// be set correctly by the driver of a device. It You only need to change this
        /// value if you are using a unsupported device. Valid values are `normal` and
        /// `inversed`.
        /// </summary>
        public string EncoderPolarity 
        { 
            get 
            {
                return GetAttrString("encoder_polarity");
            } 
            set 
            {
                SetAttrString("encoder_polarity", value);
            } 
        } 
      
        /// <summary> 
        /// Sets the polarity of the motor. With `normal` polarity, a positive duty
        /// cycle will cause the motor to rotate clockwise. With `inversed` polarity,
        /// a positive duty cycle will cause the motor to rotate counter-clockwise.
        /// Valid values are `normal` and `inversed`.
        /// </summary>
        public string Polarity 
        { 
            get 
            {
                return GetAttrString("polarity");
            } 
            set 
            {
                SetAttrString("polarity", value);
            } 
        } 
      
        /// <summary> 
        /// Returns the name of the port that the motor is connected to.
        /// </summary>
        public string PortName 
        { 
            get 
            {
                return GetAttrString("port_name");
            } 
        } 
      
        /// <summary> 
        /// Returns the current position of the motor in pulses of the rotary
        /// encoder. When the motor rotates clockwise, the position will increase.
        /// Likewise, rotating counter-clockwise causes the position to decrease.
        /// Writing will set the position to that value.
        /// </summary>
        public int Position 
        { 
            get 
            {
                return GetAttrInt("position");
            } 
            set 
            {
                SetAttrInt("position", value);
            } 
        } 
      
        /// <summary> 
        /// The proportional constant for the position PID.
        /// </summary>
        public int PositionP 
        { 
            get 
            {
                return GetAttrInt("hold_pid/Kp");
            } 
            set 
            {
                SetAttrInt("hold_pid/Kp", value);
            } 
        } 
      
        /// <summary> 
        /// The integral constant for the position PID.
        /// </summary>
        public int PositionI 
        { 
            get 
            {
                return GetAttrInt("hold_pid/Ki");
            } 
            set 
            {
                SetAttrInt("hold_pid/Ki", value);
            } 
        } 
      
        /// <summary> 
        /// The derivative constant for the position PID.
        /// </summary>
        public int PositionD 
        { 
            get 
            {
                return GetAttrInt("hold_pid/Kd");
            } 
            set 
            {
                SetAttrInt("hold_pid/Kd", value);
            } 
        } 
      
        /// <summary> 
        /// Writing specifies the target position for the `run-to-abs-pos` and `run-to-rel-pos`
        /// commands. Reading returns the current value. Units are in tacho counts. You
        /// can use the value returned by `counts_per_rot` to convert tacho counts to/from
        /// rotations or degrees.
        /// </summary>
        public int PositionSp 
        { 
            get 
            {
                return GetAttrInt("position_sp");
            } 
            set 
            {
                SetAttrInt("position_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Returns the current motor speed in tacho counts per second. Not, this is
        /// not necessarily degrees (although it is for LEGO motors). Use the `count_per_rot`
        /// attribute to convert this value to RPM or deg/sec.
        /// </summary>
        public int Speed 
        { 
            get 
            {
                return GetAttrInt("speed");
            } 
        } 
      
        /// <summary> 
        /// Writing sets the target speed in tacho counts per second used when `speed_regulation`
        /// is on. Reading returns the current value.  Use the `count_per_rot` attribute
        /// to convert RPM or deg/sec to tacho counts per second.
        /// </summary>
        public int SpeedSp 
        { 
            get 
            {
                return GetAttrInt("speed_sp");
            } 
            set 
            {
                SetAttrInt("speed_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Writing sets the ramp up setpoint. Reading returns the current value. Units
        /// are in milliseconds. When set to a value > 0, the motor will ramp the power
        /// sent to the motor from 0 to 100% duty cycle over the span of this setpoint
        /// when starting the motor. If the maximum duty cycle is limited by `duty_cycle_sp`
        /// or speed regulation, the actual ramp time duration will be less than the setpoint.
        /// </summary>
        public int RampUpSp 
        { 
            get 
            {
                return GetAttrInt("ramp_up_sp");
            } 
            set 
            {
                SetAttrInt("ramp_up_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Writing sets the ramp down setpoint. Reading returns the current value. Units
        /// are in milliseconds. When set to a value > 0, the motor will ramp the power
        /// sent to the motor from 100% duty cycle down to 0 over the span of this setpoint
        /// when stopping the motor. If the starting duty cycle is less than 100%, the
        /// ramp time duration will be less than the full span of the setpoint.
        /// </summary>
        public int RampDownSp 
        { 
            get 
            {
                return GetAttrInt("ramp_down_sp");
            } 
            set 
            {
                SetAttrInt("ramp_down_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Turns speed regulation on or off. If speed regulation is on, the motor
        /// controller will vary the power supplied to the motor to try to maintain the
        /// speed specified in `speed_sp`. If speed regulation is off, the controller
        /// will use the power specified in `duty_cycle_sp`. Valid values are `on` and
        /// `off`.
        /// </summary>
        public string SpeedRegulationEnabled 
        { 
            get 
            {
                return GetAttrString("speed_regulation");
            } 
            set 
            {
                SetAttrString("speed_regulation", value);
            } 
        } 
      
        /// <summary> 
        /// The proportional constant for the speed regulation PID.
        /// </summary>
        public int SpeedRegulationP 
        { 
            get 
            {
                return GetAttrInt("speed_pid/Kp");
            } 
            set 
            {
                SetAttrInt("speed_pid/Kp", value);
            } 
        } 
      
        /// <summary> 
        /// The integral constant for the speed regulation PID.
        /// </summary>
        public int SpeedRegulationI 
        { 
            get 
            {
                return GetAttrInt("speed_pid/Ki");
            } 
            set 
            {
                SetAttrInt("speed_pid/Ki", value);
            } 
        } 
      
        /// <summary> 
        /// The derivative constant for the speed regulation PID.
        /// </summary>
        public int SpeedRegulationD 
        { 
            get 
            {
                return GetAttrInt("speed_pid/Kd");
            } 
            set 
            {
                SetAttrInt("speed_pid/Kd", value);
            } 
        } 
      
        /// <summary> 
        /// Reading returns a list of state flags. Possible flags are
        /// `running`, `ramping` `holding` and `stalled`.
        /// </summary>
        public string[] State 
        { 
            get 
            {
                return GetAttrSet("state");
            } 
        } 
      
        /// <summary> 
        /// Reading returns the current stop command. Writing sets the stop command.
        /// The value determines the motors behavior when `command` is set to `stop`.
        /// Also, it determines the motors behavior when a run command completes. See
        /// `stop_commands` for a list of possible values.
        /// </summary>
        public string StopCommand 
        { 
            get 
            {
                return GetAttrString("stop_command");
            } 
            set 
            {
                SetAttrString("stop_command", value);
            } 
        } 
      
        /// <summary> 
        /// Returns a list of stop modes supported by the motor controller.
        /// Possible values are `coast`, `brake` and `hold`. `coast` means that power will
        /// be removed from the motor and it will freely coast to a stop. `brake` means
        /// that power will be removed from the motor and a passive electrical load will
        /// be placed on the motor. This is usually done by shorting the motor terminals
        /// together. This load will absorb the energy from the rotation of the motors and
        /// cause the motor to stop more quickly than coasting. `hold` does not remove
        /// power from the motor. Instead it actively try to hold the motor at the current
        /// position. If an external force tries to turn the motor, the motor will 'push
        /// back' to maintain its position.
        /// </summary>
        public string[] StopCommands 
        { 
            get 
            {
                return GetAttrSet("stop_commands");
            } 
        } 
      
        /// <summary> 
        /// Writing specifies the amount of time the motor will run when using the
        /// `run-timed` command. Reading returns the current value. Units are in
        /// milliseconds.
        /// </summary>
        public int TimeSp 
        { 
            get 
            {
                return GetAttrInt("time_sp");
            } 
            set 
            {
                SetAttrInt("time_sp", value);
            } 
        } 
      
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
        /// Sets the command for the motor. Possible values are `run-forever`, `run-timed` and
        /// `stop`. Not all commands may be supported, so be sure to check the contents
        /// of the `commands` attribute.
        /// </summary>
        public string Command 
        { 
            set 
            {
                SetAttrString("command", value);
            } 
        } 
      
        /// <summary> 
        /// Returns a list of commands supported by the motor
        /// controller.
        /// </summary>
        public string[] Commands 
        { 
            get 
            {
                return GetAttrSet("commands");
            } 
        } 
      
        /// <summary> 
        /// Returns the name of the motor driver that loaded this device. See the list
        /// of [supported devices] for a list of drivers.
        /// </summary>
        public string DriverName 
        { 
            get 
            {
                return GetAttrString("driver_name");
            } 
        } 
      
        /// <summary> 
        /// Shows the current duty cycle of the PWM signal sent to the motor. Values
        /// are -100 to 100 (-100% to 100%).
        /// </summary>
        public int DutyCycle 
        { 
            get 
            {
                return GetAttrInt("duty_cycle");
            } 
        } 
      
        /// <summary> 
        /// Writing sets the duty cycle setpoint of the PWM signal sent to the motor.
        /// Valid values are -100 to 100 (-100% to 100%). Reading returns the current
        /// setpoint.
        /// </summary>
        public int DutyCycleSp 
        { 
            get 
            {
                return GetAttrInt("duty_cycle_sp");
            } 
            set 
            {
                SetAttrInt("duty_cycle_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Sets the polarity of the motor. Valid values are `normal` and `inversed`.
        /// </summary>
        public string Polarity 
        { 
            get 
            {
                return GetAttrString("polarity");
            } 
            set 
            {
                SetAttrString("polarity", value);
            } 
        } 
      
        /// <summary> 
        /// Returns the name of the port that the motor is connected to.
        /// </summary>
        public string PortName 
        { 
            get 
            {
                return GetAttrString("port_name");
            } 
        } 
      
        /// <summary> 
        /// Sets the time in milliseconds that it take the motor to ramp down from 100%
        /// to 0%. Valid values are 0 to 10000 (10 seconds). Default is 0.
        /// </summary>
        public int RampDownSp 
        { 
            get 
            {
                return GetAttrInt("ramp_down_sp");
            } 
            set 
            {
                SetAttrInt("ramp_down_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Sets the time in milliseconds that it take the motor to up ramp from 0% to
        /// 100%. Valid values are 0 to 10000 (10 seconds). Default is 0.
        /// </summary>
        public int RampUpSp 
        { 
            get 
            {
                return GetAttrInt("ramp_up_sp");
            } 
            set 
            {
                SetAttrInt("ramp_up_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Gets a list of flags indicating the motor status. Possible
        /// flags are `running` and `ramping`. `running` indicates that the motor is
        /// powered. `ramping` indicates that the motor has not yet reached the
        /// `duty_cycle_sp`.
        /// </summary>
        public string[] State 
        { 
            get 
            {
                return GetAttrSet("state");
            } 
        } 
      
        /// <summary> 
        /// Sets the stop command that will be used when the motor stops. Read
        /// `stop_commands` to get the list of valid values.
        /// </summary>
        public string StopCommand 
        { 
            set 
            {
                SetAttrString("stop_command", value);
            } 
        } 
      
        /// <summary> 
        /// Gets a list of stop commands. Valid values are `coast`
        /// and `brake`.
        /// </summary>
        public string[] StopCommands 
        { 
            get 
            {
                return GetAttrSet("stop_commands");
            } 
        } 
      
        /// <summary> 
        /// Writing specifies the amount of time the motor will run when using the
        /// `run-timed` command. Reading returns the current value. Units are in
        /// milliseconds.
        /// </summary>
        public int TimeSp 
        { 
            get 
            {
                return GetAttrInt("time_sp");
            } 
            set 
            {
                SetAttrInt("time_sp", value);
            } 
        } 
      
    }
    
    /// <summary> 
    /// The servo motor class provides a uniform interface for using hobby type 
    /// servo motors.
    /// </summary>
    public partial class ServoMotor : Device
    { 
        /// <summary> 
        /// Sets the command for the servo. Valid values are `run` and `float`. Setting
        /// to `run` will cause the servo to be driven to the position_sp set in the
        /// `position_sp` attribute. Setting to `float` will remove power from the motor.
        /// </summary>
        public string Command 
        { 
            set 
            {
                SetAttrString("command", value);
            } 
        } 
      
        /// <summary> 
        /// Returns the name of the motor driver that loaded this device. See the list
        /// of [supported devices] for a list of drivers.
        /// </summary>
        public string DriverName 
        { 
            get 
            {
                return GetAttrString("driver_name");
            } 
        } 
      
        /// <summary> 
        /// Used to set the pulse size in milliseconds for the signal that tells the
        /// servo to drive to the maximum (clockwise) position_sp. Default value is 2400.
        /// Valid values are 2300 to 2700. You must write to the position_sp attribute for
        /// changes to this attribute to take effect.
        /// </summary>
        public int MaxPulseSp 
        { 
            get 
            {
                return GetAttrInt("max_pulse_sp");
            } 
            set 
            {
                SetAttrInt("max_pulse_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Used to set the pulse size in milliseconds for the signal that tells the
        /// servo to drive to the mid position_sp. Default value is 1500. Valid
        /// values are 1300 to 1700. For example, on a 180 degree servo, this would be
        /// 90 degrees. On continuous rotation servo, this is the 'neutral' position_sp
        /// where the motor does not turn. You must write to the position_sp attribute for
        /// changes to this attribute to take effect.
        /// </summary>
        public int MidPulseSp 
        { 
            get 
            {
                return GetAttrInt("mid_pulse_sp");
            } 
            set 
            {
                SetAttrInt("mid_pulse_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Used to set the pulse size in milliseconds for the signal that tells the
        /// servo to drive to the miniumum (counter-clockwise) position_sp. Default value
        /// is 600. Valid values are 300 to 700. You must write to the position_sp
        /// attribute for changes to this attribute to take effect.
        /// </summary>
        public int MinPulseSp 
        { 
            get 
            {
                return GetAttrInt("min_pulse_sp");
            } 
            set 
            {
                SetAttrInt("min_pulse_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Sets the polarity of the servo. Valid values are `normal` and `inversed`.
        /// Setting the value to `inversed` will cause the position_sp value to be
        /// inversed. i.e `-100` will correspond to `max_pulse_sp`, and `100` will
        /// correspond to `min_pulse_sp`.
        /// </summary>
        public string Polarity 
        { 
            get 
            {
                return GetAttrString("polarity");
            } 
            set 
            {
                SetAttrString("polarity", value);
            } 
        } 
      
        /// <summary> 
        /// Returns the name of the port that the motor is connected to.
        /// </summary>
        public string PortName 
        { 
            get 
            {
                return GetAttrString("port_name");
            } 
        } 
      
        /// <summary> 
        /// Reading returns the current position_sp of the servo. Writing instructs the
        /// servo to move to the specified position_sp. Units are percent. Valid values
        /// are -100 to 100 (-100% to 100%) where `-100` corresponds to `min_pulse_sp`,
        /// `0` corresponds to `mid_pulse_sp` and `100` corresponds to `max_pulse_sp`.
        /// </summary>
        public int PositionSp 
        { 
            get 
            {
                return GetAttrInt("position_sp");
            } 
            set 
            {
                SetAttrInt("position_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Sets the rate_sp at which the servo travels from 0 to 100.0% (half of the full
        /// range of the servo). Units are in milliseconds. Example: Setting the rate_sp
        /// to 1000 means that it will take a 180 degree servo 2 second to move from 0
        /// to 180 degrees. Note: Some servo controllers may not support this in which
        /// case reading and writing will fail with `-EOPNOTSUPP`. In continuous rotation
        /// servos, this value will affect the rate_sp at which the speed ramps up or down.
        /// </summary>
        public int RateSp 
        { 
            get 
            {
                return GetAttrInt("rate_sp");
            } 
            set 
            {
                SetAttrInt("rate_sp", value);
            } 
        } 
      
        /// <summary> 
        /// Returns a list of flags indicating the state of the servo.
        /// Possible values are:
        /// * `running`: Indicates that the motor is powered.
        /// </summary>
        public string[] State 
        { 
            get 
            {
                return GetAttrSet("state");
            } 
        } 
      
    }
    
    /// <summary> 
    /// Any device controlled by the generic LED driver. 
    /// See https://www.kernel.org/doc/Documentation/leds/leds-class.txt 
    /// for more details.
    /// </summary>
    public partial class Led : Device
    { 
        /// <summary> 
        /// Returns the maximum allowable brightness value.
        /// </summary>
        public int MaxBrightness 
        { 
            get 
            {
                return GetAttrInt("max_brightness");
            } 
        } 
      
        /// <summary> 
        /// Sets the brightness level. Possible values are from 0 to `max_brightness`.
        /// </summary>
        public int Brightness 
        { 
            get 
            {
                return GetAttrInt("brightness");
            } 
            set 
            {
                SetAttrInt("brightness", value);
            } 
        } 
      
        /// <summary> 
        /// Returns a list of available triggers.
        /// </summary>
        public string[] Triggers 
        { 
            get 
            {
                return GetAttrSet("trigger");
            } 
        } 
      
        /// <summary> 
        /// Sets the led trigger. A trigger
        /// is a kernel based source of led events. Triggers can either be simple or
        /// complex. A simple trigger isn't configurable and is designed to slot into
        /// existing subsystems with minimal additional code. Examples are the `ide-disk` and
        /// `nand-disk` triggers.
        /// 
        /// Complex triggers whilst available to all LEDs have LED specific
        /// parameters and work on a per LED basis. The `timer` trigger is an example.
        /// The `timer` trigger will periodically change the LED brightness between
        /// 0 and the current brightness setting. The `on` and `off` time can
        /// be specified via `delay_{on,off}` attributes in milliseconds.
        /// You can change the brightness value of a LED independently of the timer
        /// trigger. However, if you set the brightness value to 0 it will
        /// also disable the `timer` trigger.
        /// </summary>
        public string Trigger 
        { 
            get 
            {
                return GetAttrFromSet("trigger");
            } 
            set 
            {
                SetAttrString("trigger", value);
            } 
        } 
      
        /// <summary> 
        /// The `timer` trigger will periodically change the LED brightness between
        /// 0 and the current brightness setting. The `on` time can
        /// be specified via `delay_on` attribute in milliseconds.
        /// </summary>
        public int DelayOn 
        { 
            get 
            {
                return GetAttrInt("delay_on");
            } 
            set 
            {
                SetAttrInt("delay_on", value);
            } 
        } 
      
        /// <summary> 
        /// The `timer` trigger will periodically change the LED brightness between
        /// 0 and the current brightness setting. The `off` time can
        /// be specified via `delay_off` attribute in milliseconds.
        /// </summary>
        public int DelayOff 
        { 
            get 
            {
                return GetAttrInt("delay_off");
            } 
            set 
            {
                SetAttrInt("delay_off", value);
            } 
        } 
      
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
        /// <summary> 
        /// Sends a command to the sensor.
        /// </summary>
        public string Command 
        { 
            set 
            {
                SetAttrString("command", value);
            } 
        } 
      
        /// <summary> 
        /// Returns a list of the valid commands for the sensor.
        /// Returns -EOPNOTSUPP if no commands are supported.
        /// </summary>
        public string[] Commands 
        { 
            get 
            {
                return GetAttrSet("commands");
            } 
        } 
      
        /// <summary> 
        /// Returns the number of decimal places for the values in the `value<N>`
        /// attributes of the current mode.
        /// </summary>
        public int Decimals 
        { 
            get 
            {
                return GetAttrInt("decimals");
            } 
        } 
      
        /// <summary> 
        /// Returns the name of the sensor device/driver. See the list of [supported
        /// sensors] for a complete list of drivers.
        /// </summary>
        public string DriverName 
        { 
            get 
            {
                return GetAttrString("driver_name");
            } 
        } 
      
        /// <summary> 
        /// Returns the current mode. Writing one of the values returned by `modes`
        /// sets the sensor to that mode.
        /// </summary>
        public string Mode 
        { 
            get 
            {
                return GetAttrString("mode");
            } 
            set 
            {
                SetAttrString("mode", value);
            } 
        } 
      
        /// <summary> 
        /// Returns a list of the valid modes for the sensor.
        /// </summary>
        public string[] Modes 
        { 
            get 
            {
                return GetAttrSet("modes");
            } 
        } 
      
        /// <summary> 
        /// Returns the number of `value<N>` attributes that will return a valid value
        /// for the current mode.
        /// </summary>
        public int NumValues 
        { 
            get 
            {
                return GetAttrInt("num_values");
            } 
        } 
      
        /// <summary> 
        /// Returns the name of the port that the sensor is connected to, e.g. `ev3:in1`.
        /// I2C sensors also include the I2C address (decimal), e.g. `ev3:in1:i2c8`.
        /// </summary>
        public string PortName 
        { 
            get 
            {
                return GetAttrString("port_name");
            } 
        } 
      
        /// <summary> 
        /// Returns the units of the measured value for the current mode. May return
        /// empty string
        /// </summary>
        public string Units 
        { 
            get 
            {
                return GetAttrString("units");
            } 
        } 
      
    }
    
    /// <summary> 
    /// A generic interface to control I2C-type EV3 sensors.
    /// </summary>
    public partial class I2cSensor : Sensor
    { 
        /// <summary> 
        /// Returns the firmware version of the sensor if available. Currently only
        /// I2C/NXT sensors support this.
        /// </summary>
        public string FwVersion 
        { 
            get 
            {
                return GetAttrString("fw_version");
            } 
        } 
      
        /// <summary> 
        /// Returns the polling period of the sensor in milliseconds. Writing sets the
        /// polling period. Setting to 0 disables polling. Minimum value is hard
        /// coded as 50 msec. Returns -EOPNOTSUPP if changing polling is not supported.
        /// Currently only I2C/NXT sensors support changing the polling period.
        /// </summary>
        public int PollMs 
        { 
            get 
            {
                return GetAttrInt("poll_ms");
            } 
            set 
            {
                SetAttrInt("poll_ms", value);
            } 
        } 
      
    }
    
    /// <summary> 
    /// LEGO EV3 color sensor.
    /// </summary>
    public partial class ColorSensor : Sensor
    { 
    }
    
    /// <summary> 
    /// LEGO EV3 ultrasonic sensor.
    /// </summary>
    public partial class UltrasonicSensor : Sensor
    { 
    }
    
    /// <summary> 
    /// LEGO EV3 gyro sensor.
    /// </summary>
    public partial class GyroSensor : Sensor
    { 
    }
    
    /// <summary> 
    /// LEGO EV3 infrared sensor.
    /// </summary>
    public partial class InfraredSensor : Sensor
    { 
    }
    
    /// <summary> 
    /// LEGO NXT Sound Sensor
    /// </summary>
    public partial class SoundSensor : Sensor
    { 
    }
    
    /// <summary> 
    /// LEGO NXT Light Sensor
    /// </summary>
    public partial class LightSensor : Sensor
    { 
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
        /// <summary> 
        /// The measured current that the battery is supplying (in microamps)
        /// </summary>
        public int MeasuredCurrent 
        { 
            get 
            {
                return GetAttrInt("current_now");
            } 
        } 
      
        /// <summary> 
        /// The measured voltage that the battery is supplying (in microvolts)
        /// </summary>
        public int MeasuredVoltage 
        { 
            get 
            {
                return GetAttrInt("voltage_now");
            } 
        } 
      
        /// <summary> 
        /// </summary>
        public int MaxVoltage 
        { 
            get 
            {
                return GetAttrInt("voltage_max_design");
            } 
        } 
      
        /// <summary> 
        /// </summary>
        public int MinVoltage 
        { 
            get 
            {
                return GetAttrInt("voltage_min_design");
            } 
        } 
      
        /// <summary> 
        /// </summary>
        public string Technology 
        { 
            get 
            {
                return GetAttrString("technology");
            } 
        } 
      
        /// <summary> 
        /// </summary>
        public string Type 
        { 
            get 
            {
                return GetAttrString("type");
            } 
        } 
      
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
        /// <summary> 
        /// Returns the name of the driver that loaded this device. You can find the
        /// complete list of drivers in the [list of port drivers].
        /// </summary>
        public string DriverName 
        { 
            get 
            {
                return GetAttrString("driver_name");
            } 
        } 
      
        /// <summary> 
        /// Returns a list of the available modes of the port.
        /// </summary>
        public string[] Modes 
        { 
            get 
            {
                return GetAttrSet("modes");
            } 
        } 
      
        /// <summary> 
        /// Reading returns the currently selected mode. Writing sets the mode.
        /// Generally speaking when the mode changes any sensor or motor devices
        /// associated with the port will be removed new ones loaded, however this
        /// this will depend on the individual driver implementing this class.
        /// </summary>
        public string Mode 
        { 
            get 
            {
                return GetAttrString("mode");
            } 
            set 
            {
                SetAttrString("mode", value);
            } 
        } 
      
        /// <summary> 
        /// Returns the name of the port. See individual driver documentation for
        /// the name that will be returned.
        /// </summary>
        public string PortName 
        { 
            get 
            {
                return GetAttrString("port_name");
            } 
        } 
      
        /// <summary> 
        /// For modes that support it, writing the name of a driver will cause a new
        /// device to be registered for that driver and attached to this port. For
        /// example, since NXT/Analog sensors cannot be auto-detected, you must use
        /// this attribute to load the correct driver. Returns -EOPNOTSUPP if setting a
        /// device is not supported.
        /// </summary>
        public string SetDevice 
        { 
            set 
            {
                SetAttrString("set_device", value);
            } 
        } 
      
        /// <summary> 
        /// In most cases, reading status will return the same value as `mode`. In
        /// cases where there is an `auto` mode additional values may be returned,
        /// such as `no-device` or `error`. See individual port driver documentation
        /// for the full list of possible values.
        /// </summary>
        public string Status 
        { 
            get 
            {
                return GetAttrString("status");
            } 
        } 
      
    }
    
//~autogen
}