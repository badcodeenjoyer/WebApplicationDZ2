using System;

using System.Linq;

using Interfaces;


namespace Services
{
   public class CheckService : ICheck 
    {
        private string[] _publication;
        public CheckService(ISave save)
        {
            _publication = save.Pub();
        }

        public string CheckPublication()
        {
            if (_publication.Contains(" new publication with content"))
            {
                
                return "Checked , all ok";
            }
            else
            {
                return "Checked , not ok";
            }
        }
    }
}
