using BlackLotus.Model;
using System;

namespace BlackLotus.Data
{
    public class FlowerRepo : IFlowerRepo
    {
        private AppDBContex context;

        public FlowerRepo(AppDBContex dBContext)
        {
            context = dBContext;
        }
        public void createFlower(Flower flower)
        {
            if (flower == null)
            {
                throw new ArgumentNullException(nameof(flower));
            }
            context.flower.Add(flower);
        }

        public void delete(Flower flower)
        {
            context.flower.Remove(flower);
            Save();
        }

        public Flower GetFlowerById(int flowerId)
        {
            return context.flower.FirstOrDefault(f => f.flowerId == flowerId);
        }

        public IEnumerable<Flower> GetFlowers()
        {
            return context.flower.ToList();
        }

        public bool Save()
        {
            int count = context.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool update(Flower flower)
        {
            context.flower.Update(flower);
            return Save();
        }
    }
}
