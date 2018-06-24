using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Models;

namespace back_end
{
    public class QuizContext : DbContext 
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) { }
        
           public DbSet <Models.Question> Questions { get; set; }
        
           public DbSet<back_end.Models.Quiz> Quiz { get; set; }
      

    }
}
