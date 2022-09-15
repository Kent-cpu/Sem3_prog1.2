using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool baseCheckData()
        {

            if (xKoordinate.Text == "" || yKoordinate.Text == "" || price.Text == "")
            {
                MessageBox.Show("Пустые поля");
                return true;
            }
            double prc = 0;
            if (!double.TryParse(xKoordinate.Text, out double x) && !double.TryParse(yKoordinate.Text, out double y)
                && !double.TryParse(price.Text, out prc))
            {
                MessageBox.Show("Некорректные данные");
                return true;
            }


            if (double.Parse(price.Text) <= 0 || double.Parse(speed.Text) <= 0)
            {
                MessageBox.Show("Так и знал, не надо вводить отрицательные значения");
                return true;
            }


            return false;
        }

        //  double.Parse(high.Text) <= 0 || double.Parse(numberPassengers.Text) <= 0 ||

        private bool checkDataForPlane()
        {
            if (high.Text == "" || numberPassengers.Text == "")
            {
                MessageBox.Show("Пустые поля");
                return true;
            }

            if (!double.TryParse(high.Text, out double hg) && !double.TryParse(numberPassengers.Text, out double numPassengers))
            {
                MessageBox.Show("Некорректные данные");
                return true;
            }

            if (double.Parse(high.Text) <= 0 || double.Parse(numberPassengers.Text) <= 0)
            {
                MessageBox.Show("Так и знал, не надо вводить отрицательные значения");
                return true;
            }


            return false;
        }
        private bool checkDataForShip()
        {
            if (portTxt.Text == "" || numberPassengers.Text == "")
            {
                MessageBox.Show("Пустые поля");
                return true;
            }

            if (!double.TryParse(numberPassengers.Text, out double numPassengers))
            {
                MessageBox.Show("Некорректные данные");
                return true;
            }

            if (double.Parse(numberPassengers.Text) <= 0)
            {
                MessageBox.Show("Так и знал, не надо вводить отрицательные значения");
                return true;
            }


            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!baseCheckData())
            {
                double xKoord = double.Parse(xKoordinate.Text);
                double yKoord = double.Parse(yKoordinate.Text);
                double prc = double.Parse(price.Text);
                Car car = new Car(xKoord, yKoord, prc, dateTimePicker1.Value.ToShortDateString());


                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["xColumn"].Value = car.xKoordinate.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["yColumn"].Value = car.yKoordinate.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["priceColumn"].Value = car.price.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["yearReleaseColumn"].Value = car.yearRelease;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["numberPassengersColumn"].Value = "-";
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["highColumn"].Value = "-";
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!baseCheckData() && !checkDataForPlane())
            {
                double xKoord = double.Parse(xKoordinate.Text);
                double yKoord = double.Parse(yKoordinate.Text);
                double prc = double.Parse(price.Text);
                double hg = double.Parse(high.Text);
                int numPassengers = int.Parse(numberPassengers.Text);
                Plane plane = new Plane(xKoord, yKoord, prc, dateTimePicker1.Value.ToShortDateString(), hg, numPassengers);

                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["xColumn"].Value = plane.xKoordinate.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["yColumn"].Value = plane.yKoordinate.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["priceColumn"].Value = plane.price.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["yearReleaseColumn"].Value = plane.yearRelease;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["numberPassengersColumn"].Value = plane.numberPassengers;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["highColumn"].Value = plane.high;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["portColumn"].Value = "-";
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!baseCheckData() &&!checkDataForShip())
            {
                double xKoord = double.Parse(xKoordinate.Text);
                double yKoord = double.Parse(yKoordinate.Text);
                double prc = double.Parse(price.Text);
                int numPassengers = int.Parse(numberPassengers.Text);
                Ship ship = new Ship(xKoord, yKoord, prc, dateTimePicker1.Value.ToShortDateString(), numPassengers, portTxt.Text);

                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["xColumn"].Value = ship.xKoordinate.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["yColumn"].Value = ship.yKoordinate.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["priceColumn"].Value = ship.price.ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["yearReleaseColumn"].Value = ship.yearRelease;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["numberPassengersColumn"].Value = ship.numberPassengers;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["portColumn"].Value = ship.homePort;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["highColumn"].Value = "-";
                
            }
        }
    }
}
