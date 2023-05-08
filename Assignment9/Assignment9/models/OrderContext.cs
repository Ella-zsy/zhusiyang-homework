using Microsoft.EntityFrameworkCore;


namespace Assignment9.models
{
    public class OrderContext: DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
         : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }
        //定义有哪几种模式
        public DbSet<Order> Orders { get; set; }

        public DbSet<Goods> Goods { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
