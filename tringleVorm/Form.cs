using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tringleVorm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double a, b, c;
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Clear();
            listView1.Items.Add("side a");
            listView1.Items.Add("side b");
            listView1.Items.Add("side c");
            listView1.Items.Add("Perimetr");
            listView1.Items.Add("Square");
            listView1.Items.Add("it exist?");
            listView1.Items.Add("specifier");
            listView1.Items[0].SubItems.Add(triangle.OutputA());
            listView1.Items[1].SubItems.Add(triangle.OutputB());
            listView1.Items[2].SubItems.Add(triangle.OutputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("exist"); }
            else listView1.Items[5].SubItems.Add("not exist");
            listView1.Items[6].SubItems.Add(triangle.TriangleType);

            string imagesPath = @"C:\Users\Gigabyte\Source\Repos\tringleVorm\tringleVorm\Pildid";

            switch (triangle.TriangleType)
            {
                case "Võrdkülgne":
                    pictureBox1.Image = Image.FromFile(Path.Combine(imagesPath, "triangle1.png"));
                    break;

                case "Võrdhaarane":
                    pictureBox1.Image = Image.FromFile(Path.Combine(imagesPath, "triangle2.png"));
                    break;

                case "Mitmekülgne":
                    pictureBox1.Image = Image.FromFile(Path.Combine(imagesPath, "triangle3.png"));
                    break;

                default:

                    MessageBox.Show("triangle doesn't exist");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }
    }
}
