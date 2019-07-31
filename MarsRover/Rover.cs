using System;
namespace MarsRover
{
    public class Rover
    {

        public Coordinate coordinate; 
        public Direction direction;

       public CheckBoundaries check;

        public Parser parse;
        public Rover()
        {
            coordinate = new Coordinate();
            direction = new Direction();
            parse = new Parser();
            check = new CheckBoundaries();
        }
        
        public void GetInstruction(string recieve)
        {

            string[] parsed_recieve = recieve.Split(' ');
            //oordinate.X = x;
            coordinate.X=int.Parse(parsed_recieve[0]);
            //coordinate.Y = y;
            coordinate.Y=int.Parse(parsed_recieve[1]);
            direction.Dir = parsed_recieve[2];
            check.maxX =int.Parse(parsed_recieve[3]);
            check.maxY = int.Parse(parsed_recieve[4]);

            


        }
         public string CommandProccessor(string input)
        {
           // char [] inp =input.ToCharArray();
            foreach(var c in input)
            {
                if(c=='M')
                {
                    parse.ChangeCoordinate( ref direction, ref coordinate,ref check);
                }
                else
                {
                    parse.ChangeDirection(c, ref direction);
                }
            }
            return coordinate.X.ToString() + " " + coordinate.Y.ToString() + " " + direction.Dir;

        }




    }


}
