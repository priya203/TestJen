using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET4._7
{
    class Program
    {
        public class ResourceLite
        {
            public string ResourceId { get; set; }
            public string ResourceName { get; set; }
        }
        public class ProductA
        {
            public string Name { get; set; }
            public int Code { get; set; }
        }

        public class ResourceLiteComparer : IEqualityComparer<ResourceLite>
        {

            public bool Equals(ResourceLite x, ResourceLite y)
            {
                //Check whether the objects are the same object. 
                if (Object.ReferenceEquals(x, y)) return true;

                //Check whether the products' properties are equal. 
                return x != null && y != null && x.ResourceId.Equals(y.ResourceId);
            }

            public int GetHashCode(ResourceLite obj)
            {
                //Get hash code for the Name field if it is not null. 
                int hashResourceId = obj.ResourceId == null ? 0 : obj.ResourceId.GetHashCode();
                return hashResourceId;
            }
        }

        static void Main(string[] args)
        {

            var code = "BBBII";

            var b = new ResourceLite() { ResourceId = "30-02" , ResourceName = "ABC"};
            var b2 = new ResourceLite() { ResourceId = "30-03", ResourceName = "dd" };
            var b3 = new ResourceLite() { ResourceId = "30-04", ResourceName = "rr" };

            var bList = new List<ResourceLite>();
            bList.Add(b);
            bList.Add(b2);
            bList.Add(b3);

            var i1 = new ResourceLite() { ResourceId = "30-02" };
            var i2 = new ResourceLite() { ResourceId = "30-03" };
       

            var iList = new List<ResourceLite>();
            iList.Add(i1);
            iList.Add(i2);

            //var newData = bList.Select(i => i.ResourceId.ToString()).Intersect(iList.Select(r => r.ResourceId.ToString())).ToList();
            //bList.RemoveAll(r => iList.Any(t => t.ResourceId != r.ResourceId));

            var newData = bList.Intersect(iList, new ResourceLiteComparer());
             bList = newData.ToList<ResourceLite>();
        }
    }
}
