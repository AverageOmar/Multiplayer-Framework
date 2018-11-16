using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleClientCS
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void NickName_Enter(object sender, EventArgs e)
        {
            if(NickName.Text == "Enter Nickname")
            {
                NickName.Text = "";
            }
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            int mousePositionX = System.Windows.Forms.Cursor.Position.X;
            int mousePositionY = System.Windows.Forms.Cursor.Position.Y;
        }
    }
}
