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

namespace ev3dev
{
    
    public partial class InfraredSensor
    {
//~autogen csharp-infraredsensor-modes classes.infraredSensor>currentClass

    /// <summary> 
    /// Proximity
    /// </summary>        
    public void SetIrProx() { Mode = "IR-PROX"; }
    public bool IsIrProx() { return Mode == "IR-PROX"; }

    /// <summary> 
    /// IR Seeker
    /// </summary>        
    public void SetIrSeek() { Mode = "IR-SEEK"; }
    public bool IsIrSeek() { return Mode == "IR-SEEK"; }

    /// <summary> 
    /// IR Remote Control
    /// </summary>        
    public void SetIrRemote() { Mode = "IR-REMOTE"; }
    public bool IsIrRemote() { return Mode == "IR-REMOTE"; }

    /// <summary> 
    /// IR Remote Control. State of the buttons is coded in binary
    /// </summary>        
    public void SetIrRemA() { Mode = "IR-REM-A"; }
    public bool IsIrRemA() { return Mode == "IR-REM-A"; }

    /// <summary> 
    /// Calibration ???
    /// </summary>        
    public void SetIrCal() { Mode = "IR-CAL"; }
    public bool IsIrCal() { return Mode == "IR-CAL"; }


//~autogen
    }
}