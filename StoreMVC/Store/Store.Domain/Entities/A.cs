using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class A
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<B> BB { get; set; }
    }
}
