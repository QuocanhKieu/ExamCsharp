using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Lion : Animal
    {
        public Lion(int weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Lion Details:");
            base.Show();
        }
    }
}
