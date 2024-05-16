using Interface2.Devices;
using System;

namespace Interfaces2.Devices {
    class ComboDevice : Device, IScanner, IPrinter {
        public void Print(string document) {
            Console.WriteLine("Combodevice print " + document);
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("Combodevice processing " + document);
        }

        public string Scan() {
            return "Combodevice scan result";
        }
    }
}
