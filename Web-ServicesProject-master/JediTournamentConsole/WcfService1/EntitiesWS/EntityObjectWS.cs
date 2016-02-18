using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.EntitiesWS
{
    [DataContract]
    public abstract class EntityObjectWS
    {
            private int id;

            public EntityObjectWS(int id)
            {
                this.id = id;
            }

            public int Id
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }


            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
          
    }
}