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

## Supported Keys:
| Key         | Scancode |
|-------------|----------|
| `A`         | 0x1E     |
| `B`         | 0x30     |
| `C`         | 0x2E     |
| `D`         | 0x20     |
| `E`         | 0x12     |
| `F`         | 0x21     |
| `G`         | 0x22     |
| `H`         | 0x23     |
| `I`         | 0x17     |
| `J`         | 0x24     |
| `K`         | 0x25     |
| `L`         | 0x26     |
| `M`         | 0x32     |
| `N`         | 0x31     |
| `O`         | 0x18     |
| `P`         | 0x19     |
| `Q`         | 0x10     |
| `R`         | 0x13     |
| `S`         | 0x1F     |
| `T`         | 0x14     |
| `U`         | 0x16     |
| `V`         | 0x2F     |
| `W`         | 0x11     |
| `X`         | 0x2D     |
| `Y`         | 0x15     |
| `Z`         | 0x2C     |
| `1`         | 0x02     |
| `2`         | 0x03     |
| `3`         | 0x04     |
| `4`         | 0x05     |
| `5`         | 0x06     |
| `6`         | 0x07     |
| `7`         | 0x08     |
| `8`         | 0x09     |
| `9`         | 0x0A     |
| `0`         | 0x0B     |
| `Space`     | 0x39     |
| `Enter`     | 0x1C     |
| `Esc`       | 0x01     |
| `Tab`       | 0x0F     |
| `Backspace` | 0x0E     |
| `LeftShift` | 0x2A     |
| `RightShift`| 0x36     |
| `LeftCtrl`  | 0x1D     |
| `RightCtrl` | 0x1D     |
| `LeftAlt`   | 0x38     |
| `RightAlt`  | 0x38     |
| `CapsLock`  | 0x3A     |
| `F1`        | 0x3B     |
| `F2`        | 0x3C     |
| `F3`        | 0x3D     |
| `F4`        | 0x3E     |
| `F5`        | 0x3F     |
| `F6`        | 0x40     |
| `F7`        | 0x41     |
| `F8`        | 0x42     |
| `F9`        | 0x43     |
| `F10`       | 0x44     |
| `F11`       | 0x57     |
| `F12`       | 0x58     |

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
