
using Interfaces;


namespace Services
{
    public class ContentService : IContent
    {

        public string[] _publication;
        public ContentService(ISave save)
        {
            _publication = save.Pub();
            AddContent();
            save.Pub(_publication);
        }

        public string[] content = { " new publication with content" };
        public void AddContent()
        {

            string[] con = content;
            var Contented = new string[_publication.Length + con.Length];
            _publication.CopyTo(Contented, 0);
            con.CopyTo(Contented, _publication.Length);
            
            _publication = Contented;
            
           
        }

    }
}
