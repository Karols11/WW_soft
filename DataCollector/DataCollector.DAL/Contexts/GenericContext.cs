using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

namespace DataCollector.DAL.Contexts
{
    public class GenericContext<T> : DbContext where T : class
    {
        protected DbSet<T> _dbSet { get; set; }
        public GenericContext() : base(ConfigurationManager.ConnectionStrings["GlobalConfigurationDb"].ConnectionString)
        {
            _dbSet = this.Set<T>();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T>();
            base.OnModelCreating(modelBuilder);
        }

        public bool Add(T item)
        {
            _dbSet.Add(item);
            this.SaveChanges();
            return true;
        }

        public T GetItemById(int id)
        {
            return _dbSet.Find(id); // works somehow but probably can be optimized f.e. _dbSet.where(p => p.Id.equals(id)).singleorDefault(), but p needs to have Id.
            
        }


    }
}
