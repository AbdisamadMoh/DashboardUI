using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard
{
    public partial class Form1 : BeautyForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnMouseDownMoveForm(object sender, MouseEventArgs e)
        {
            base.OnMouseDownMoveForm(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DataPoint _prevPoint1;
        void chart3_MouseMove(object sender, MouseEventArgs e)
        {
            // this if statement clears the values from the previously activated point.
            if (_prevPoint1 != null)
            {
                // _prevPoint.MarkerStyle = MarkerStyle.None;
                _prevPoint1.IsValueShownAsLabel = false;
            }

            var result = chart3.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                var prop = result.Object as DataPoint;
                if (prop != null)
                {
                    prop.IsValueShownAsLabel = true;
                    prop.MarkerStyle = MarkerStyle.Circle;
                    _prevPoint1 = prop;
                }
            }
        }

        DataPoint _prevPoint;
        void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            // this if statement clears the values from the previously activated point.
            if (_prevPoint !=null)
            {
               // _prevPoint.MarkerStyle = MarkerStyle.None;
                _prevPoint.IsValueShownAsLabel = false;
            }

            var result = chart1.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                var prop = result.Object as DataPoint;
                if (prop != null)
                {
                    prop.IsValueShownAsLabel = true;
                    prop.MarkerStyle = MarkerStyle.Circle;
                    _prevPoint = prop;
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void card6_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = card6.BackColor = Color.DarkBlue;
        }

        private void card6_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = card6.BackColor = Color.FromArgb(66, 66, 116);
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            
        }

        private void menu1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void menu1_OnClick(object sender, EventArgs e)
        {
        }

        private void menu1_MouseEnter(object sender, EventArgs e)
        {
            //((Menu)sender).Hover();
           
        }

        private void menu1_MouseLeave(object sender, EventArgs e)
        {
            //((Menu)sender).Dehover();
        }
    }
}
