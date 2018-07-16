using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportScanner
{
    public class Passportscan
    {
        /**
        * event delegate.
        * Declare the event using EventHandler<T>
        **/

        public event EventHandler<Events> RaiseEvents;

        /**
         * delegate method handle raise event
         **/
        protected virtual void OnRaiseEvent(Events e)
        {
            RaiseEvents?.Invoke(this, e);
        }

        Response res;
        Identity status;
        public Identity Scan()
        {
            status = new Identity();
            try
            {

            }catch(Exception exception)
            {

            }
            return status;
        }
        public Response Connect()
        {
            res = new Response();
            try
            {

            }
            catch (Exception exception)
            {

            }
            return res;
        }
        public Response Capture()
        {
            res = new Response();
            try
            {

            }
            catch (Exception exception)
            {

            }
            return res;
        }
        public Boolean Begin()
        {
            return true;
        }
    }
}
