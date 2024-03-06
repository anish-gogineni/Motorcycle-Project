using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle_Project
{
    // Creating an interface called VehicleActions
    internal interface VehicleActions
    {
        // Start method
        string Start();

        // Stop method
        string Stop();

        // Accelerate method
        string Accelerate();

        // Brake method
        string Brake();

    }
}
