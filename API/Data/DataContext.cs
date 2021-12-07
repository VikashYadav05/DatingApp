using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
       
    } 
   public  DbSet<AppUser> Users { get; set; }
}
