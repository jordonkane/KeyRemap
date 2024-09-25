using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRemap
{
    public class ScancodeMapBuilder
    {
        // dictionary mapping key names to scancodes
        private static Dictionary<string, int> keyNameToScancode = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
    {
        { "A", 0x1E }, { "B", 0x30 }, { "C", 0x2E }, { "D", 0x20 },
        { "E", 0x12 }, { "F", 0x21 }, { "G", 0x22 }, { "H", 0x23 },
        { "I", 0x17 }, { "J", 0x24 }, { "K", 0x25 }, { "L", 0x26 },
        { "M", 0x32 }, { "N", 0x31 }, { "O", 0x18 }, { "P", 0x19 },
        { "Q", 0x10 }, { "R", 0x13 }, { "S", 0x1F }, { "T", 0x14 },
        { "U", 0x16 }, { "V", 0x2F }, { "W", 0x11 }, { "X", 0x2D },
        { "Y", 0x15 }, { "Z", 0x2C }, { "1", 0x02 }, { "2", 0x03 },
        { "3", 0x04 }, { "4", 0x05 }, { "5", 0x06 }, { "6", 0x07 },
        { "7", 0x08 }, { "8", 0x09 }, { "9", 0x0A }, { "0", 0x0B },
        { "Space", 0x39 }, { "Enter", 0x1C }, { "Esc", 0x01 }, { "Tab", 0x0F },
        { "Backspace", 0x0E }, { "LeftShift", 0x2A }, { "RightShift", 0x36 },
        { "LeftCtrl", 0x1D }, { "RightCtrl", 0x1D }, { "LeftAlt", 0x38 },
        { "RightAlt", 0x38 }, { "CapsLock", 0x3A }, { "F1", 0x3B },
        { "F2", 0x3C }, { "F3", 0x3D }, { "F4", 0x3E }, { "F5", 0x3F },
        { "F6", 0x40 }, { "F7", 0x41 }, { "F8", 0x42 }, { "F9", 0x43 },
        { "F10", 0x44 }, { "F11", 0x57 }, { "F12", 0x58 }
    };

        // get the scancode from the key name
        public static int GetScancodeFromKeyName(string keyName)
        {
            return keyNameToScancode.TryGetValue(keyName, out int scancode) ? scancode : -1;
        }

        // display all available key names for user reference
        public static void DisplayAvailableKeyNames()
        {
            Console.WriteLine("Available key names:");
            foreach (var keyName in keyNameToScancode.Keys)
            {
                Console.WriteLine(keyName);
            }
        }
    }

}
