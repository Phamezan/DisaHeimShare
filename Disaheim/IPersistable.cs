namespace Disaheim
{
    public interface IPersistable
    {
        public void Save();
       
        public void Save(string fileName);
 
        public void Load();

        public void Load(string fileName);
    }
}
