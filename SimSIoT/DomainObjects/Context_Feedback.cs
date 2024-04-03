using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSIoT.DomainObjects
{
    public class Context_Feedback
    {
        public enum WorkLoad
        {
            WL1, //Smaller than 0.25 loadwork exists.........
            WL2, //Between 0.25 and 0.5 loadwork exists..........
            WL3, //equal with 0.5 loadwork exists............
            WL4, //Between 0.5 and 0.75 loadwork exists......
            WL5 //Between 0.75 and 1 loadwork exists.........
        };

        //************* Contexts of Class Device
        public int Id
        {
            get;
            set;
        }

        public int Computation
        {
            get;
            set;
        }

        public int Energy
        {
            get;
            set;
        }

        //************* Contexts of Class User
        public int Profession
        {
            get;
            set;
        }

        //************* Contexts of Class Unit
        //Location
        public int Location_Service
        {
            get;
            set;
        }
        //************* Contexts of Class Service
        //Time
        public int Time_Service
        {
            get;
            set;
        }

        //Service
        public int Services_Provided
        {
            get;
            set;
        }

        public int Services_Requetsed
        {
            get;
            set;
        }
        //************* Computing Contexts
        public int Workloads
        {
            get;
            set;
        }
        //*************
        public double Feedback
        {
            get;
            set;
        }
        //************Generall Functions
        public static int GetNumberByWorkLoad(WorkLoad wl)
        {
            switch (wl)
            {
                case WorkLoad.WL1:
                    return 1;
                case WorkLoad.WL2:
                    return 2;
                case WorkLoad.WL3:
                    return 3;
                case WorkLoad.WL4:
                    return 4;
                case WorkLoad.WL5:
                    return 5;
            }
            return 2;
        }

        public static WorkLoad GetWorkLoadByNumber(int wl)
        {
            switch (wl)
            {
                case 1:
                    return WorkLoad.WL1;
                case 2:
                    return WorkLoad.WL2;
                case 3:
                    return WorkLoad.WL3;
                case 4:
                    return WorkLoad.WL4;
                case 5:
                    return WorkLoad.WL5;
            }
            return WorkLoad.WL3;
        }
    }
}
