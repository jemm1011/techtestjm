# techtestjm


Technical Test
# Getting Started


## Prerequisites

Visual Studio 2015 or higher version  
https://visualstudio.microsoft.com/es/downloads/

NodeJs  
https://nodejs.org/es/

## Installing

Modify your hostfile and add the following lines
```
127.0.0.1 techtestjm.com
127.0.0.1 techtestjmsite.com
```

Add Website to IIS with hostname **techtestjm.com**  
Physical path must point to **TechTestJM.Api** project folder


Add Website to IIS with hostname **techtestjmsite.com**  
Physical path must point to **TechTestJM.WebSite** project folder

Go to TechTestJM.WebSite explorer folder and run a cmd window there.  
Run command 
```
npm install
```
and wait for all packages to be installed.

Open TechTestJM Solution with visual studio and Restore Nuget Packages
