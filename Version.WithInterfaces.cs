namespace WithInterfaces
{
    using Ex4_Inna_Adam;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CurrVersion : IClickable
    {
        public void ItemAction()
        {
            Console.WriteLine("Version: 20.2.4.30620");
        }
    }
}