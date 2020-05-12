using SampleCL;
using SampleRL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRL.Services
{
    public class SampleRL : ISampleRL
    {
        public string Return_Name(Sample model)
        {
            return "My name is " + model.Name;
        }
    }
}
