using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =LAPTOP-AR4409OM; database=NetCoreProje;" +
                "Integrated Security = true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasOne(x => x.HomeTeam)
                .WithMany(y => y.HomeMatches)
                .HasForeignKey(z => z.HomeTeamID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Match>()
          .HasOne(x => x.GuestTeam)
          .WithMany(y => y.AwayMatches)
          .HasForeignKey(z => z.GuestTeamID)
          .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
             .HasOne(x => x.SenderUser)
             .WithMany(y => y.WriterSender)
             .HasForeignKey(z => z.SenderID)
             .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Message2>()
          .HasOne(x => x.ReceiverUser)
          .WithMany(y => y.WriterReceiver)
          .HasForeignKey(z => z.ReceiverID)
          .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);


            //hometmatches olan --> WriterSender
            //Awaymatches olan --> WriterReceiver
            //hometeam --> senderuser
            //guestteam --> receiveruser
        }
        public DbSet<About> abouts { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Writer> writers { get; set; }
        public DbSet<NewsLetter> newsLetters { get; set; }
        public DbSet<BlogRayting> blogRaytings { get; set; }
        public DbSet<Notification> notifications { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<Match> matches { get; set; }
        public DbSet<Message2> message2s { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
