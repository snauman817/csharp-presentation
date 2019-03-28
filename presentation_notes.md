#Using C-Sharp

##Mono
Mono is a C\# framework and command line tool used to run and compile C\#

###How to install
`brew cask install mono-mdk`

###How to Use
1. Create a directory to hold your project (syntax is Capital Camel Case)
2. Touch a project file, can me named whatever. The extention should be `.cs`
3. Open that file up, and type a few lines in order to properly create a C\# application
4. After setting the file up correctly, run `mcs filename.cs` in the Terminal. You should see a `filename.exe` in the directory that the `.cs` project is in.
5. Now, run `mono filename.exe`. The file is run and any output is given to the console.

##First C\# File
C\# is entirely Object Oriented. That means that we must create classes for everything.
But let's actually try to understand what's going on here.

Hello World full code:
```
using System;

namespace DirectoryName {

    class HelloPrinter
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```