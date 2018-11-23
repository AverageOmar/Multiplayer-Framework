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
            GameChat.Enabled = false;
            FocusOnMe.Focus();
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
            int XPosition = e.X;
            int YPosition = e.Y;

            int fXPosition = ((XPosition / 3) + 600) + this.Location.X - CursorImage.Size.Width;
            int fYPosition = (YPosition / 3) + this.Location.Y + CursorImage.Size.Height;

            CursorImage.Location = this.PointToClient(new Point((int)fXPosition, (int)fYPosition));
        }

        private void CursorImage_MouseMove(object sender, MouseEventArgs e)
        {
            CursorImage.Location = this.PointToClient(Cursor.Position);
        }
    }
}
