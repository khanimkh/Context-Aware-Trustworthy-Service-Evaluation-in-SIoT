using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimSIoT.DomainObjects;

namespace SimSIoT.DomainObjects
{
    public class ServiceRequester
    {
       
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// 1 mobile object, 2 static object, 3 sensing object, 4 tagged object
        /// </summary>
        public int Type 
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
        public int OwnerId
        {
            get;
            set;
        }

        public List<int> Links
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

        /// <summary>
        /// from 1 to 5
        /// </summary>
        public int Services_Requested
        {
            get;
            set;
        }

        public List<Dictionary<ServiceProvider, double>> Potential_SP
        {
            get;
            set;
        }

        public List<Dictionary<ServiceProvider, double>> Trusthworthiness_SP
        {
            get;
            set;
        }

        public List<Dictionary<ServiceProvider, double[]>> Visited_SP_Feedback
        {
            get;
            set;
        }

        public List<Dictionary<ServiceProvider, double>> Visited_SP_Trust
        {
            get;
            set;
        }
    }
}
