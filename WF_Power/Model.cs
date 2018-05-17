using System;
using System.Diagnostics;

namespace WF_Power
{
   static class Model
    {
        public static void ShutDown()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public static void Restart()
        {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public static void Hiber()
        {
            var psi = new ProcessStartInfo("shutdown", "/h");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public static void SignOut()
        {
            var psi = new ProcessStartInfo("shutdown", "/l");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public static void Lock()
        {
            var psi = new ProcessStartInfo(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public static void Sleep()
        {
            var psi = new ProcessStartInfo(@"C:\WINDOWS\system32\rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }
    }
}