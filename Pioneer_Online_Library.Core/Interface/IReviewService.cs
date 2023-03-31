using Pioneer_Online_Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pioneer_Online_Library.Core.Interface
{
    public interface IReviewService
    {
        Review AddComments(Review review);
        Review AddRatings(Review rating);
    }
}
