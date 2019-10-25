namespace WebServerHotel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelContext : DbContext
    {
        public HotelContext()
            : base("name=HotelContext")
        {
            base.Configuration.ProxyCreationEnabled = false;

        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Guests> Guests { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Room> Room { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guests>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Guests)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hotel>()
                .HasMany(e => e.Room)
                .WithRequired(e => e.Hotel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => new { e.RoomNo, e.HotelNo })
                .WillCascadeOnDelete(false);
        }
    }
}
