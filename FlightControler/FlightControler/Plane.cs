using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightControler
{
    class Plane
    {
        int _Xkordinat;
        int _YKordinat;
        int _XSpeed;
        int _YSpeed;
        string _FlyID;

        public Plane(int Xkordinat, int YKordinat, int XSpeed, int YSpeed, string FlyID)
        {
            _Xkordinat = Xkordinat;
            _YKordinat = YKordinat;
            _XSpeed = XSpeed;
            _YSpeed = YSpeed;
            _FlyID = FlyID;
        }

        public int Xkordinat
        {
            get { return _Xkordinat; }
            set { _Xkordinat = value; }
        }

        public int Ykordinat
        {
            get { return _YKordinat; }
            set { _YKordinat = value; }
        }

        public int XSpeed
        {
            get { return _XSpeed;}
            set { _XSpeed = value; }
        }

        public int YSpeed
        {
            get { return _YSpeed; }
            set { _YSpeed = value; }
        }

        public string FlyID
        {
            get { return _FlyID; }
        }
    }
}
