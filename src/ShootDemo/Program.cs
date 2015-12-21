/*
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
 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ev3dev;

namespace ShootDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Device.SYS_ROOT = "c:/temp/ev3-sensors";
            Motor m = new LargeMotor(Outputs.OUTPUT_D);

            var sw = Stopwatch.StartNew();
            Console.WriteLine("started");
            m.Reset();
            Console.WriteLine("RunTimed " + sw.ElapsedMilliseconds);

            m.DutyCycleSp = 100;
            m.TimeSp = 1000;
            m.RunTimed();
            Console.WriteLine("RunTimed 1 done " + sw.ElapsedMilliseconds);
            Thread.Sleep(1000);
            Console.WriteLine("Timer 1 1000 done " + sw.ElapsedMilliseconds);

            m.DutyCycleSp = -100;
            m.TimeSp = 1000;
            m.RunTimed();
            Console.WriteLine("RunTimed 2 done " + sw.ElapsedMilliseconds);
            Thread.Sleep(1000);
            Console.WriteLine("Timer 2 1000 done " + sw.ElapsedMilliseconds);

            m.StopCommand = "coast";
            m.Stop();
        }
    }
}
