using System;

namespace T2008M_AP.T2008M.Ex2
{
    public class Lion : Base
    {
        public Lion()
        {
        }

        public Lion(double weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + this.name + ", Weight " + this.weight);
        }

        public override void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}