# Rust for Fsharpers and F# for Rustaceans

https://github.com/Dhghomon/rust-fsharp

<br>

<hr>

# Learning F#

https://fsharp.org/learn/

<br>


# F# Tutorial

https://learn.microsoft.com/en-us/dotnet/fsharp/get-started/install-fsharp

- Use F# on macOS

```
brew install dotnet

```

https://fsharp.org/use/mac/


```
dotnet new console --language F#
dotnet run

```

<br>

# F# Cheatsheet 

http://dungpa.github.io/fsharp-cheatsheet/

<br>

# F# for Beginners 

https://youtube.com/playlist?list=PLdo4fOcmZ0oUFghYOp89baYFBTGxUkC7Z

<br>

<br>

<hr>

# Hello_F_Sharp

```
dotnet new console --language F#

dotnet run

```

https://fsharp.org/use/mac/

<br>

<hr>


- 다른 방법 

```

dotnet new sln -o FSharpSample
```

https://learn.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-command-line?source=recommendations

<br>

# F_Sharp_Lang

- F# with the .NET CLI

https://learn.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-command-line?source=recommendations

<br>

```

$ mkdir f_sharp

$ cd f_sharp/

$ ls

$ dotnet new sln -o FSarpSample

The template "Solution File" was created successfully.
cd FSarpSample/

$ ls

FSarpSample.sln


$ dotnet new classlib -lang "F#" -o src/Library

The template "Class Library" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /Users/globalyoung/Documents/test/f_sharp/FSarpSample/src/Library/Library.fsproj...
  Determining projects to restore...
  Restored /Users/globalyoung/Documents/test/f_sharp/FSarpSample/src/Library/Library.fsproj (in 114 ms).
Restore succeeded.

$ ls
FSarpSample.sln src

$ tree
.
├── FSarpSample.sln
└── src
    └── Library
        ├── Library.fs
        ├── Library.fsproj
        └── obj
            ├── Library.fsproj.nuget.dgspec.json
            ├── Library.fsproj.nuget.g.props
            ├── Library.fsproj.nuget.g.targets
            ├── project.assets.json
            └── project.nuget.cache

3 directories, 8 files


$ ls
FSarpSample.sln src


$ dotnet run
Couldn't find a project to run. Ensure a project exists in /Users/globalyoung/Documents/test/f_sharp/FSarpSample, or pass the path to the project using --project.

$ cd src

$ ls
Library

$ cd Library/

$ ls

Library.fs     bin
Library.fsproj obj


$ dotnet run
Unable to run your project.
Ensure you have a runnable project type and ensure 'dotnet run' supports this project.
A runnable project should target a runnable TFM (for instance, net5.0) and have OutputType 'Exe'.
The current OutputType is 'Library'.

$ ls
Library.fs     bin
Library.fsproj obj

$ cd ..

$ ls
Library

$ cd Library/

$ cd ...

$ ls
FSarpSample.sln src



$ dotnet sln add src/Library/Library.fsproj
Project `src/Library/Library.fsproj` added to the solution.


$ dotnet run
Couldn't find a project to run. Ensure a project exists in /Users/globalyoung/Documents/test/f_sharp/FSarpSample, or pass the path to the project using --project.

$ dotnet build
Microsoft (R) Build Engine version 17.0.1+b177f8fa7 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  Library -> /Users/globalyoung/Documents/test/f_sharp/FSarpSample/src/Library/bin/Debug/net6.0/Library.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:00.54

$ ls
FSarpSample.sln src


$ dotnet new console -lang "F#" -o src/App
The template "Console App" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /Users/globalyoung/Documents/test/f_sharp/FSarpSample/src/App/App.fsproj...
  Determining projects to restore...
  Restored /Users/globalyoung/Documents/test/f_sharp/FSarpSample/src/App/App.fsproj (in 114 ms).
Restore succeeded.

$ tree
.
├── FSarpSample.sln
└── src
    ├── App
    │   ├── App.fsproj
    │   ├── Program.fs
    │   └── obj
    │       ├── App.fsproj.nuget.dgspec.json
    │       ├── App.fsproj.nuget.g.props
    │       ├── App.fsproj.nuget.g.targets
    │       ├── project.assets.json
    │       └── project.nuget.cache
    └── Library
        ├── Library.fs
        ├── Library.fsproj
        ├── bin
        │   └── Debug
        │       └── net6.0
        │           ├── Library.deps.json
        │           ├── Library.dll
        │           ├── Library.pdb
        │           └── Library.xml
        └── obj
            ├── Debug
            │   └── net6.0
            │       ├── Library.AssemblyInfo.fs
            │       ├── Library.AssemblyInfoInputs.cache
            │       ├── Library.assets.cache
            │       ├── Library.dll
            │       ├── Library.fsproj.AssemblyReference.cache
            │       ├── Library.fsproj.CoreCompileInputs.cache
            │       ├── Library.fsproj.FileListAbsolute.txt
            │       ├── Library.pdb
            │       └── Library.xml
            ├── Library.fsproj.nuget.dgspec.json
            ├── Library.fsproj.nuget.g.props
            ├── Library.fsproj.nuget.g.targets
            ├── project.assets.json
            └── project.nuget.cache

10 directories, 28 files



$ dotnet add src/App/App.fsproj reference src/Library/Library.fsproj
Reference `..\Library\Library.fsproj` added to the project.


$ ls
FSarpSample.sln src


$ dotnet sln add src/App/App.fsproj
Project `src/App/App.fsproj` added to the solution.


$ cd src/App/


$ dotnet run Hello World F#
Nice command-line arguments! Here's waht System.Text.Json has to say about them:
Input: { args = [|"Hello"; "World"; "F#"|] year = 2022 }
Output: {"args":["Hello","World","F#"],"year":2022}


```

<br>

<hr>

<br>

#  한글_씨샵&_에프_ #C# & F# 강의_001⭐️Hello World C#_F# LunarVim_Demo_Vim_macOS_M1_pro #csharp #fsharp

https://youtu.be/bhrU4B1-yeg

<br>

<hr>
