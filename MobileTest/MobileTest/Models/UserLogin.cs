using System;
using SQLite;

namespace MobileTest.Models
{
    public class UserLogin
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }
        public string Passwd { get; set; }
    }
}
        