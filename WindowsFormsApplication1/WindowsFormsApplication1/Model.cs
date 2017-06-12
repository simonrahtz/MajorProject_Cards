using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Model
    {
        private View view;
        private String message;
        public string Message { get { return message; } }

        public View View
        {
            set { view = value; }
        }


        internal void update(GameEvent gameEvent)
        {
            if (gameEvent is ConnectedEvent)
            {
                message = "You Got connected!";
            }

            view.UpdateModel(message);

        }

    }
}
