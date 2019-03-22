using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Security.Policy;
using System.Management;
using System.Management.Instrumentation;

namespace ConsoleApp1
{

    


    public struct Temperature
        {
            public readonly bool Active;
            public readonly uint[] ActiveTripPoint;
            public readonly uint ActiveTripPointCount;
            public readonly uint CriticalTripPointRaw;
            public readonly uint CurrentTemperatureRaw;
            public readonly string InstanceName;

            public Temperature(bool active, uint[] activeTripPoint, uint activeTripPointCount, uint criticalTripPointRaw, uint currentTemperatureRaw, string instanceName) : this()
            {
                Active = active;
                ActiveTripPoint = activeTripPoint;
                ActiveTripPointCount = activeTripPointCount;
                CriticalTripPointRaw = criticalTripPointRaw;
                CurrentTemperatureRaw = currentTemperatureRaw;
                InstanceName = instanceName;
            }

            public double CriticalTripPoint
            {
                get { return CriticalTripPointRaw * 0.1 - 273.15; }
            }

            public double CurrentTemperature
            {
                get { return CurrentTemperatureRaw * 0.1 - 273.15; }
            }

            public static IEnumerable<Temperature> Instances
            {
                get
                {
                    var searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
                    return from ManagementObject obj in searcher.Get()
                           select new Temperature((bool)obj["Active"], (uint[])obj["ActiveTripPoint"], (uint)obj["ActiveTripPointCount"],
                                                  (uint)obj["CriticalTripPoint"], (uint)obj["CurrentTemperature"], (string)obj["InstanceName"]);
                }
            }

            public override string ToString()
            {
                return string.Format("Active: {0}, ActiveTripPoint: [{1}], ActiveTripPointCount: {2}, InstanceName: {3}, CriticalTripPoint: {4}, CurrentTemperature: {5}",
                                      Active, string.Join(", ", ActiveTripPoint), ActiveTripPointCount, InstanceName,
                                      CriticalTripPoint, CurrentTemperature);
            }
        }


    class Program
    {
        static void Main(string[] args)
        {
            object result = String.Empty;
            foreach (var temperature in Temperature.Instances)
            {
                var searcher = new ManagementObjectSearcher(
            "SELECT DesiredSpeed FROM Win32_Fan");
                foreach (ManagementObject obj in searcher.Get())
                {
                    result = obj["DesiredSpeed"].ToString(); Console.WriteLine(result);
                }
                Console.WriteLine(temperature);
                Console.ReadKey();
            }
        }
    }


}