using System;

namespace Data.Objects
{
    public class HasId:IHasId
    {
        private Guid _id;

        public Guid Id
        {
            get
            {
                if (_id == Guid.Empty || _id == null)
                {
                    _id = Guid.NewGuid();
                }
                return _id;
            }
            set { _id = value; }
        }
    }
}