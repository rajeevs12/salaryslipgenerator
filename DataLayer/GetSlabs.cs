using BussinessEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class GetSlab
    {
        List<Slabes> sl = new List<Slabes>();
        public List<Slabes> SetRange()
        {
            Slabes s1 = new Slabes();
            range r1 = new range();
            r1.min = 0; r1.max = 250000;
            s1.tax = 0;
            s1.range = r1;
            sl.Add(s1);

            Slabes s2 = new Slabes();
            range r2 = new range();
            r2.min = 250001; r2.max = 500000;
            s2.tax = 10;
            s2.range = r2;
            sl.Add(s2);

            Slabes s3 = new Slabes();
            range r3 = new range();
            r3.min = 500001; r3.max = 1000000;
            s3.tax = 20;
            s3.range = r3;
            sl.Add(s3);

            Slabes s4 = new Slabes();
            range r4 = new range();
            r4.min = 1000001; r4.max = int.MaxValue;
            s4.tax = 30;
            s4.range = r4;
            sl.Add(s4);

            return sl;
        }
    }
}
