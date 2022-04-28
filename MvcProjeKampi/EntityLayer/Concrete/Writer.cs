using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string writerSurName { get; set; }
        [StringLength(100)]
        public string writerImage { get; set; }
        [StringLength(50)]
        public string writerSurMail { get; set; }
        [StringLength(20)]
        public string writerPassword { get; set; }

        public ICollection<Heading> Headings  { get; set; }
        public ICollection<Content> Content { get; set; }




    }
}
