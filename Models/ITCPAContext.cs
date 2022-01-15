/*
 * ITCPAContext.cs
 * ITCPA Project
 * 
 *  Revision History
 *      Jeonghwan Ju, 2022.01.14: Created
 */
using Microsoft.EntityFrameworkCore;

namespace ITCPAApi.Models
{
    public class ITCPAContext : DbContext
    {
        public ITCPAContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
    }
}
