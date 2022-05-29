using System;

namespace Taste.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IFoodType FoodType { get; }
        IMenuItem MenuItem { get; }
        void Save();
    }
}
