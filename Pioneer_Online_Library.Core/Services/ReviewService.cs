using Pioneer_Online_Library.Core.Interface;
using Pioneer_Online_Library.Domain.Model;
using Pioneer_Online_Library.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pioneer_Online_Library.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _review;
        public ReviewService(IReviewRepository review)
        {
            _review = review;
        }
        public Review AddComments(Review review)
        {
            return _review.AddComment(review);
        }

        public Review AddRatings(Review rating)
        {
            return _review.AddRating(rating);
        }
    }
}
