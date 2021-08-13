
using Interfaces;


namespace Services
{
    public class PublishService : IPublish
    {
        private string[] _publication;
        
        public PublishService(ISave save )
        {
            _publication = save.Pub();
        }
        public void Publish()
        {
            
            
        }


    }
}
