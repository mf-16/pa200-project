using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;

        public void MarkAsDeleted()
        {
            IsDeleted = true;
            UpdatedDate = DateTime.UtcNow;
        }

        public void UpdateTimestamp()
        {
            UpdatedDate = DateTime.UtcNow;
        }
    }
}
