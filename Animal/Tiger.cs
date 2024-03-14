using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Tiger : Animal
    {
        public Tiger(int weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Tiger Details:");
            base.Show();
        }
    }
}
