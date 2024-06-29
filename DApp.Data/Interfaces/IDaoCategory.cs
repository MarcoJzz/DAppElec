
using DApp.Data.Entities;

namespace DApp.Data.Interfaces
{
    public interface IDaoCategory
    {
        List<Category> GetCategories();

        Category GetCategory(int id);

        void SaveCategory(Category category);

        void UpdateCategory(Category category);

        void RemoveCategory(Category category);
    }
}
 