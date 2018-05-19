using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CommCar
{
    public partial class OpenForm : Form, IDisposable
    {
        public OpenForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void OpenForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                timer1.Enabled = false;
                var newThread = new Thread(() =>
                {
                    var frmNewForm = new Form1();
                    Application.Run(frmNewForm);
                });
                newThread.Start();
                this.Close();
        }
    }
}
