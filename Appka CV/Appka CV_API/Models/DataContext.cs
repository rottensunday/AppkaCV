using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Appka_CV_API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Microsoft"
                },
                new Company
                {
                    Id = 2,
                    Name = "Samsung"
                },
                new Company
                {
                    Id = 3,
                    Name = "Politechnika"
                }
            );

            modelBuilder.Entity<JobOffer>().HasData(
                new
                {
                    Id = 1,
                    JobTitle = "Praca dla programisty",
                    Description = "Superancka oferta pracy dla seniora w .net",
                    Category = "Programista",
                    Position = "Senior",
                    SalaryFrom = "15000",
                    City = "Warszawa",
                    HR = "zrl67373@bcaoo.com",
                    FileName = "22.jpg",
                    CompanyId = 1
                },
                new
                {
                    Id = 2,
                    JobTitle = "Praca dla piekarza",
                    Description = "Superancka oferta pracy dla zdolnego piekarza (bułeczki oraz chlebki)",
                    Category = "Piekarz",
                    Position = "Praktyki",
                    SalaryFrom = "2000",
                    City = "Zakopane",
                    HR = "zrl67373@bcaoo.com",
                    FileName = "22.jpg",
                    CompanyId = 3
                },
                new
                {
                    Id = 3,
                    JobTitle = "Praca dla barmana",
                    Description = "Superancka oferta pracy dla wybitnego barmana",
                    Category = "Barman",
                    Position = "Pełen etat",
                    SalaryFrom = "5000",
                    City = "Warszawa",
                    HR = "oob23573@zzrgg.com",
                    FileName = "22.jpg",
                    CompanyId = 3
                },
                new
                {
                    Id = 4,
                    JobTitle = "Praca dla developera java",
                    Description = "Nudna praca dla programisty java",
                    Category = "Programista",
                    Position = "Mid",
                    SalaryFrom = "5000",
                    City = "Warszawa",
                    HR = "oob23573@zzrgg.com",
                    FileName = "22.jpg",
                    CompanyId = 2
                }
            );

            modelBuilder.Entity<JobApplication>().HasData(
                new
                {
                    Id = 1,
                    JobOfferId = 3,
                    FirstName = "Marian",
                    LastName = "Kowalski",
                    Education = "Średnie",
                    Skills = "Umiem piec chleb i pisać dobry kod",
                    Hobbies = "Latanie i pływanie",
                    Languages = "Polski i inne też umiem",
                    Address = "Warszawa",
                    PhoneNumber = "919212517",
                    EmailAddress = "mailik@mailons.com",
                    Accepted = false,
                    User = "dmw57033@zzrgg.com",
                    FileName = "Rysunek12344.pdf"
                },
                new
                {
                    Id = 2,
                    JobOfferId = 1,
                    FirstName = "Krzysztof",
                    LastName = "Rębacz",
                    Education = "Wyższe",
                    Skills = "Umiem piec chleb i pisać dobry kod",
                    Hobbies = "Latanie i pływanie",
                    Languages = "Polski i inne też umiem",
                    Address = "Warszawa",
                    PhoneNumber = "919212517",
                    EmailAddress = "mailik@mailons.com",
                    Accepted = false,
                    User = "dmw57033@zzrgg.com",
                    FileName = "Rysunek12344.pdf"
                },
                new
                {
                    Id = 3,
                    JobOfferId = 2,
                    FirstName = "Marian",
                    LastName = "Kowalski",
                    Education = "Średnie",
                    Skills = "Umiem piec chleb i pisać dobry kod",
                    Hobbies = "Latanie i pływanie",
                    Languages = "Polski i inne też umiem",
                    Address = "Warszawa",
                    PhoneNumber = "919212517",
                    EmailAddress = "mailik@mailons.com",
                    Accepted = false,
                    User = "dmw57033@zzrgg.com",
                    FileName = "Rysunek12344.pdf"
                },
                new
                {
                    Id = 4,
                    JobOfferId = 1,
                    FirstName = "Wiesiek",
                    LastName = "Wojecki",
                    Education = "Średnie",
                    Skills = "Umiem piec chleb i pisać dobry kod",
                    Hobbies = "Latanie i pływanie",
                    Languages = "Polski i inne też umiem",
                    Address = "Warszawa",
                    PhoneNumber = "919212517",
                    EmailAddress = "mailik@mailons.com",
                    Accepted = false,
                    User = "d10052011@urhen.com",
                    FileName = "Rysunek12344.pdf"
                },
                new
                {
                    Id = 5,
                    JobOfferId = 2,
                    FirstName = "Wiesiek",
                    LastName = "Wojecki",
                    Education = "Średnie",
                    Skills = "Umiem piec chleb i pisać dobry kod",
                    Hobbies = "Latanie i pływanie",
                    Languages = "Polski i inne też umiem",
                    Address = "Warszawa",
                    PhoneNumber = "919212517",
                    EmailAddress = "mailik@mailons.com",
                    Accepted = false,
                    User = "zyw93775@bcaoo.com",
                    FileName = "Rysunek12344.pdf"
                }
            );
        }
    }
}
