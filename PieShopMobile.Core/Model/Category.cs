using System.Collections.Generic;

namespace PieShopMobile.Core.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pie> Pies { get; set; }
    }
}