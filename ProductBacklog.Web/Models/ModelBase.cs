using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBacklog.Web.Models
{
    public abstract class ModelBase
    {
        public string Id { get; set; }

        public ModelBase()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
