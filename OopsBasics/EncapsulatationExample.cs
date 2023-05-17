using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasics
{
    public class EncapsulatationExample
    {
        private int secKey;
        public int Rno 
        { 
            get => rno; 
            set => secKey = value; 
        }
    }
}
