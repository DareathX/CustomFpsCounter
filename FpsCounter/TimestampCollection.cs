using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FpsCounter
{
        // Helper class to store frame timestamps
    public class TimestampCollection
    {

        public string Name { get; set; }

        private List<long> timestamps = new List<long>();

        //add value to the collection
        public void Add(long timestamp)
        {   
                timestamps.Add(timestamp); 
        }

        public void Clear()
        {
            timestamps.Clear();
        }

        public int QueryCount()
        {
            return timestamps.Count;
        }
    }
}
