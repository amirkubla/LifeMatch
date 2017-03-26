﻿namespace LifeMatch.Models
{
    public class MemberModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Enums.Gender Gender { get; set; }
    }
}