using BlackLotus.Model;

namespace BlackLotus.Data
{
    public interface ICatagoryRepo
    {
        bool Save();
        IEnumerable<Catagory> GetCatagory();
        Catagory GetCatagoryById(int catagoryId);
        void createCatagory(Catagory catagory);

        void delete(Catagory catagory);

        bool update(Catagory catagory);
    }
}
