namespace Items.Persistance
{
    public class DbInitializer
    {
        public static void Initialize(ShopDbContext context) {
            context.Database.EnsureCreated();
        }
    }
}
