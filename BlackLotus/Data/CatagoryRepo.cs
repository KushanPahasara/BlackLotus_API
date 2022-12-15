using BlackLotus.Model;

namespace BlackLotus.Data
{
    public class CatagoryRepo : ICatagoryRepo
    {
        private AppDBContex contex;

        public CatagoryRepo(AppDBContex dBContext)
        {
            contex = dBContext;
        }
        public void createCatagory(Catagory catagory)
        {
            if (catagory == null)
            {
                throw new ArgumentNullException(nameof(catagory));
            }
            contex.catagory.Add(catagory);
        }

        public void delete(Catagory catagory)
        {
            contex.catagory.Remove(catagory);
            Save();
        }

        public IEnumerable<Catagory> GetCatagory()
        {
            return contex.catagory.ToList();
        }

        public Catagory GetCatagoryById(int catagoryId)
        {
            return contex.catagory.FirstOrDefault(c => c.catagoryId == catagoryId);
        }

        public bool Save()
        {
            int count = contex.SaveChanges();
            if(count > 0)
                return true;
            else
                return false;
        }

        public bool update(Catagory catagory)
        {
            contex.catagory.Update(catagory);
            return Save();

        }
    }
}
