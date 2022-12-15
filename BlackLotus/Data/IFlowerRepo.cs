using BlackLotus.Model;

namespace BlackLotus.Data
{
    public interface IFlowerRepo
    {
        bool Save();
        IEnumerable<Flower> GetFlowers();
        Flower GetFlowerById(int flowerId);
        void createFlower(Flower flower);

        void delete (Flower flower);

        bool update(Flower flower); 
    }
}
