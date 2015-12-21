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

namespace Ev3devLang
{
    public static class Drivers
    {
//~autogen csharp-class-drivers classes>classes

        public const string LegoEv3LMotor = "lego-ev3-l-motor"; 
        public const string LegoEv3MMotor = "lego-ev3-m-motor"; 
        public const string NxtI2cSensor = "nxt-i2c-sensor"; 
        public const string LegoEv3Color = "lego-ev3-color"; 
        public const string LegoEv3Us = "lego-ev3-us"; 
        public const string LegoNxtUs = "lego-nxt-us"; 
        public const string LegoEv3Gyro = "lego-ev3-gyro"; 
        public const string LegoEv3Ir = "lego-ev3-ir"; 
        public const string LegoNxtSound = "lego-nxt-sound"; 
        public const string LegoNxtLight = "lego-nxt-light"; 
        public const string LegoEv3Touch = "lego-ev3-touch"; 
        public const string LegoNxtTouch = "lego-nxt-touch"; 

//~autogen
    }
}