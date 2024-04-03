using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSIoT.DomainObjects
{
    public class Unit
    {
        public enum Type
        {
            P1,
            P2,
            P3,
            P4,
            P5,
            P6,
            P7,
            P8,
            P9,
            P10
        };

        public static Type GetUnitByNumber(int n)
        {
            switch (n)
            {
                case 1:
                    return Type.P1;
                case 2:
                    return Type.P2;
                case 3:
                    return Type.P3;
                case 4:
                    return Type.P4;
                case 5:
                    return Type.P5;
                case 6:
                    return Type.P6;
                case 7:
                    return Type.P7;
                case 8:
                    return Type.P8;
                case 9:
                    return Type.P9;
                case 10:
                    return Type.P10;
            }
            return Type.P1;
        }


        public static int GetNumberByUnit(Type P)
        {
            switch (P)
            {
                case Type.P1:
                    return 1;
                case Type.P2:
                    return 2;
                case Type.P3:
                    return 3;
                case Type.P4:
                    return 4;
                case Type.P5:
                    return 5;
                case Type.P6:
                    return 6;
                case Type.P7:
                    return 7;
                case Type.P8:
                    return 8;
                case Type.P9:
                    return 9;
                case Type.P10:
                    return 10;
            }
            return 1;
        }
    }
}
