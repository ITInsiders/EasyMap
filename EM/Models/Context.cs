using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EM.Models
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public Context(string connString) : base(connString)
        {

        }
    }
}