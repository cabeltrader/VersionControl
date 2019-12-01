using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance.Entities
{
    class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Fullname { get; set; }

        //Fullname property kompaktabb formában
        /*
          public string FullName
          =>string.Format("{0} {1}",LastName,FirstName);
        */
    }
}
