using System;

namespace Problems.Services
{
    public class Mathematics
    {
        public void Main()
        {
            TaskOne();
        }

        public void TaskOne()
        {
            var top = Math.Pow(2008, 3) + Math.Pow(2007, 2) + 3* 2008*2007 -1;
            var bottom = Math.Pow(2009, 2) + Math.Pow(2008, 2) + 1;
            Console.WriteLine($"{top} / {bottom}");
            var res = top / bottom;
        }
    }
}