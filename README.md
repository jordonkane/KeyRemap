# KeyRemap
KeyRemap ⌨️ is a .NET Core desktop application that enables users to remap keyboard keys via the Windows Registry, providing a simplified interface for customizing key mappings.

## Features
Remap Keys: Choose a key to remap and assign it to another key.
List Remapped Keys: View all the keys that have been remapped (future feature).
Permanent Key Remapping: Changes are applied system-wide and persist after restarting.

## How It Works
The application leverages the Windows Registry to apply key mappings. It writes the scancode map in the registry, which the system loads during startup, effectively remapping keys at the hardware level.

#### Key Functionalities:
Scancode Map: The application modifies the scancode map, which instructs Windows to treat one key's input as another.
Registry Manager: Handles the writing and resetting of key mappings in the Windows Registry.
Command Parser: Accepts command-line arguments to trigger different functions like remapping keys or resetting mappings.

## Prerequisites
1. `.NET 6.0 SDK` or later
2. `Windows Operating System`

## Installation
1. Clone this repository to your local machine:
```
git clone https://github.com/jordonkane/KeyRemap.git
```
2. Navigate into the project directory::
```
cd KeyRemap
```
3. Build the solution:
```
dotnet build
```

## Usage
Once the application is built, you can run it from the command line with the following commands:

#### Remap a Key
To remap a key, use the `remap` command. The program will prompt you to press the key you want to remap and enter the key you want to map it to.
```
keyremap.exe remap
```
#### Command Help
If no arguments are passed, the program will display the help instructions:
```
keyremap.exe
```
## How to Contribute
If you would like to contribute to KeyRemap, feel free to fork the repository and submit a pull request. Contributions for new features like displaying remapped keys are welcome!
1. Fork the repository.
2. Create a feature branch.
3. Push your changes.
4. Submit a pull request.

## Known Issues
- The application requires administrative privileges to modify the Windows Registry.
- Currently, there is no functionality to read remapped keys directly from the registry due to the way Windows handles scancode mappings.

## Future Features
- Add support to display remapped keys.
- Improve the user interface for a better experience (possibly with a GUI version).

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Credits
Developed by Jordon Kane
