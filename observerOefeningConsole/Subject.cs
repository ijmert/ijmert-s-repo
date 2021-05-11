using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerOefeningConsole
{
    public abstract class Subject
    {
        protected List<Observer> Observers { get; set; }

        public delegate void ChangeEventHandler();

        public event ChangeEventHandler Change;

        
        public void Attach(Observer observer) 
        {
            Change += new ChangeEventHandler(observer.update);
        }

        public void Detach(Observer observer)
        {
            Change -= new ChangeEventHandler(observer.update);
        }
        public void Notify()
        {
            if (Change != null)
            {
                Change();
            }
        }
    }
}
