using BlazingPizza8.Model;

namespace BlazingPizza8.Data
{
    public class PizzaService
    {

        public OurPizza[] GetPizza() {
            OurPizza[] OurPizzaArr = new OurPizza[]
            {
                new OurPizza { PizzaId = 1, Name = "Margherita", Descrirption = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil", Price = 9.99m, Vegetarian = true, Vegan = false },
                new OurPizza { PizzaId = 2, Name = "Pepperoni", Descrirption = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil", Price = 9.99m, Vegetarian = false, Vegan = false },
                new OurPizza { PizzaId = 3, Name = "Hawaiian", Descrirption = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil", Price = 9.99m, Vegetarian = false, Vegan = false },
                new OurPizza { PizzaId = 4, Name = "Meat Lovers", Descrirption = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil", Price = 9.99m, Vegetarian = false, Vegan = false },
                new OurPizza { PizzaId = 5, Name = "Vegetarian", Descrirption = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil", Price = 9.99m, Vegetarian = true, Vegan = false },
                new OurPizza { PizzaId = 6, Name = "Vegan", Descrirption = "The classic. San Marzano tomatoes, fresh mozzarella, basil, olive oil", Price = 9.99m, Vegetarian = true, Vegan = true },
            };

            return  OurPizzaArr;
        }
    }
}
