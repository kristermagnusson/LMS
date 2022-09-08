﻿namespace LMS.Core.Entities
{
#nullable disable
    public class Document
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public string Description { get; set; }
        public DateTime LogDate { get; set; }
        public  string PathLog { get; set; }
        //foreign key
        public int UserId { get; set; }
        //nav prop
        public User User { get; set; }

    }
}