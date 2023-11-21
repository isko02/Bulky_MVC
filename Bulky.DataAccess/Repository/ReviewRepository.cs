﻿using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Repository
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        private ApplicationDbContext _db;

        public ReviewRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Review obj)
        {
            _db.Reviews.Update(obj);
        }
        public bool AddNewReview(Review review)
        {
            _db.Reviews.Add(review);
            return _db.SaveChanges() > 0;
        }
        //public List<Review> GetReviews(int reviewId, int shoppingCartId)
        //{
        //    return _db.Reviews.Where(x => x.ReviewId == reviewId && x.ShoppingCartId == shoppingCartId).Include(x => x.ApplicationUser).ToList();
        //}
    }
}
