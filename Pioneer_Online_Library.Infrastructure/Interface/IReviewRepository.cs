using Pioneer_Online_Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pioneer_Online_Library.Infrastructure.Interface
{
    public interface IReviewRepository
    {
        Review AddComment(Review review);
        Review AddRating(Review rating);
    }
}
