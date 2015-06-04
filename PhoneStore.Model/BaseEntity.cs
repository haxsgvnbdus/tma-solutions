using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Model
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public virtual bool IsTransient
        {
            get { return ID == 0; }
        } 
    }
}
