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

namespace Ev3devLang
{
    
    public partial class Motor
    {
//~autogen csharp-motor-commands classes.motor>currentClass

    /// <summary> 
    /// Run the motor until another command is sent.
    /// </summary>        
    public void RunForever() { Command = "run-forever"; }

    /// <summary> 
    /// Run to an absolute position specified by `position_sp` and then
    /// stop using the command specified in `stop_command`.
    /// </summary>        
    public void RunToAbsPos() { Command = "run-to-abs-pos"; }

    /// <summary> 
    /// Run to a position relative to the current `position` value.
    /// The new position will be current `position` + `position_sp`.
    /// When the new position is reached, the motor will stop using
    /// the command specified by `stop_command`.
    /// </summary>        
    public void RunToRelPos() { Command = "run-to-rel-pos"; }

    /// <summary> 
    /// Run the motor for the amount of time specified in `time_sp`
    /// and then stop the motor using the command specified by `stop_command`.
    /// </summary>        
    public void RunTimed() { Command = "run-timed"; }

    /// <summary> 
    /// Run the motor at the duty cycle specified by `duty_cycle_sp`.
    /// Unlike other run commands, changing `duty_cycle_sp` while running *will*
    /// take effect immediately.
    /// </summary>        
    public void RunDirect() { Command = "run-direct"; }

    /// <summary> 
    /// Stop any of the run commands before they are complete using the
    /// command specified by `stop_command`.
    /// </summary>        
    public void Stop() { Command = "stop"; }

    /// <summary> 
    /// Reset all of the motor parameter attributes to their default value.
    /// This will also have the effect of stopping the motor.
    /// </summary>        
    public void Reset() { Command = "reset"; }


//~autogen
    }
}
