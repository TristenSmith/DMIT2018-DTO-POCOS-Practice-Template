<Query Kind="Expression">
  <Connection>
    <ID>52a5c267-0d18-4535-9dc3-23fe5e23657e</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

from item in Categories
select new 
{
	Category = item.Description,
	Products = from data in item.Products
			   select new 
			   {
				   Description = data.Description,
				   Price = data.Price
			   }
}


		   