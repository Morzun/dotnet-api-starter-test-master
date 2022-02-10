using System.Collections.Generic;

using dotnet_api_test.Models.Dtos;
using dotnet_api_test.Persistence.Repositories.Interfaces;

namespace dotnet_api_test.Persistence.Repositories
{
    public class DishRepository : IDishRepository
    {
        private readonly AppDbContext _context;

        public DishRepository(AppDbContext context)
        {
            _context = context;
        }

        void IDishRepository.SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Dish> GetAllDishes()
        {
            return _context.Dishes.Select(x => x);
        }

        public dynamic? GetAverageDishPrice()
        {
            var average = _context.Dishes.Average(x => x.Cost);
            return average;
        }

        public Dish GetDishById(int Id)
        {
            return _context.Dishes.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void DeleteDishById(int Id)
        {
            var dish = GetDishById(Id);
            _context.Remove(dish);
            _context.SaveChanges();
        }

        public Dish CreateDish(Dish dish)
        {
            _context.Dishes.Add(dish);
            _context.SaveChanges();
            return dish;
        }

        public Dish UpdateDish(Dish dish)
        {
            _context.Dishes.Update(dish);
            _context.SaveChanges();
            return dish;
        }
    }
}