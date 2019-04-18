using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroChempionship2020
{
    class GroupInfo
    {
        private int _Win;

        public int Win
        {
            get { return _Win; }
            set
            {
                if(value >=0 && value <= 3)
                    
                _Win = value;
            }
        }


        private int _Drow;

        public int MyProperty
        {
            get { return _Drow; }
            set
            {
                if (value >= 0 && value <= 3)
                    _Drow = value;
            }
        }


        private int _Lose;

        public int Lose
        {
            get { return _Lose; }
            set
            {
                if (value >= 0 && value <= 3)
                    _Lose = value;
            }
        }

        private int _Point;

        public int Point
        {
            get { return _Point; }
            set
            {
                if (value >= 0 && value <= 9)
                    _Point = value;
            }
        }



    }
}
