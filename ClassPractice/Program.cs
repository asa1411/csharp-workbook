using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            _2DPoint p1 = new _2DPoint(3, 4);
            _3Dpoint p2 = new _3Dpoint(4, 5, 6);
            Console.WriteLine("p1 = {0}", p1);
            Console.WriteLine("p2 = {0}", p2);
        }
    }
    public class _2DPoint
    {
        public int xComponent;
        public int yComponent;
        public _2DPoint(int x, int y)
        {
            this.xComponent = x;
            this.yComponent = y;
        }
        override
                public String ToString()
        {
            String s = String.Format("({0}, {1})", xComponent, yComponent);
            return s;
        }
        override
        public bool Equals(_2DPoint otherPoint)
        {
            if(this.xComponent ==otherPoint.xComponent && this.yComponent==otherPoint.yComponent)
            {return true;}
        }else{
            return false;
        }
//Most methods we use are equals and toString in 
    }
    public class _3Dpoint : _2DPoint//extend and inherit all 2Dpoint
    {

        public int zComponent;
        public _3Dpoint(int x, int y, int z) : base(x, y)
        {
            //
            this.zComponent = z;
        }
        override
        public String ToString()
        {
            String s = String.Format("({0}, {1}, {2})", xComponent, yComponent, zComponent);
            return s;
        }


        }
    }
    
    }
}
