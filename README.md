# AutoStartMaster

AutoStartMaster is a small tool written in C# that automatically launches your frequently used websites and applications when your computer starts up.

## Features

- Automatically opens specified websites.
- Automatically launches specified applications.

## How to Use

1. Download and install .NET Core.
2. Clone this repository or download the zip file.
3. Open the `Program.cs` file and fill in the `urls` array with the URLs of the websites you want to open automatically.
4. If you want to automatically launch the LINE application, make sure its installation path matches the path in the `linePath` variable.
5. Navigate to this project's directory in the terminal, then run the `dotnet run` command.

## Notes

- Make sure you have Chrome browser and LINE application installed on your system.
- Make sure the paths of `chrome.exe` and `LineLauncher.exe` are added to your system environment variables.

## Feedback

If you encounter any problems while using it, or have any suggestions, feel free to submit an Issue or Pull Request.