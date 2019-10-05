using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        public Color IndicatorColor
        {
            get
            {
                return Indicator.BackColor;
            }
            set
            {
                Indicator.BackColor = value;
            }
        }
        public Image MenuImage
        {
            get
            {
               return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public bool isSelected
        {
            get
            {
                
               return Indicator.Visible;
                
            }
            set
            {
                Indicator.Visible = value;
                SetIndicator();
            }
        }
        bool _isSelected = false;
       private void SetIndicator()
        {
            if (isSelected)
            {
                this.Padding = new Padding(0, 0, 0, 0);
                _isSelected = true;
            }
            else
            {
                this.Padding = new Padding(1, 0, 1, 0);
                _isSelected = false;
            }
        }
        bool _canHover = true;
        public bool CanHover
        {
            get
            {
                return _canHover;
            }
            set
            {
                _canHover = value;
            }
        }

        bool isIndicatorAdded = false;
        Label Indicator = new Label();
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!isIndicatorAdded)
            {
                Indicator.Dock = DockStyle.Left;
                Indicator.Tag = IndicatorColor;
                Indicator.Width = 2;
                this.Controls.Add(Indicator);
                isIndicatorAdded = true;
            }
            base.OnPaint(e);
        }


        public delegate void Clicked(object sender, EventArgs e);
        public  event  Clicked OnClick;

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnClick?.Invoke(pictureBox1, EventArgs.Empty);
            
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            OnClick?.Invoke(pictureBox1, EventArgs.Empty);
        }

        public void Hover()
        {
            if (!_isSelected && _canHover)
            {
                this.Padding = new Padding(0, 0, 0, 0);
                Indicator.Visible = true;
            }
        }
        public void Dehover()
        {
            if (!_isSelected && _canHover)
            {
                this.Padding = new Padding(1, 0, 1, 0);
                Indicator.Visible = false;
            }
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            Hover();
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            Dehover();
        }
    }
}
