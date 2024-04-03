using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSIoT.DomainObjects
{
    public class User
    {
        public enum Prof
        {
            Prof1, //Professor.........Expert Doctor
            Prof2, //Students Computer&&Power..........Expert Nurse
            Prof3, //Students Mathematic...............Doctor
            Prof4, //Students Computer&&Power-Computer...........Nurse
            Prof5 //Student Computer&&Power-Power................NormalPerson
        };

        public int Id
        {
            get;
            set;
        }

        public Prof Profession
        {
            get;
            set;
        }

        public List<int> Links
        {
            get;
            set;
        }

        public List<int> Communities
        {
            get;
            set;
        }
        //to check the task context
        public List<int> GroupCommunities
        {
            get;
            set;
        }

        public List<int> Devices
        {
            get;
            set;
        }

        public static User GetUser(int id, int prof_num)
        {
            User u=new User();
            u.Id=id;
            u.Profession=GetProfByNumber(prof_num);
            u.Links = new List<int>();
            u.Communities = new List<int>();
            u.GroupCommunities = new List<int>();
            u.Devices = new List<int>();
            return u;
        }

        public static int GetNumberByProf(Prof prof)
        {
            switch (prof)
            {
                case Prof.Prof1:
                    return 1;
                case Prof.Prof2:
                    return 2;
                case Prof.Prof3:
                    return 3;
                case Prof.Prof4:
                    return 4;
                case Prof.Prof5:
                    return 4;
            }
            return 2;
        }

        public static Prof GetProfByNumber(int prof_num)
        {
            switch (prof_num)
            {
                case 1:
                    return Prof.Prof1;
                case 2:
                    return Prof.Prof2;
                case 3:
                    return Prof.Prof3;
                case 4:
                    return Prof.Prof4;
                case 5:
                    return Prof.Prof5;
            }
            return Prof.Prof1;
        }

    }
}
