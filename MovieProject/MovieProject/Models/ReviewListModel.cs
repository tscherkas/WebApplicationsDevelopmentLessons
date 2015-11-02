using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieProject.Models
{
    public class ReviewListModel
    {
        public ReviewListModel()
        {
            Reviews = new List<ReviewModel>();
        }
        public ICollection<ReviewModel> Reviews { get; }
    }
}