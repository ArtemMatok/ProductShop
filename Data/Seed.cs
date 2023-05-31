using ProductShop.Models;
using System.Diagnostics;
using System.Net;

namespace ProductShop.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name="Горіхово-карамельний Торт",
                            Description="Для людей-бурундуків😂, які люблять горіхи всюди, завжди й багато😝🎉 Горіхові бісквіти, насичені мигдальним сиропом, карамельний крем, солона карамель і 4 види горіхів грубого помолу: кеш'ю, фундук, мигдаль і волоський горіх. Обожнюємо цей торт самі😻",
                            Price=100,
                            Image="https://images.squarespace-cdn.com/content/v1/56b25779e32140ec4133a635/1615293629102-SPPMKW7XFBO2Y78C2N71/01-IMG_0045.JPG?format=1500w"
                        },
                        new Product()
                        {
                            Name="Сирний торт на шоколадному бісквіті",
                            Description="Соковитий, дуже шоколадний корж, крем на основі кремчіза та вершків. Шоколадний торт для будь-якого віку..\r\n\r\n+ Горіхи 50 грн/кг торта\r\n\r\n+ Фрукти, сухофрукти 0 грн",
                            Price=150,
                            Image="https://images.squarespace-cdn.com/content/v1/56b25779e32140ec4133a635/1615293629063-6MZC0M70FQSWUGZIFG0W/03-IMG_0166.JPG?format=1500w"
                        },

                        new Product()
                        {
                            Name="Справжній шоколадний",
                            Description="Цей торт для сильних печінкою. Його шоколадність зашкалює. Мокрі шоколадні коржі і крем на основі 70% бельгійського шоколаду. І так - це класичне поєднання не залишить байдужим жодного шокоголіка 🍫🍫",
                            Price=350,
                            Image="https://images.squarespace-cdn.com/content/v1/56b25779e32140ec4133a635/1615293629781-VZ5HNSCQAEJMKXJUPM22/04-IMG_0041.JPG?format=1500w"
                        }
                    }) ;
                   
                 
                    context.SaveChanges();
                }
                
                }
            }
        }
    }

