using System;

namespace CoffeeShopPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        string name;
        int price;
        int tot;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Rice
            if(chckfried.Checked)
            {
                name = "Fried Rice";
                int qty =int.Parse(numericdown.Value.ToString());
                price = 120;
                tot=qty*price;
                this.dataGridView1.Rows.Add(name,price,qty,tot);
            }

           if (chckChiken.Checked)
            {
                name = "Chicken";
                int qty = int.Parse(numericUpDown2.Value.ToString());
                price = 80;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
           if (chckveg.Checked)
            {
                name = "Vegetable";
                int qty = int.Parse(numericUpDown3.Value.ToString());
                price =30;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            //Bevarage
           if (chckTea.Checked)
            {
                name = "Tea";
                int qty = int.Parse(numericUpDown6.Value.ToString());
                price = 10;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            else if (chckCoffee.Checked)
            {
                name = "Coffee";
                int qty = int.Parse(numericUpDown5.Value.ToString());
                price = 20;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            
            }
            if (chckDrinks.Checked)
            {
                name = "Cold Drinks";
                int qty = int.Parse(numericColdeDrinks.Value.ToString());
                price = 20;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);

            }
            //Juice
             if (chckMango.Checked)
            {
                name = "Mango Juice";
                int qty = int.Parse(numericUpDown9.Value.ToString());
                price = 40;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
             if (chckApple.Checked)
            {
                name = "Apple Juice";
                int qty = int.Parse(numericUpDown8.Value.ToString());
                price = 40;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);

            }
             if (chckOrange.Checked)
            {
                name = "Orange Juice";
                int qty = int.Parse(numericUpDown7.Value.ToString());
                price = 30;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);

            }

            int sum = 0;
            for(int row=0; row<dataGridView1.Rows.Count; row++) 
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value); //here cells start 0,1,2 on grid view
            
            }
            TotalBox.Text = sum.ToString();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
  
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chckfish_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}