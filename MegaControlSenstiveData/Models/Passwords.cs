using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaControlSenstiveData.Models
{
    public class Passwords
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string Passowrd { get; set; }

        public string CreateDate { get; set; }
    }
}
