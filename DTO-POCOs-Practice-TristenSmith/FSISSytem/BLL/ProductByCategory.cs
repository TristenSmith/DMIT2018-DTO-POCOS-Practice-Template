




//This is an example









//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FSISSytem.BLL
//{
//    [DataObject]
//    public class ProductByCategory
//    {
//        [DataObjectMethod(DataObjectMethodType.Select)]
//        public List<namegohere> methodnamehere()
//        {
//            using (var context = new context())
//            {
//                var results = from item in context.Categories
//                              select new nameofDTO
//                              {
//                                  Category = item.Description,
//                                  Products = from data in item.Products
//                                                 select new nameofPOCO
//                                                 {
//                                                     Description = data.Description,
//                                                     Price = data.Price
//                                                 }
//                              };
//                return results.ToList();
//            }
//        }
//}
