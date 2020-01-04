﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Shaping;

namespace Dashboard
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.ClientRectangle, 5, RoundedRectangle.RectangleCorners.All);

            this.Region = new Region(path);
            base.OnPaint(e);
        }
        private void Card_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
