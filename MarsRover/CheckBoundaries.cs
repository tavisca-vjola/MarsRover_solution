namespace MarsRover
{
    public class CheckBoundaries
    {
       public  int maxX { set; get; }
        public int maxY { set; get; }

        public bool isvalid(int X,int Y)
        {
            if (X > this.maxX || Y > this.maxY)
                return false;
            if (X < 0 || Y < 0)
                return false;
            return true;
        }


    }
}