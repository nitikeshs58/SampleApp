using SampleBL.Interface;
using SampleCL;
using SampleRL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBL.Services
{
    public class SampleBL : ISampleBL
    {
        private ISampleRL sample;
        public string Return_Name(Sample model)
        {
            return this.sample.Return_Name(model);
        }
        public SampleBL(ISampleRL sample)
        {
            this.sample = sample;
        }
    }
}
