using System;
using System.Collections.Generic;
using System.Text;

namespace Veiling
{
    public class Veiling
    {
        private decimal hoogsteBod;
        public void DoeBod(decimal bod)
        {
            if (bod > hoogsteBod)
            {
                hoogsteBod = bod;
            }
        }
        public decimal HoogsteBod
        {
            get
            {
                return hoogsteBod;
            }
            
        } 
        
            
    }
}
