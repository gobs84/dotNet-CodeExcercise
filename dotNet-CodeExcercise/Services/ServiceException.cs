using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_CodeExcercise.Services
{
    class ServiceException:Exception
    {
        public int code { set; get; }
        public ServiceException(string msg, int code) : base(msg)
        {
            this.code = code;
        }
    }
}
