using KomodoCafe.Models;

namespace KomodoCafe.Repositories
{
    public class MenuRepository
    {
        private readonly List<MenuItem> _menuItems = new List<MenuItem>();

        public void AddMenuItem(MenuItem item)
        {
            _menuItems.Add(item);
        }

        public bool UpdateMenuItem(int mealNumber, MenuItem newItem)
        {
            var oldItem = _menuItems.FirstOrDefault(m => m.MealNumber == mealNumber);
            if (oldItem != null)
            {
                oldItem.MealName = newItem.MealName;
                oldItem.Description = newItem.Description;
                oldItem.Ingredients = newItem.Ingredients;
                oldItem.Price = newItem.Price;
                return true;
            }
            return false;
        }

        public bool DeleteMenuItem(int mealNumber)
        {
            var item = _menuItems.FirstOrDefault(m => m.MealNumber == mealNumber);
            if (item != null)
            {
                _menuItems.Remove(item);
                return true;
            }
            return false;
        }

        public List<MenuItem> GetAllMenuItems()
        {
            return _menuItems;
        }
    }
}
