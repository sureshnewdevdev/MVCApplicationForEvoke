using Microsoft.AspNetCore.Mvc;
using MVCApplicationForEvoke.Models;

namespace MVCApplicationForEvoke.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            #region model example
            ProductModel productModel = new ProductModel();

            productModel.Id = 10;
            productModel.ProductName = "Apple";
            productModel.Price = 120;
            #endregion

            Person p = new Person();

            Man man = new Man()
            {
                Id = "1",
                Name = "Raja",
                PlayingGames = "Cricket"
            };
            Woman woman = new Woman()
            {
                Id = "2",
                Name = "Rajee",
                Dancing = "Indian Dance"
            };

            p = man;

            Man? convObj = p as Man;
             
            string result = DisplayDetails(man);

            return View(productModel);
        }

        /// <summary>
        /// This function will display the object deials
        /// Ex: Person p -new Peron();
        /// Man m=new Man
        /// </summary>
        /// <param name="p">This person type data</param>
        /// <returns>Welcome the  object name</returns>
        private string DisplayDetails(Person p)
        {
            string result = "Welcome ";

            if (p is Man)
            {
                result = result + "Mr " + p.Name;
            }
            if (p is Woman)
            {
                result = result + "Ms " + p.Name;
            }

            return result;
        }
    }
}
