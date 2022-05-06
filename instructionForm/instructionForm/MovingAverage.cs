using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instructionForm
{
    internal class MovingAverage
    {

        public int M;
        public List<float> data;
        public float sum;

        public MovingAverage(int size)
        {
            this.M = size;
            this.data = new List<float>();
            this.sum = 0;
        }

        public float Next(float val)
        {
            if (data.Count() < M)
            {
                data.Add(val);
                sum += val;
                return sum / data.Count;
            }
            else
            {
                sum -= data.First();
                data.RemoveAt(0);
                sum += val;
                data.Add(val);
                return sum / M;
            }



        }
    }
}
