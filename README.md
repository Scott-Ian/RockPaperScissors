# Rock Paper Scissors

#### C# application, 07/15/2020

#### By **Evgeniya Chernaya and Ian Scott**

## Description

Rock Paper Scissors game.

## Setup/Installation Requirements

* Click the green "Clone or download" button at the right of the screen.
* Select "Download ZIP."
* Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
* In your browser, navigate to https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer for Mac or https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer for Windows and click the link "click here to download manually" if the download for .NET Core 2.2 SDK does not start automatically.
* Double-click the downloaded .NET Core 2.2 SDK file and run the installer.
* Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
* Enter the command "dotnet build" in the terminal.
* Enter the command "dotnet run" in the terminal. The program should begin to run in the console.

## Specification

| Behavior | Input | Output|
|----------|-------|-------|
| A new game object is constructed with the user selection of Rock, Paper, or Scissors upon game start | Rock | You choose Rock! |
| Rock v. Scissors = Rock wins | player1 = Rock, player = Scissors | Rock wins! |
| Rock v. Paper = Paper wins | player1 = Rock, player = Paper | Paper wins! |
| Paper v. Scissors = Scissors wins | player1 = Paper, player = Scissors | Scissors wins! |
| If both people choose the same thing, then it is a draw and nobody wins | player1 = Paper, player = Paper | Draw |
| The user has the option of playing against a computer, which will randomly choose R/P/S | PlayAgainstComputer: Rock | The computer selected: Paper. You Loose! |


## Known Bugs

_No known bugs_

## Technologies Used

  * C# .Net
  * Visual Studio Code

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **Evgeniya Chernaya** & **Ian Scott**.