using PieShopMobile.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PieShopMobile.Core.Repository
{
    public class PieRepository
    {
        private static readonly Dictionary<string, Category> AllCategories = new Dictionary<string, Category>
        {
            { "Fruit Pies", new Category { Name = "Fruit ies"} },
            { "Cheese Cakes", new Category { Name = "Cheese cakes"} },
            { "Seasonal Pies", new Category { Name = "Seasonal pies"} }
        };

        private static readonly List<Pie> AllPies = new List<Pie>()
        {
            new Pie { Id=1 },
            new Pie { Id=2 },
            new Pie { Id=3 },
            new Pie { Id=4 },
            new Pie { Id=5 },
            new Pie { Id=6 },
            new Pie { Id=7 },
            new Pie { Id=8 },
            new Pie { Id=9 },
            new Pie { Id=10 },
            new Pie { Id=11 }
        };

        public List<Pie> GetAllPies()
        {
            return AllPies;
        }

        public List<Category> GetCategoriesWithPies()
        {
            foreach (var category in AllCategories.Values)
            {
                category.Pies = AllPies.Where(p => p.Category == category).ToList();
            }

            return AllCategories.Values.ToList();
        }

        public Pie GetPieById(int id)
        {
            return AllPies.FirstOrDefault(p => p.Id == id);
        }
    }
}
