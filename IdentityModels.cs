using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;


namespace LonghornMusic.Models
{
    // You can add profile data for the user by adding more properties to your AppUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class AppUser : IdentityUser
    {
        public string FName { get; set; }
        public string MI { get; set; }
        public string LName { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string CreditCard1 { get; set; }
        public string CreditCard2 { get; set; }
        public string CreditCard1Type { get { return getCard1Type(); } }
        public string CreditCard2Type { get { return getCard2Type(); } }
        public virtual List<SongReview> SongReviews { get; set; }
        public virtual List<AlbumReview> AlbumReviews { get; set; }
        public virtual List<ArtistReview> ArtistReviews { get; set; }
        public virtual List<Song> MusicOwned { get; set; }
        public virtual List<PurchaseUserDetail> OrderHistory { get; set; }

        public string getCard1Type()
        {
            string cardtype;
            if (this.CreditCard1 == null || this.CreditCard1.Length == 0)
            {
                return "No Card";
            }
            else
            {
                if (CreditCard1.Length == 15)
                {
                    return "AMEX";
                }
                if (CreditCard1.Length == 16 && CreditCard1[0] == 5 && CreditCard1[1] == 4)
                {
                    return "MasterCard";
                }
                if (CreditCard1.Length == 16 && CreditCard1[0] == 4)
                {
                    return "Visa";
                }
                if (CreditCard1.Length == 16 && CreditCard1[0] == 6)
                {
                    return "Discover";
                }
                else
                {
                    return "BAD CARD";
                }
            }

        }
        public string getCard2Type()
        {
            string cardtype;
            if (this.CreditCard2 == null || this.CreditCard2.Length == 0)
            {
                return "No Card";
            }
            else
            {
                if (CreditCard2.Length == 15)
                {
                    return "AMEX";
                }
                if (CreditCard2.Length == 16 && CreditCard2[0] == 5 && CreditCard2[1] == 4)
                {
                    return "MasterCard";
                }
                if (CreditCard2.Length == 16 && CreditCard2[0] == 4)
                {
                    return "Visa";
                }
                if (CreditCard2.Length == 16 && CreditCard2[0] == 6)
                {
                    return "Discover";
                }
                else
                {
                    return "BAD CARD";
                }
            }

        }

        public AppUser()
        {
            this.SongReviews = new List<Models.SongReview>();
            this.AlbumReviews = new List<Models.AlbumReview>();
            this.ArtistReviews = new List<Models.ArtistReview>();
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

    public class AppDbContext : IdentityDbContext<AppUser>
    {
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