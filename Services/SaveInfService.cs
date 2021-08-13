
using Interfaces;

namespace Services
{
    public class SaveInfService : ISave
    {
        
        public string[] _publication = { "" };

        public string[] Pub(string[] vs)
        {
            _publication = vs;
            return _publication;
        }
        public string[] Pub()
        {
            return _publication;
        }
        
    }
}
