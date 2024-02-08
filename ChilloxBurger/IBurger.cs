using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilloxBurger
{
    public interface IBurger
    {
        void display();
        decimal cost(decimal cost);
    }
}
