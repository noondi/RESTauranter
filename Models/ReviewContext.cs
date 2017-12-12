using Microsoft.EntityFrameworkCore;
using restauranter.Models;

namespace restauranter.Models
{
    public class ReviewContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public ReviewContext(DbContextOptions<ReviewContext> options) : base(options) { }

        // This DbSet contains "Review" objects and is called "reviews"
        // Review table name in app, reviews table name in database
        public DbSet<Review> reviews {get; set; }
    }
}