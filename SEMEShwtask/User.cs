using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMEShwtask
{
   public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NotRobotCode { get; set; }
        public RegistrationMonth Month { get; set; }

        public string GetDetails(int id, string name, string surname, int notRobotCode, int registrationMonth)
        {
            return $"{id}{name}{surname}{notRobotCode}{registrationMonth}";
        }
        public enum RegistrationMonth
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };
        private static int id = 1;
        public User(string name, string surname, string notRobotCode, RegistrationMonth month)
        {
            Id = id++;
            Name = name;
            Surname = surname;
            this.Month = month;
            this.NotRobotCode = notRobotCode;
        }
        public (int, string, string, string, RegistrationMonth) GetDetails()
        {
            if (Extension.CheckNotRobotCode(NotRobotCode))
            {
                return (Id, Name, Surname, NotRobotCode, Month);
            }
            else
            {
                Console.WriteLine("Not a correct password entered for below registered user");
                return (Id, Name, Surname, NotRobotCode, Month);
            }
        }
    }
}
