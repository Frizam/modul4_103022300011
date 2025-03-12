using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300011
{
    internal class FanLaptop
    {
        public enum FanState{
            Quiet,
            Balanced,
            Performance,
            Turbo
        }
        public FanState currentState;

        public FanLaptop() { //untuk meng-set state awal jadi quiet
            currentState = FanState.Quiet;
            Console.WriteLine("Fan sedang Quiet");
        }
        // Method untuk Quiet mode
        public void QuietMode()
        {
            if (currentState == FanState.Turbo)
            {
                Console.WriteLine("Turbo Shortcut..."); //Trigger
                currentState = FanState.Quiet;
                Console.WriteLine("Fan Turbo berubah menjadi Quiet");
            }
            else if (currentState == FanState.Balanced) {
                Console.WriteLine("Mode Down...");//Trigger
                currentState = FanState.Quiet;
                Console.WriteLine("Fan Balanced berubah menjadi Quiet");
            }
            else
            {
                Console.WriteLine("Fan sudah Quiet");
            }
        }

        // Method untuk Turbo mode
        public void TurboMode()
        {
            if (currentState == FanState.Quiet)
            {
                Console.WriteLine("Turbo Shortcut...");//Trigger
                currentState = FanState.Turbo;
                Console.WriteLine("Fan Quiet berubah menjadi Turbo");
            }
            else if (currentState == FanState.Performance)
            {
                Console.WriteLine("Mode Up...");//Trigger
                currentState = FanState.Turbo;
                Console.WriteLine("Fan Performance berubah menjadi Turbo");
            }
            else
            {
                Console.WriteLine("Fan sudah Turbo");
            }
        }

        // Method untuk Balanced mode
        public void BalancedMode()
        {
            if (currentState == FanState.Quiet)
            {
                Console.WriteLine("Mode Up...");//Trigger
                currentState = FanState.Balanced;
                Console.WriteLine("Fan Quiet berubah menjadi Balanced");
            }
            else if (currentState == FanState.Performance)
            {
                Console.WriteLine("Mode Down...");//Trigger
                currentState = FanState.Balanced;
                Console.WriteLine("Fan Performance berubah menjadi Balanced");
            }
            else
            {
                Console.WriteLine("Fan sudah Balanced");
            }
        }
    }   
}
