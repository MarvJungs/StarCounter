using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit_Sync_Console
{
    internal class ProcessManager
    {
        const string processName = "Project64";

        private readonly Process _emulator;
        public ProcessManager() 
        {
            List<Process> emulatorProcesses = Process.GetProcessesByName(processName).ToList<Process>();
            if (emulatorProcesses.Count <= 0) 
            {
                throw new Exception("Emulator not found");
            }
            _emulator = emulatorProcesses.First<Process>();
        }

        public int ReadMemory(nint address)
        {
            if (!_emulator.ReadValue(address, out int val))
            {
                return 0;
            }
            return val;
        }

        public nint GetBaseAddress()
        {
            // hardcoded values because GetSystemInfo / GetNativeSystemInfo can't return info for remote process
            var min = 0x10000L;
            var max = _emulator.Is64Bit() ? 0x00007FFFFFFEFFFFL : 0xFFFFFFFFL;

            var mbiSize = (UIntPtr)0x30; // Clueless

            var addr = min;
            do
            {
                if (WinAPI.VirtualQueryEx(_emulator.Handle, (IntPtr)addr, out MemoryBasicInformation mbi, mbiSize) == (UIntPtr)0)
                    break;

                addr += (long)mbi.RegionSize;

                if (mbi.State != MemPageState.MEM_COMMIT)
                    continue;

                if ((mbi.Protect & MemPageProtect.PAGE_GUARD) != 0)
                    continue;

                if (mbi.Type != MemPageType.MEM_PRIVATE)
                    continue;

                if (((int)mbi.Protect & (int)0xcc) == 0)
                    continue;

                uint val;
                if (!_emulator.ReadValue(mbi.BaseAddress, out val))
                {
                    continue;
                }
                if ((val & 0xfffff000) == 0x3C1A8000)
                {
                    return mbi.BaseAddress;
                }
            } while (addr < max);
            return IntPtr.Zero;
        }
    }
}
