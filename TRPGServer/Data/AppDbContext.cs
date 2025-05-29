using Microsoft.EntityFrameworkCore;
using TRPGServer.Entity;
using TRPGServer.Entity.Character;
using TRPGServer.Entity.Class;
using TRPGServer.Entity.RoomObject;
using TRPGServer.Entity.RoomObject.ActiveCharacter;
using TRPGServer.Entity.RoomObject.PlaySet;
using TRPGServer.Entity.RoomObject.RoomSet;

namespace TRPGServer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>(entity =>
            {
                // Set Content as MEDIUMTEXT in MySQL
                entity.Property(b => b.ImageBase64)
                      .HasColumnType("MEDIUMTEXT");
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies();
        }




        //public DbSet<Product> Products { get; set; }
        public DbSet<GameType> GameType { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Account> Account { get; set; }
        public IQueryable<Account> _Account { get => Account.Where(a => a.DeletedDate == null); }
        public DbSet<Room> Room { get; set; }
        public DbSet<Story> Story { get; set; }
        public DbSet<CharacterBase> CharacterBase { get; set; }
        public DbSet<CharacterItems> CharacterItems { get; set; }
        public DbSet<CharacterStatus> CharacterStatus { get; set; }
        public DbSet<ClassBase> ClassBase { get; set; }
        public DbSet<ClassItems> ClassItems { get; set; }
        public DbSet<ClassStatus> ClassStatus { get; set; }
        public DbSet<RoomCharacter> RoomCharacter { get; set; }
        public DbSet<RoomCharacterItem> RoomCharacterItem { get; set; }
        public DbSet<RoomCharacterStatus> RoomCharacterStatus { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<RoomActor> RoomActor { get; set; }
        public DbSet<RoomChat> RoomChat { get; set; }
        public DbSet<RoomLog> RoomLog { get; set; }
        public DbSet<Dice> Dice { get; set; }
        public DbSet<RoomRule> RoomRule { get; set; }
        public DbSet<RoomTemplate> RoomTemplate { get; set; }
        public DbSet<TemplateDetail> TemplateDetail { get; set; }
    }

}
