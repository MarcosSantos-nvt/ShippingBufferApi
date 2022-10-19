using Havan.Core;

namespace Domain.Models.ModelTest
{
    public class Permission : Entity<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Ai_Created { get; set; }
        public int Version { get; set; }

        public Permission()
        {

        }
    }
}
