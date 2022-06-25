using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        public bool IsNew { get; set; }
        public bool HasChanges { get; set; }
        public bool IsValid => Validate();
        public enum EntityStateOption
        {
            Active,
            Deleted
        }
        public EntityStateOption EntityState { get; set; }

        public abstract bool Validate();        
    }
}
