using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn_Micro;
using Caliburn.Micro;

namespace Caliburn_Micro
{
  public  class AppViewModel: PropertyChangedBase
    {
        private int _message=10;
        public int Message
        {
            get { return _message; }
            set { _message = value;
                NotifyOfPropertyChange(() => Message);
                NotifyOfPropertyChange(()=>CanChangeMessage);
            }
        }
        public bool CanChangeMessage
        {
            get { return _pressCount < 100; }
        }
        private int _pressCount;
        public AppViewModel()
        {
            //Message = "Hello user";
            _pressCount = 10;
        }
        public void ChangeMessage(int delta)
        {
            _pressCount+= delta;
            Message =  _pressCount;
        }
    }
}
