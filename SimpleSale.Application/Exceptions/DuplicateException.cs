using SimpleSale.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Application.Exceptions
{
    public class DuplicateException : Exception
    {
        public DuplicateException() : base(MessageConstant.DuplicateException) { }

        public DuplicateException(string message) : base(message) { }

        public DuplicateException(string message, Exception exception) : base(message, exception) { }
    }
}
