using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

//TODO: Change the namespace here to match your project's name
namespace LonghornMusic.Models
{
    // You can add profile data for the user by adding more properties to your AppUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class AppUser : IdentityUser
    {
        //TODO: Make sure all necessary fields are here 
        public string FName { get; set; }
        public string LName { get; set; }
        //TODO: Make sure these are in the right place
        //TODO: Make changes to controller to accomodate PurchaseUserDetail nav property 
        public string Zip { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public List<string> CreditCards { get; set; } 
        public virtual List<Review> CustomerReviews { get; set; }
        public virtual List<Song> MusicOwned { get; set; }
        public virtual List<PurchaseUserDetail> OrderHistory { get; set; }

        public AppUser()
        {
            this.CustomerReviews = new List<Models.Review>();
            this.MusicOwned = new List<Models.Song>();
            this.OrderHistory = new List<Models.PurchaseUserDetail>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    //NOTE: Here is your dbContext for the entire project.  There should only be ONE DbContext per project
    //Your dbContext (AppDbContext) inherits from IdentityDbContext, which inherits from the "regular" DbContext
    //TODO: If you have an existing dbContext (it may be in your DAL folder), DELETE THE EXISTING dbContext

    public class AppDbContext : IdentityDbContext<AppUser>
    {
        //TODO: Add your dbSets here.  As an example, I've included one for products
        //Remember - the IdentityDbContext already contains a db set for Users.  If you add another one, your code will break
        //public DbSet<Product> Products { get; set; }
                
        public AppDbContext()
            : base("MyDbConnection", throwIfV1Schema: false)
        {
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
        
        //TODO: Make sure all DbSets are here 
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistReview> ArtistReviews { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongReview> SongReviews { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumReview> AlbumReviews { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<ItemDetail> ItemDetails { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PurchaseUserDetail> PurchaseUserDetails { get; set; }
    }
}
