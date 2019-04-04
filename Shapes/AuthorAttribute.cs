using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class AuthorAttribute : Attribute
    {
        readonly string authorName;
        private string eMail;

        // This is a positional argument
        public AuthorAttribute(string authorName)
        {
            this.authorName = authorName;
        }

        public string AuthorName
        {
            get { return authorName; }
        }

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }
    }

}
