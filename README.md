# Time-Laps-Screen-Grab
This is a simple Screen Grabbing Software for creating Time Lapse Videos or tutorials. 
## Purpose
Screan Grab is a very simple screen grabbing software.
At present it doesn't support full resolution capture, but this is a feature that I am looking to write in the future,
This program was originally made as a simply app for a friend, hence the degree of "aggressive" error messages. If you 
intend to use it for professional use, I would recommend first going through and removing the messages which refer
to the user as a fool. 

## Limitations 
Screen grab only works on windows, (7/8/10) it hooks into the system.graphics namespace and as such there have been reported errors with some high performance graphics cards complaining about thread collisions. This has been solved for now by using a background worker instead of a main thread handler, in future I would create a thread, and fire off a thread independently of the counter thread, to grab image. 

## Licence
This software / code is free for commerical and personal use. As such any loss, damage, destruction or corruption caused as a result of this software is at the users risk, and I can not be held responsible. This code is provided as is, and as such has no warrently or support. If you encounter any problems please get in touch. 

## Compile
Open solution in Visual studio and build it. It only uses native librarys so should build fine. 




