using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pioneer_Online_Library.Domain.Model
{
    public class Image
    {
        public int ImageId { get; set; }
        public string PublicId { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;

      
    }
}
