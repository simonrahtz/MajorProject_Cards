using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;

namespace WindowsFormsApplication1
{
    public class Controller
    {
        private NetworkClient networkClient;
        private Model model;

        public Model Model
        {
            set { model = value; }
        }

        public Controller() {
            networkClient = new NetworkClient(this);

        }

        internal void Connect()
        {
            networkClient.StartClient();
        }

        internal void Connected()
        {
            model.update(new ConnectedEvent());
        }
    }
}
