using Taste.DataAccess.Data.Repository.IRepository;

namespace Taste.DataAccess.Data.Repository
{
    public class UniteOfWrok : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UniteOfWrok(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(db);
            FoodType = new FoodTypeRepository(db);
            MenuItem = new MenuItemRepository(db);

        }

        public ICategoryRepository Category { get; private set; }
        public IFoodType FoodType { get; private set; }
        public IMenuItem MenuItem { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
