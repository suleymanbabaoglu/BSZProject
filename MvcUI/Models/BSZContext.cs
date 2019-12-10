using MvcUI.Models.Entities;

namespace MvcUI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BSZContext : DbContext
    {
        public BSZContext()
            : base("name=BSZContext")
        {
        }

        public virtual DbSet<Contact> contact { get; set; }
        public virtual DbSet<Features> features { get; set; }
        public virtual DbSet<Footlinks> footlinks { get; set; }
        public virtual DbSet<Menus> menus { get; set; }
        public virtual DbSet<Products> products { get; set; }
        public virtual DbSet<Settings> settings { get; set; }
        public virtual DbSet<Sliders> sliders { get; set; }
        public virtual DbSet<Stocks> stocks { get; set; }
        public virtual DbSet<Users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.About_text)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Instagram)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Facebook)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Google_plus)
                .IsUnicode(false);

            modelBuilder.Entity<Features>()
                .Property(e => e.FeatureText)
                .IsUnicode(false);

            modelBuilder.Entity<Features>()
                .Property(e => e.FeatureImage)
                .IsUnicode(false);

            modelBuilder.Entity<Features>()
                .Property(e => e.FeatureUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Footlinks>()
                .Property(e => e.LinkText)
                .IsUnicode(false);

            modelBuilder.Entity<Footlinks>()
                .Property(e => e.LinkUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Menus>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<Menus>()
                .Property(e => e.MenuUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductBrand)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductText)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductImage1)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductImage2)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductImage3)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductImage4)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.favicon)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.copyright)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.mailsendfrom)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.mailserver)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.mailport)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.mailuser)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.mailpass)
                .IsUnicode(false);

            modelBuilder.Entity<Settings>()
                .Property(e => e.prices_isactive);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderText1)
                .IsUnicode(false);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderText2)
                .IsUnicode(false);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderInformation)
                .IsUnicode(false);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderBackground)
                .IsUnicode(false);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderLink1)
                .IsUnicode(false);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderLink2)
                .IsUnicode(false);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderLinkText1)
                .IsUnicode(false);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderLinkText2)
                .IsUnicode(false);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderCurrency)
                .IsUnicode(false);

            modelBuilder.Entity<Sliders>()
                .Property(e => e.SliderIsActive);

            modelBuilder.Entity<Stocks>()
                .Property(e => e.StockBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Stocks>()
                .Property(e => e.StockSize)
                .IsUnicode(false);
        }
    }
}
