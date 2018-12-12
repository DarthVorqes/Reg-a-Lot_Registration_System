using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;


namespace RegistrationSystem
{
    class Section
    {

        public const byte Capacity = 10;
        //public User Professor { get; set; }
        //public User[] Students { get; set; }
        
        // Add BuildClassArray() here



        // Section Properties

        public int ID {get; private set;} = -1;

        public int SectionNumber{get; private set;}

        public string MeetingTimes {get; private set;}

        public string MeetingDays {get; private  set;}

        public int CourseID {get; private set;}

        public string Location {get; private set;}

        public DateTime StartDate {get; private set;}

        public DateTime EndDate {get; private  set;}

        public string Duration {get; private  set;}

        public int SemesterID {get; private set;}

        public int TeachID {get; private  set;}

        public int SectionCapacity {get; private  set;}

        public bool Status {get; private  set;}


       
    }
}
