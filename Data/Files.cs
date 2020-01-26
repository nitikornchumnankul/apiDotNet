using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data
{
    public class File
    {
        public long Id { get; set; }
        public String filename { get; set; }
        public String detail { get; set; }
  //     public DateTime date { get; set; }
        public long size { get; set; }
  //      public int version { get; set; }
        public String v_location { get; set; }
        public String uploader { get; set; }

    }
}
