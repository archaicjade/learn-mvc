using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IServiceLocator
    {
        object GetService(Type servcieType);
    }

    public interface IMessagingService
    {
        void SendMessage();
    }

    public class NotificationSystem
    {
        public IMessagingService MessageService
        {
            get; set;
        }


        public void InterestingEventHappened()
        {
            if (MessageService == null)
            {
                throw new NullReferenceException("please set messageservice before calling");
            }

            MessageService.SendMessage();
        }
    }

    public static class ServiceLocatorExtensions
    {
        public static TService GetService<TService>(this IServiceLocator locator)
        {
            return (TService)locator.GetService(typeof(TService));
        }
    }
}
