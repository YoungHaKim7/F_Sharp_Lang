# dotnet 으로 내가 할 수 있는것들 & 

- ASP.NET Core Empty       web                  [C#],F#     Web/Empty

```

PS D:\003_BasicFuctions2> dotnet new
준비 중...
템플릿 이름                   약식 이름                언어          태그

-----------------------  -------------------  ----------  -------------------------------------
Console Application      console              [C#],F#,VB  Common/Console
Class library            classlib             [C#],F#,VB  Common/Library
WPF Application          wpf                  [C#]        Common/WPF
WPF Class library        wpflib               [C#]        Common/WPF
WPF Custom Control L...  wpfcustomcontrollib  [C#]        Common/WPF
WPF User Control Lib...  wpfusercontrollib    [C#]        Common/WPF
Windows Forms (WinFo...  winforms             [C#]        Common/WinForms
Windows Forms (WinFo...  winformslib          [C#]        Common/WinForms
Worker Service           worker               [C#]        Common/Worker/Web
MSTest Test Project ...  mstest               [C#],F#,VB  Test/MSTest
NUnit 3 Test Item        nunit-test           [C#],F#,VB  Test/NUnit
NUnit 3 Test Project     nunit                [C#],F#,VB  Test/NUnit
xUnit Test Project       xunit                [C#],F#,VB  Test/xUnit
Razor Component          razorcomponent       [C#]        Web/ASP.NET
Razor Page               page                 [C#]        Web/ASP.NET
MVC ViewImports          viewimports          [C#]        Web/ASP.NET
MVC ViewStart            viewstart            [C#]        Web/ASP.NET
Blazor Server App        blazorserver         [C#]        Web/Blazor
Blazor WebAssembly App   blazorwasm           [C#]        Web/Blazor/WebAssembly
ASP.NET Core Empty       web                  [C#],F#     Web/Empty
ASP.NET Core Web App...  mvc                  [C#],F#     Web/MVC
ASP.NET Core Web App     webapp               [C#]        Web/MVC/Razor Pages
ASP.NET Core with An...  angular              [C#]        Web/MVC/SPA
ASP.NET Core with Re...  react                [C#]        Web/MVC/SPA
ASP.NET Core with Re...  reactredux           [C#]        Web/MVC/SPA
Razor Class Library      razorclasslib        [C#]        Web/Razor/Library/Razor Class Library
ASP.NET Core Web API     webapi               [C#],F#     Web/WebAPI
ASP.NET Core gRPC Se...  grpc                 [C#]        Web/gRPC
dotnet gitignore file    gitignore                        Config
global.json file         globaljson                       Config
NuGet Config             nugetconfig                      Config
Dotnet local tool ma...  tool-manifest                    Config
Web Config               webconfig                        Config
Solution File            sln                              Solution
Protocol Buffer File     proto                            Web/gRPC

Examples:
    dotnet new mvc --auth Individual
    dotnet new webapp --auth Individual
    dotnet new --help
    dotnet new blazorwasm --help
PS D:\003_BasicFuctions2> dotnet new mvc --language F#
"ASP.NET Core Web App (Model-View-Controller)" 템플릿이 성공적으로 생성되었습니다.
이 템플릿에는 Microsoft 이외의 타사 기술이 포함되어 있습니다. 자세한 내용은https://aka.ms/aspnetcore/3.1-third-party-notices를 참조하세요.

생성 후 작업 처리 중...
D:\003_BasicFuctions2\003_BasicFuctions2.fsproj에서 'dotnet restore' 실행 중 ...
  복원할 프로젝트를 확인하는 중...
  D:\003_BasicFuctions2\003_BasicFuctions2.fsproj을(를) 23.72 sec 동안 복원했습니다.
복원에 성공했습니다.

PS D:003_BasicFuctions2> ls

    Directory: D:\003_BasicFuctions2

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
d----        2022-12-06 오후 12:50                Controllers
d----        2022-12-06 오후 12:50                Models
d----        2022-12-06 오후 12:51                obj
d----        2022-12-06 오후 12:50                Properties
d----        2022-12-06 오후 12:50                Views
d----        2022-12-06 오후 12:50                wwwroot
-a---        2022-12-06 오후 12:50            558 003_BasicFuctions2.fsproj
-a---        2022-12-06 오후 12:50            162 appsettings.Development.json
-a---        2022-12-06 오후 12:50            184 appsettings.json
-a---        2022-12-06 오후 12:50            676 Program.fs
-a---        2022-12-06 오후 12:50           1907 Startup.fs

PS D:003_BasicFuctions2> dotnet run
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: https://localhost:5001
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: D:\young_project\f_sharp_lang\F_Sharp_Lang\exercise\003_BasicFuctions2
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...


chorome 열고 
 http://localhost:5000

하면 웹 화면 보인다
```

<br>
