# Getting started

See [this blog post](http://bleedingnedge.com/2015/11/08/asp-net-5-on-lego-mindstorms-ev3-using-ev3dev/) for instructions how install DNX, run .NET applications and compile C# code for Lego Mindstorms EV3. 

The `ev3dev` project is SDK implementation. Check also demo projects for exemplary usage.

# Usage

0. Install DNX with above instructions
1. Clone this project
2. Compile code with `dnu publish --no-source`
3. Copy `/bin/output` folder with your scp client to Lego brick
4. Run your project using DNX (usually indirectly through compiler generated command)