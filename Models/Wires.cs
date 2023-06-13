using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikitinAN_01_07
{
    /// <summary>
    /// Базовый класс
    /// </summary>
    public class Wires
    {
        int countCore { get; set; } // колличество жил кабеля
        double diametr { get; set; }  //Диаметр


       
        public Wires ( int countCore, double diametr)
        {
            
            this.countCore = countCore;
            this.diametr = diametr;
        }
        /// <summary>
        /// Q = диаметр / количество жил
        /// </summary>
        /// <returns></returns>
        public virtual double Q()
        {
            return diametr/countCore;
        }

    }
}
