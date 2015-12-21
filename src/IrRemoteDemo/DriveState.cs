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
 
namespace IrRemote
{
    internal class DriveState
    {
        public DriveState(int remoteState)
        {
            switch (remoteState)
            {
                case 0:// none
                    RightMotor = MotorDrive.Stop;
                    LeftMotor = MotorDrive.Stop;
                    break;
                case 1:// red up
                    RightMotor = MotorDrive.Stop;
                    LeftMotor = MotorDrive.Forward;
                    break;
                case 2:// red down
                    RightMotor = MotorDrive.Stop;
                    LeftMotor = MotorDrive.Backward;
                    break;
                case 3:// blue up
                    RightMotor = MotorDrive.Forward;
                    LeftMotor = MotorDrive.Stop;
                    break;
                case 4:// blue down
                    RightMotor = MotorDrive.Backward;
                    LeftMotor = MotorDrive.Stop;
                    break;
                case 5:// red up and blue up
                    RightMotor = MotorDrive.Forward;
                    LeftMotor = MotorDrive.Forward;
                    break;
                case 6:// red up and blue down
                    RightMotor = MotorDrive.Backward;
                    LeftMotor = MotorDrive.Forward;
                    break;
                case 7:// red down and blue up
                    RightMotor = MotorDrive.Forward;
                    LeftMotor = MotorDrive.Backward;
                    break;
                case 8:// red down and blue down
                    RightMotor = MotorDrive.Stop;
                    LeftMotor = MotorDrive.Stop;
                    break;
                case 9:// beacon
                    RightMotor = MotorDrive.Stop;
                    LeftMotor = MotorDrive.Stop;
                    break;
                case 10:// red up and red down
                    RightMotor = MotorDrive.Stop;
                    LeftMotor = MotorDrive.Stop;
                    break;
                case 11:// blue up and blue down
                    RightMotor = MotorDrive.Stop;
                    LeftMotor = MotorDrive.Stop;
                    break;
            }
        }

        public MotorDrive LeftMotor { get; private set; }
        public MotorDrive RightMotor { get; private set; }
    }

    enum MotorDrive
    {
        Stop,
        Forward,
        Backward
    }
}
