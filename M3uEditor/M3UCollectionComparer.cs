using System;
using System.Collections.Generic;
using System.Text;

namespace M3uEditor
{
    class M3UCollectionComparer : IEqualityComparer<Link>
    {
        public bool Equals(Link x, Link y)
        {
            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y))
                return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.Info == y.Info && x.HttpLink == y.HttpLink;
        }

        public int GetHashCode(Link link)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(link, null)) return 0;

            //Get hash code for the Name field if it is not null.
            int hashProductName = link.Info == null ? 0 : link.Info.GetHashCode();

            //Get hash code for the Code field.
            int hashProductCode = link.Info.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductName ^ hashProductCode;
        }
    }
}

