
using Interfaces;


namespace Services
{
    public class LogicService : ILogic
    {
        
        public void DoAllLogic(IPublish publish , IContent content , ICheck check , ISave save )
        {
            
            check.CheckPublication();
            content.AddContent();
            publish.Publish();
        }
    }
}
