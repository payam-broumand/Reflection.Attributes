using System;

namespace Attributes
{
    public class MemberProfileAttribute : Attribute
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

        public MemberProfileAttribute(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }
         
    }
}
