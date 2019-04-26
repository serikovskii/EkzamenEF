using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamenEF.Models
{
    public class Updated : Entity
    {
        public Guid UpdatedObjectId { get; set; }
        public string OldNameObject { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Updated()
        {
            UpdatedDate = DateTime.Now;
        }
        
    }
}
