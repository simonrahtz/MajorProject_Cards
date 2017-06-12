using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class View : Form
    {
        private Controller controller;
        private Model model;
        private List<String> commands = new List<string>();

        public Model Model
        {
            set { model = value; }
        }

        public Controller Controller
        {
            set { controller = value; }
        }

        public View()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Invalidate();
            GetModelUpdate();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            // tell controller to connect to server
            controller.Connect();
        }

        public void UpdateModel(String info)
        {
            lock (commands)
            {
                commands.Add(info);
            }
        }

        public void GetModelUpdate() {
            lock (commands) {
                foreach (String s in commands) {
                    label1.Text = model.Message;
                }
                commands.Clear();
            }
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

    }
}
