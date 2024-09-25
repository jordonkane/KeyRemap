using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace KeyRemap
{

    class RegistryManager
    {
        private static string registryPath = @"SYSTEM\CurrentControlSet\Control\Keyboard Layout";

        // write a new scancode map to the registry
        public static void RemapKeyInRegistry(byte[] scancodeMap)
        {
            // open the registry key with write access
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath, writable: true);
            if (key != null)
            {
                // write the scancode map to the registry
                key.SetValue("Scancode Map", scancodeMap, RegistryValueKind.Binary);
                key.Close();
                Console.WriteLine("Key remapping successful. Please restart your computer.");
            }
            else
            {
                Console.WriteLine("Error accessing the registry.");
            }
        }

        // reset the key mappings (reset the scancode map)
        public static void ResetKeyMappings()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath, writable: true);
            if (key != null)
            {
                // delete the scancode map value
                key.DeleteValue("Scancode Map", false);
                key.Close();
                Console.WriteLine("Key mappings reset. Please restart your computer.");
            }
        }
    }


}
