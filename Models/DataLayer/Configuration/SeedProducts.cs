using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace bellusBibliotheca2.Models
{
    internal class SeedProducts : IEntityTypeConfiguration<SkincareItem>
    {
        public void Configure(EntityTypeBuilder<SkincareItem> entity)
        {
            entity.HasData(
            new SkincareItem
            {
                Brand = "avant",
                Serial = 542977,
                Name = "blue volcanic stone purifying and antioxidising cleansing gel",
                Category = "face cleanser",
                Price = 110,
                ExpirationDate = DateTime.Parse("2017-02-01")
            });

            new SkincareItem
            {
                Brand = "gloss moderne",
                Serial = 003654,
                Name = "clean luxury hair masque",
                Category = "hair treatment",
                Price = 45,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "ahava",
                Serial = 163700,
                Name = "clearing facial mask",
                Category = "face cleanser",
                Price = 30,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "v cosmetics",
                Serial = 002502,
                Name = "high def under eye color corrector",
                Category = "makeup",
                Price = 43,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };
            new SkincareItem
            {
                Brand = "kate somerville",
                Serial = 015210,
                Name = "exfolikate cleanser",
                Category = "face cleanser",
                Price = 31,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };
            new SkincareItem
            {
                Brand = "il makiage",
                Serial = 289022,
                Name = "high volume and intense curl mascara",
                Category = "mascara",
                Price = 27,
            };

            new SkincareItem
            {
                Brand = "shaina b",
                Serial = 099458,
                Name = "eyeshadow duo b. free",
                Category = "eyeshadow",
                Price = 23,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "farah",
                Serial = 101001,
                Name = "18hr liquid eyeliner",
                Category = "eyeliner",
                Price = 18,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "beauty vaulte",
                Serial = 439085,
                Name = "mascara",
                Category = "mascara",
                Price = 18,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "maybelline",
                Serial = 394849,
                Name = "great lash",
                Category = "mascara",
                Price = 9,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "NYX",
                Serial = 867662,
                Name = "that's the point hella fine",
                Category = "eyeliner",
                Price = 11,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };
            new SkincareItem
            {
                Brand = "hipdot",
                Serial = 092401,
                Name = "double mingle liner and shadow",
                Category = "eyeliner",
                Price = 18,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };
            new SkincareItem
            {
                Brand = "rachel couture",
                Serial = 458549,
                Name = "translucent power",
                Category = "makeup",
                Price = 14,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "beauty for certain",
                Serial = 011084,
                Name = "persimmon eyeliner pencil",
                Category = "eyeliner",
                Price = 20,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "it cosmetics",
                Serial = 592321,
                Name = "persimmon eyeliner pencil",
                Category = "eyeliner",
                Price = 20,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };
            new SkincareItem
            {
                Brand = "ren clean skincare",
                Serial = 701745,
                Name = "clean jelly and oil cleanser",
                Category = "face cleanser",
                Price = 37,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "mischo beauty",
                Serial = 200901,
                Name = "single blush",
                Category = "makeup",
                Price = 30,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "beauty for certain",
                Serial = 146624,
                Name = "#17 deluxe lipstick",
                Category = "makeup",
                Price = 18,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };

            new SkincareItem
            {
                Brand = "ciate london",
                Serial = 736356,
                Name = "matchmaker skin brightening blush",
                Category = "makeup",
                Price = 26,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };
            new SkincareItem
            {
                Brand = "trust fund beauty",
                Serial = 875459,
                Name = "nail laquer ride or die",
                Category = "nails",
                Price = 15,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };
            new SkincareItem
            {
                Brand = "the nue co",
                Serial = 363110,
                Name = "barrier culture moisturizer",
                Category = "moisturizer",
                Price = 65,
                ExpirationDate = DateTime.Parse("2017-02-01")
            };
        }
       
    }
    
}
