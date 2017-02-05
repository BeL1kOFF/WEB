using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class B
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<C> CC { get; set; }
    }
}
