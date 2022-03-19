using API_example.Data.Models;
using API_example.Data.Enums;

namespace API_example.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if(context != null && !context.Algorithms.Any())
                {
                    context.Algorithms.AddRange(
                    new Algorithms()
                    {
                        Name = "Bubble sort",
                        Description = "This is a sorting algorithm",
                        AlgorithmNickname = "bubble",
                        Type = AlgorithmType.Sorting,
                        CreationDate = DateTime.Now,
                        Url = "https://www.youtube.com/watch?v=Jdtq5uKz-w4"
                    });
                }
            }
        }
    }
}
