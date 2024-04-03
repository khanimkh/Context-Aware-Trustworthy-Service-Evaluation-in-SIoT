using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSIoT.DomainObjects
{
    public class Device
    {
        
         public Device()
         {
            
         }

        //************************************************GENERAL*************************************************************//
        public enum Device_Role
        {
            SP,
            SR
        };

        //******************//
        public int Id
        {
            get;
            set;
        }

        public int Energy
        {
            get;
            set;
        }

        public int Computation
        {
            get;
            set;
        }

       
        public Device_Role Role
        {
            get;
            set;
        }

        public bool HasOwner
        {
            get;
            set;
        }

        /// <summary>
        /// from 1 to 10
        /// </summary>
        public User User
        {
            get;
            set;
        }

        public int Links_Objects
        {
            get;
            set;
        }

        public List<int> Communities
        {
            get;
            set;
        }

        public int Centrality
        {
            get;
            set;
        }

        public Unit.Type Current_Location
        {
            get;
            set;
        }

        public List<Unit.Type> Visited_Locations
        {
            get;
            set;
        }

        public Service Services
        {
            get;
            set;
        }

        //Service Requester
        public int Satisfication
        {
            get;
            set;
        }

        //************************************************SERVICE REQUESTER*************************************************************//
       
        /// <summary>
        /// Service Requester
        /// </summary>

        public bool SR_IsTaskDone
        {
            get;
            set;
        }

        public Dictionary<Device, double> Potential_SP
        {
            get;
            set;
        }

        public Dictionary<Device, double> Trusthworthiness_SP
        {
            get;
            set;
        }

        public Dictionary<Device, List<Context_Feedback>> Visited_SP_Feedback
        {
            get;
            set;
        }

        public Dictionary<Device, double> Selected_SP
        {
            get;
            set;
        }


        //************************************************SERVICE PROVIDER*************************************************************//
    
        /// <summary>
        /// Service Provider
        /// </summary>
        public Dictionary<Device, double> Potential_SR
        {
            get;
            set;
        }

        public Dictionary<Device, double> Trusthworthiness_SR
        {
            get;
            set;
        }

        public Dictionary<Device, List<Context_Feedback>> Visited_SR_Feedback
        {
            get;
            set;
        }

        public Dictionary<Device, double> Selected_SR
        {
            get;
            set;
        }

        public double ground_Trust
        {
            get;
            set;
        }

        //*********************************************************GenFUNCTION************************************************************//

        public static Device_Role GetRoleByNumber(int role_num)
        {
            switch (role_num)
            {
                case 1:
                    return Device_Role.SP;
                case 2:
                    return Device_Role.SR;
            }
            return Device_Role.SP; 
        }

        public static int GetNumberByRole(Device_Role role)
        {
            switch (role)
            {
                case Device_Role.SP:
                    return 1;
                case Device_Role.SR:
                    return 2;
            }
            return 1;
        }

        public static double NextDouble(double minValue, double maxValue)
        {
            Random r = new Random();
            double n= r.NextDouble() * (maxValue - minValue) + minValue;
            return n;
        }

        //*********************************************************END************************************************************//
    
    }
}
