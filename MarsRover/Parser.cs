using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{

   
    public class Parser
    {
        public int ind;
        public static Dictionary<string, Coordinate> _getvalue = new Dictionary<string, Coordinate>()
        {
            {"E",new Coordinate(){X=1,Y=0} },
            {"S",new Coordinate(){X=0,Y=-1} },
            {"W",new Coordinate(){X=-1,Y=0} },
            {"N",new Coordinate(){X=0,Y=1} },
            {"NE",new Coordinate(){X=1,Y=1} },
            {"SE",new Coordinate(){X=1,Y=-1} },
            {"SW",new Coordinate(){X=-1,Y=-1} },
            {"NW",new Coordinate(){X=-1,Y=1} },


        };
        public static Dictionary<string, int> _getindex = new Dictionary<string, int>()
        {

            {"N",1 },
            {"NE",2 },
            {"E",3},
            {"SE",4 },
            {"S",5},
            {"SW",6 },
            {"W",7},
            {"NW",8 },

        };
        public static Dictionary<int,string> _getstring = new Dictionary<int,string>()
        {

            {1,"N" },
            {2,"NE" },
            {3,"E" },
            {4,"SE" },
            {5,"S" },
            {6,"SW" },
            {7,"W" },
            {8,"NW" }
            //map for converting index to directions


        };


        public  void ChangeCoordinate( ref Direction direction,  ref Coordinate coordinate, ref CheckBoundaries check)
        {
            Coordinate coord = _getvalue[direction.Dir];
            var direct = new Coordinate()
            {
                X = coordinate.X + coord.X,
                Y = coordinate.Y + coord.Y



            };
            if (check.isvalid(direct.X, direct.Y))
            {


                coordinate.X = direct.X;

                coordinate.Y = direct.Y;

            }
           
        }

        public void ChangeDirection(char c, ref Direction direction)
        {
             ind = _getindex[direction.Dir];
            if (c=='R')
            {
                ind = (ind + 1) % 8;
                direction.Dir = _getstring[ind];
            }
            else
            {
                ind = ((ind +7) % 8)==0?8:ind;
                direction.Dir = _getstring[ind];
            }

        }
    }
}