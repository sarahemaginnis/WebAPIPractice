﻿namespace WebAPIPractice.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }  
        public string ZipCode { get; set; }
        public string ProfilePicURL { get; set; }
    }
}
