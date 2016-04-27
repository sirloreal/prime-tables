# prime-tables

## Overview
This is the source code for a console application, which is used to calculate the first N prime numbers (where N is a number provided by the user) and print them to screen in a formatted table. 

## Software Versions
The application is a C# console application written with Visual Studio 2013 against version 4.5 of the .NET Framework. It has been tested within these environments and also on a Windows 7 64-bit client machine.

## How to run
To run the application, perform the following steps:
- Download the source code and open the .sln file in Visual Studio;
- Compile/build the code;
- Run the application in either debug or release mode;
- The application will prompt for a whole number which is at least 1. If either of these criteria are not met the application will report an error and you must try again;
- Upon succsessfully meeting the criteria, the application will find the first N prime numbers based on your input, and then print these to the screen in a formatted table;
- You are then prompted to press the any key to exit the application.

## What I'm pleased with
### Algorithm Design
This algorithm design was a very quickly thrown together implementation of the Strategy Pattern, which is designed to shield the details of how an algorithm does it's work in producing your expected results. In a larger scale production system, you can use interfaces and abstractions to substitute various algorithms for data manipulation should you wish. The design can also encourage a loosely coupled design which is easily extensible; new algorithms can be supported by introduction of a new class taking (optional) AlgorithmParameters and running something completely different with those paramters. In addition, the Algorithm class is in and of itself generic enough that you could implement more complex paramters - either using primitive or reference types as your object. For example, you could define a GeoLocation object containing coordinates and use that object as your algorithm parameter.

### Algorithm implementation
After having done some research into the algorithms that might be possible for the prime number calculations, it became clear that there was a simple naive approach that would do the job using simple loops. With a bit of commenting to explain rationale (and a citation for where the inspiration came from!) it worked reasonably well. One early piece of logic to save unneccessary work is solely examining odd numbers except for 2. Since no even number could be prime, this makes the algorithm much more efficient for larger primes than a basic for loop would have been.

### Testing
Testing is reasonably comprehensive across the algorithm framework and was written before code to promote Test-Driven Development. Coverage is good and can be further built upon for extensions to the framework.

##Improvements
### Performance
- The algorithm presented is OK but indeed still somewhat naive and could benefit from the use of perhaps some of the sieving algorithms available (e.g. Eratosthenes). Given more time to research and understand these it would have been possible to incorporate those algorithms and potentially even write them as additional classes, to allow the client application to undertake performance metrics and comparisons between algorithms. Going further with the algorithms, one of the answers seen on Stackoverflow suggested the use of regular expressions for the primes, which would be a very curious and interesting thing to try out if it gave a significatn performance advantage. 
- Printing results requires a cartesian join of the list of primes in order to produce the table. This can make it a bit sluggish for larger numbers. There could be an alternative available to reduce the amount of work needed. For readability or if further operations were required on the data set, we could also take advantage of LINQ, though the performance difference would generally be negligible.

### Algorithm Design
As mentioned, the design of the algorithm framework allows for extension, however some recommended alterations would be:
- Contain the algorithms in a separate project if using in a larger production system. 
- Consider the use of factories and reflection in conjunction with the above to promote a scalable and more extensible solution which is significantly more generic.
- Use better naming for the classes to make them more generic and reusable.
- Validate parameters on the implementation classes themselves, perhaps in a separate Validate() function, rather than waiting until the Run() method is called. This is a weakness with the use of the console application as I have not included any exception handling in the Program class. How exceptions and validataion is handled would depend more on the system being used and the overarching strategy and architecture before accurate recommendations could be made.

### UI Improvements
Some suggestions on how to improve the UI are as follows:
- Fix the formatting on the console; as the numbers increase to multiple digits the formatting of the table starts to skew. In addition, the table does not format well on a console window once numbers (and thus columns) get sufficiently large owing to line wrapping. 
- It would be a nice enhancement to utilise some more friendly web or winforms components to format the data in a more friendly manner - thinking along the lines of things like WPF grids/tables or the equivalent in HTML/CSS/ASP.NET web forms.
- Introduce a 'would you like to go again?' hook into the console so as you don't have to run it every time.
 

Thanks for taking the time to review this code and for reading the readme. 
