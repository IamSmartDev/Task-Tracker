using Microsoft.EntityFrameworkCore.SqlServer;
using TodoDomain;

namespace TodoDomain
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}