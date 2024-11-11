using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tringleVorm
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Run_button2_Click(object sender, EventArgs e)
        {
            double AngleA, AngleB;
            AngleA = Convert.ToDouble(angA.Text);
            AngleB = Convert.ToDouble(angB.Text);
            Triangle2 triangle = new Triangle2(AngleA, AngleB);
            listView2.Items.Clear();
            listView2.Items.Add("AngleA");
            listView2.Items.Add("AngleB");
            listView2.Items.Add("AngleC");
            listView2.Items.Add("Type");
            listView2.Items[0].SubItems.Add(triangle.AngleA.ToString());
            listView2.Items[1].SubItems.Add(triangle.AngleB.ToString());
            listView2.Items[2].SubItems.Add(triangle.AngleC.ToString());
            listView2.Items[3].SubItems.Add(triangle.TriangleType2);
            string imagesPath = @"C:\Users\Gigabyte\Source\Repos\tringleVorm\tringleVorm\Pildid";

            switch (triangle.TriangleType2)
            {
                case "terav":
                    pictureBox2.Image = Image.FromFile(Path.Combine(imagesPath, "angle1.png"));
                    break;

                case "täisnurkne":
                    pictureBox2.Image = Image.FromFile(Path.Combine(imagesPath, "angle2.png"));
                    break;

                case "nüri":
                    pictureBox2.Image = Image.FromFile(Path.Combine(imagesPath, "angle3.png"));
                    break;

                default:

                    MessageBox.Show("triangle doesn't exist");
                    break;
            }
        }
    }
}
