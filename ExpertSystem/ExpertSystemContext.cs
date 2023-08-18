using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ExpertSystem {
    public partial class ExpertSystemContext : DbContext {
        public ExpertSystemContext()
            : base("name=ExpertSystemContext") {
        }

        public virtual DbSet<KnowladgeBase> knowladgeBase { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        }
    }
}
