﻿using Entities;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;


namespace DbConsole
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=pharmadb;Trusted_Connection=True;", b => b.MigrationsAssembly("Infrastructure"));
            return new AppDbContext(optionBuilder.Options);
        }
    }
    class Program
    {
        private static readonly AppDbContext _appContext;
        private static ICardRepository _cardRepository;
        private static ICouponRepository _couponRepository;

        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _cardRepository = new CardRepository(_appContext);
            _couponRepository = new CouponRepository(_appContext);
        }
        static void Main(string[] args)
        {

            ///* Card card = new Card("2", "2", "2", "2", "2", "2");
            ///_cardRepository.Add(card);
            ///_cardRepository.Remove(card);
            ///Coupon coupon = new Coupon("1", "1", "1", 1);
            ///_couponRepository.Add(coupon);
            ///_couponRepository.Remove(coupon);
        }
    }
}