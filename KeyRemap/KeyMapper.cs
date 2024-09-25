using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRemap
{
    public class KeyMapper
    {
        public static void StartRemapping()
        {
            // capture the key the user wants to remap
            Console.WriteLine("Press the key you want to remap:");
            string originalKey = UserInput.CaptureKey();

            // get the scancode from the key name
            int originalScancode = ScancodeMapBuilder.GetScancodeFromKeyName(originalKey);
            if (originalScancode == -1)
            {
                Console.WriteLine($"Invalid key: {originalKey}. Aborting.");
                return;
            }

            // show the key name and ask for confirmation
            Console.WriteLine($"You pressed: {originalKey}. Do you want to remap this key? (y/n)");
            if (!UserInput.Confirm())
            {
                Console.WriteLine("Remapping cancelled.");
                return;
            }

            // show the list of available key names as reference
            Console.WriteLine("Here is a list of available keys to remap it to:");
            ScancodeMapBuilder.DisplayAvailableKeyNames();

            // ask for the new key name
            string newKeyName = UserInput.Prompt("Type the name of the key you want to remap it to:");
            int newScancode = ScancodeMapBuilder.GetScancodeFromKeyName(newKeyName);

            if (newScancode == -1)
            {
                Console.WriteLine($"Invalid key: {newKeyName}. Remapping cancelled.");
                return;
            }

            // ask for final confirmation
            Console.WriteLine($"Are you sure you want to remap {originalKey} to {newKeyName}? (y/n)");
            if (!UserInput.Confirm())
            {
                Console.WriteLine("Remapping cancelled.");
                return;
            }

            // perform the key remapping in the registry
            RegistryManager.RemapKeyInRegistry(originalScancode, newScancode);
            Console.WriteLine("Key remapped. Please restart your computer for the changes to take effect.");
        }
    }

}
