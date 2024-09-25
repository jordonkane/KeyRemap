using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRemap
{
    public class ScancodeMapBuilder
    {
        private static Dictionary<string, int> keyNameToScancode = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "A", 0x1E }, { "B", 0x30 }, { "C", 0x2E }, { "D", 0x20 }, { "E", 0x12 },
            { "F", 0x21 }, { "G", 0x22 }, { "H", 0x23 }, { "I", 0x17 }, { "J", 0x24 },
            { "K", 0x25 }, { "L", 0x26 }, { "M", 0x32 }, { "N", 0x31 }, { "O", 0x18 },
            { "P", 0x19 }, { "Q", 0x10 }, { "R", 0x13 }, { "S", 0x1F }, { "T", 0x14 },
            { "U", 0x16 }, { "V", 0x2F }, { "W", 0x11 }, { "X", 0x2D }, { "Y", 0x15 },
            { "Z", 0x2C }, { "1", 0x02 }, { "2", 0x03 }, { "3", 0x04 }, { "4", 0x05 },
            { "5", 0x06 }, { "6", 0x07 }, { "7", 0x08 }, { "8", 0x09 }, { "9", 0x0A },
            { "0", 0x0B }, { "Space", 0x39 }, { "Enter", 0x1C }, { "Esc", 0x01 }
        };

        // get scancode from key name
        public static int GetScancodeFromKeyName(string keyName)
        {
            if (keyNameToScancode.TryGetValue(keyName, out int scancode))
            {
                return scancode;
            }
            return -1; // invalid key
        }

        // display all key names to the user
        public static void DisplayAvailableKeyNames()
        {
            Console.WriteLine("Available key names:");
            foreach (var keyName in keyNameToScancode.Keys)
            {
                Console.WriteLine(keyName);
            }
        }

        // build the scancode map byte array
        public static byte[] BuildScancodeMap(int originalScancode, int newScancode)
        {
            return new byte[]
            {
                0x00, 0x00, 0x00, 0x00,  // header
                0x00, 0x00, 0x00, 0x00,  // header cont.
                0x02, 0x00, 0x00, 0x00,  // number of mappings (1 remap + terminator)
                (byte)newScancode, 0x00, (byte)originalScancode, 0x00,  // mapping new key to old key
                0x00, 0x00, 0x00, 0x00   // terminator
            };
        }
    }
}

