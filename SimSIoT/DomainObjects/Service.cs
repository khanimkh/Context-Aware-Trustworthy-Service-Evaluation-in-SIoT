using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSIoT.DomainObjects
{
    public class Service
    {
        //*************************************************************GENERAL*************************************************************//

        public enum Type
        {
            S1,
            S2,
            S3,
            S4,
            S5
        };

        public enum Time
        {
            Next_Month,
            Today,
            Last_Months,//form 1 month to 1 year
            Last_Years,//from 1 year to 5 year
        };

        //******************SERVICE REQUESTER*******************//

        public enum QoS
        {
            good,
            mid,
            bad
        };

        public enum TimeResponse
        {
            good,
            mid,
            bad
        };

        //******************SERVICE PROVIDER*******************//

        public enum TimeUsing
        {
            good,
            mid,
            bad
        };

        public enum ReosurcesUsing
        {
            good,
            mid,
            bad
        };

        //*************************************************************GENERAL*************************************************************//

        public Unit.Type Location_Service
        {
            get;
            set;
        }

        public Time Time_Service
        {
            get;
            set;
        }

        public Type Services_Provided
        {
            get;
            set;
        }

        public Type Services_Requetsed
        {
            get;
            set;
        }

        public Type SubServices_Requetsed
        {
            get;
            set;
        }

        //******************SERVICE REQUESTER*******************//

        public TimeResponse Time_Response
        {
            get;
            set;
        }

        public QoS OoS
        {
            get;
            set;
        }

        public double Cost
        {
            get;
            set;
        }

        public double Speed
        {
            get;
            set;
        }

        //******************SERVICE PROVIDER*******************//

        public TimeUsing Time_Using
        {
            get;
            set;
        }

        public ReosurcesUsing Reosurces_Using
        {
            get;
            set;
        }

        //*************************************************************GENERAL*************************************************************//

        public static Service GetServiceForSP(int service_num, int time_num, int location_num, int timeResponse_num, int OoS_num, int timeUsing_num, int reosurcesUsing_num)
        {
            Service service = new Service();

            service.Services_Provided = GetServiceByNumber(service_num);
            service.Time_Service = GetTimeByNumber(time_num);
            service.Location_Service = Unit.GetUnitByNumber(location_num);
            service.Time_Response = GetTimeResponseByNumber(timeResponse_num);
            service.OoS = GetQoSByNumber(OoS_num);
            service.Time_Using = GetTimeUsingByNumber(timeUsing_num);
            service.Reosurces_Using = GetReosurcesUsingByNumber(reosurcesUsing_num);

            return service;
        }

        public static Service GetServiceForSR(int service_num, int subService_num, int time_num, int location_num, int timeResponse_num, int OoS_num,int timeUsing_num, int reosurcesUsing_num, double cost, double speed)
        {
            Service service = new Service();

            service.Services_Requetsed = GetServiceByNumber(service_num);
            service.SubServices_Requetsed = GetServiceByNumber(subService_num);
            service.Time_Service = GetTimeByNumber(time_num);
            service.Location_Service = Unit.GetUnitByNumber(location_num);
            service.Time_Response = GetTimeResponseByNumber(timeResponse_num);
            service.OoS = GetQoSByNumber(OoS_num);
            service.Time_Using = GetTimeUsingByNumber(timeUsing_num);
            service.Reosurces_Using = GetReosurcesUsingByNumber(reosurcesUsing_num);
            service.Cost = cost;
            service.Speed = speed;
            return service;
        }

        public static Time GetTimeByNumber(int time_num)
        {
            switch (time_num)
            {
                case 1:
                    return Time.Next_Month;
                case 2:
                    return Time.Today;
                case 3:
                    return Time.Last_Months;
                case 4:
                    return Time.Last_Years;
            }
            return Time.Today; ;
        }

        public static int  GetNumberByTime(Time time)
        {
            switch (time)
            {
                case Time.Next_Month:
                    return 1;
                case Time.Today:
                    return 2;
                case Time.Last_Months:
                    return 3;
                case Time.Last_Years:
                    return 4;
            }
            return 2;
        }

        public static Type GetServiceByNumber(int service_num)
        {
            switch (service_num)
            {
                case 1:
                    return Type.S1;
                case 2:
                    return Type.S2;
                case 3:
                    return Type.S3;
                case 4:
                    return Type.S4;
                case 5:
                    return Type.S5;
            }
            return Type.S1; ;
        }

        public static int GetNumberByService(Type service)
        {
            switch (service)
            {
                case Type.S1:
                    return 1;
                case Type.S2:
                    return 2;
                case Type.S3:
                    return 3;
                case Type.S4:
                    return 4;
                case Type.S5:
                    return 5;
            }
            return 1 ;
        }

        //******************SERVICE REQUESTER*******************//

        public static int GetNumberByQoS(QoS Qos)
        {
            switch (Qos)
            {
                case QoS.good:
                    return 1;
                case QoS.mid:
                    return 2;
                case QoS.bad:
                    return 3;
            }
            return 1;
        }

        public static int GetNumberByQoS_Optimal(QoS Qos_Optimal)
        {
            switch (Qos_Optimal)
            {
                case QoS.good:
                    return 3;
                case QoS.mid:
                    return 2;
                case QoS.bad:
                    return 1;
            }
            return 1;
        }

        public static QoS GetQoSByNumber(int Oos_num)
        {
            switch (Oos_num)
            {
                case 1:
                    return QoS.good;
                case 2:
                    return QoS.mid;
                case 3:
                    return QoS.bad;
            }
            return QoS.good; ;
        }

        public static QoS GetQoS_OptimalByNumber(int Oos_Optimal_num)
        {
            switch (Oos_Optimal_num)
            {
                case 3:
                    return QoS.good;
                case 2:
                    return QoS.mid;
                case 1:
                    return QoS.bad;
            }
            return QoS.bad; ;
        }

        public static int GetNumberByTimeResponse(TimeResponse timeResponse)
        {
            switch (timeResponse)
            {
                case TimeResponse.good:
                    return 1;
                case TimeResponse.mid:
                    return 2;
                case TimeResponse.bad:
                    return 3;
            }
            return 1;
        }

        public static TimeResponse GetTimeResponseByNumber(int timeResponse_num)
        {
            switch (timeResponse_num)
            {
                case 1:
                    return TimeResponse.good;
                case 2:
                    return TimeResponse.mid;
                case 3:
                    return TimeResponse.bad;
            }
            return TimeResponse.good; ;
        }

        //******************SERVICE PROVIDER*******************//

        public static int GetNumberByReosurcesUsing(ReosurcesUsing reosurcesUsing)
        {
            switch (reosurcesUsing)
            {
                case ReosurcesUsing.good:
                    return 1;
                case ReosurcesUsing.mid:
                    return 2;
                case ReosurcesUsing.bad:
                    return 3;
            }
            return 1;
        }

        public static ReosurcesUsing GetReosurcesUsingByNumber(int reosurcesUsing_num)
        {
            switch (reosurcesUsing_num)
            {
                case 1:
                    return ReosurcesUsing.good;
                case 2:
                    return ReosurcesUsing.mid;
                case 3:
                    return ReosurcesUsing.bad;
            }
            return ReosurcesUsing.good; ;
        }

        public static int GetNumberByTimeUsing(TimeUsing timeUsing)
        {
            switch (timeUsing)
            {
                case TimeUsing.good:
                    return 1;
                case TimeUsing.mid:
                    return 2;
                case TimeUsing.bad:
                    return 3;
            }
            return 1;
        }

        public static TimeUsing GetTimeUsingByNumber(int timeUsing_num)
        {
            switch (timeUsing_num)
            {
                case 1:
                    return TimeUsing.good;
                case 2:
                    return TimeUsing.mid;
                case 3:
                    return TimeUsing.bad;
            }
            return TimeUsing.good; ;
        }

        //*********************************************************END************************************************************//
    }
}
