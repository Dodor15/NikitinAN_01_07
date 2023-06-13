using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikitinAN_01_07
{
    /// <summary>
    /// Класс потомок
    /// </summary>
    public class WiresP : Wires
    {
        public bool P { get; set; } //Наличие оплетки
        public WiresP (int count, double diametr, bool p) : base(count, diametr)
        {
            this.P = p;
        }
        /// <summary>
        /// P: наличие оплетки Qp: если Р -
        ///истина, то Qp = 2·Q;
        ///иначе Qp = 0,7·Q
        /// </summary>
        /// <returns></returns>
        public double Qp ()
        {
            if (P)
            {
                return base.Q() * 2;
            }
            else
            {
                return base.Q() * 0.7;
            }

        }
    }
}
