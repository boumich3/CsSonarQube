using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SonarQubeCs.Domain
{
    public class sonarQubeBadClass
    {
        public string x;
        public String Y;
        public Int64 LARGE_INT { get; set; }

        public void myFunction(out string test)
        {
            test = "Stap doing this to me please";
        }

        public String myFunction2(out string test)
        {
            test = "Stap doing this to me please";

            var testIsBeingUsed = test + "!";

            return testIsBeingUsed;
        }

        public void P(out String test)
        {
            test = "Stap doing this to me please";

            StringBuilder sb = new StringBuilder(test);
            sb.Append("!");

            test = sb.ToString();
            Y = sb.ToString();
        }
    }
}