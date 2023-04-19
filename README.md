# CustomControlHandlerDemo
Sample code to demonstrate how to customize existing .NET MAUI controls with handlers
based off of Gerald Versluis sample code (https://youtu.be/_9dz7BUoxT8) that demonstrates 
three different ways of customizing an existing .NET Maui control with handlers.

## Method 1
In the App startup code write the platform specific code with conditional compile defs. 

Drawback: Conditional compile defs everywhere in your code.

## Method 2
In the platform specific folder (in this case Android MainActivity class) write the platform 
specific code. 

Drawback: Kind of hidden and not obvious to uses that the code is there.

## Method 3
Write custom partial classes using partial methods to be deployed in the shared code and 
platform specific code. The shared code (Handlers folder) has a class that declares a 
static partial method, e.g., CustomHandler, (similar to an interface) that is private by 
default and a public static partial method that calls this method. In the platform specific 
folder create the another partial class that contains the actual static parital platform specific 
method that contains the platform specific code.

Drawback: I don't see any but Gerald might! It is clean and easily discoverable like Gerald noted 
in his video.

https://github.com/jfversluis/MAUICustomHandlerSample