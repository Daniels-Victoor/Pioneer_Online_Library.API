using Pioneer_Online_Library.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pioneer_Online_Library.Domain.Model
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Comment { get; set; } = string.Empty;
        [MaxLength(5)]
        public RatingsEnum Rate { get; set; }


        public string UserId { get; set; } = null!;
        public virtual AppUser User { get; set; } = null!;
    }
}
