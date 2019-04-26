using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamenEF.Models
{
    public class Deleted : Entity
    {
        public Guid DeletedObjectId { get; set; }
        public DateTime DeletedDate { get; set; }

        public Deleted()
        {
            DeletedDate = DateTime.Now;
        }
    }
}
