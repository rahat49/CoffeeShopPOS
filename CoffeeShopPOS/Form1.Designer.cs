namespace CoffeeShopPOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Rice = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericdown = new System.Windows.Forms.NumericUpDown();
            this.chckveg = new System.Windows.Forms.CheckBox();
            this.chckChiken = new System.Windows.Forms.CheckBox();
            this.chckfried = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericColdeDrinks = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.chckDrinks = new System.Windows.Forms.CheckBox();
            this.chckCoffee = new System.Windows.Forms.CheckBox();
            this.chckTea = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.chckOrange = new System.Windows.Forms.CheckBox();
            this.chckApple = new System.Windows.Forms.CheckBox();
            this.chckMango = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Rice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericdown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericColdeDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 112);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "COFFEE SHOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Rice
            // 
            this.Rice.Controls.Add(this.numericUpDown3);
            this.Rice.Controls.Add(this.numericUpDown2);
            this.Rice.Controls.Add(this.numericdown);
            this.Rice.Controls.Add(this.chckveg);
            this.Rice.Controls.Add(this.chckChiken);
            this.Rice.Controls.Add(this.chckfried);
            this.Rice.Location = new System.Drawing.Point(12, 136);
            this.Rice.Name = "Rice";
            this.Rice.Size = new System.Drawing.Size(236, 178);
            this.Rice.TabIndex = 1;
            this.Rice.TabStop = false;
            this.Rice.Text = "Rice";
            this.Rice.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(127, 127);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown3.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(127, 83);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericdown
            // 
            this.numericdown.Location = new System.Drawing.Point(127, 32);
            this.numericdown.Name = "numericdown";
            this.numericdown.Size = new System.Drawing.Size(84, 23);
            this.numericdown.TabIndex = 2;
            // 
            // chckveg
            // 
            this.chckveg.AutoSize = true;
            this.chckveg.Location = new System.Drawing.Point(23, 131);
            this.chckveg.Name = "chckveg";
            this.chckveg.Size = new System.Drawing.Size(77, 19);
            this.chckveg.TabIndex = 2;
            this.chckveg.Text = "Vegetable";
            this.chckveg.UseVisualStyleBackColor = true;
            this.chckveg.CheckedChanged += new System.EventHandler(this.chckfish_CheckedChanged);
            // 
            // chckChiken
            // 
            this.chckChiken.AutoSize = true;
            this.chckChiken.Location = new System.Drawing.Point(23, 83);
            this.chckChiken.Name = "chckChiken";
            this.chckChiken.Size = new System.Drawing.Size(69, 19);
            this.chckChiken.TabIndex = 1;
            this.chckChiken.Text = "Chicken";
            this.chckChiken.UseVisualStyleBackColor = true;
            this.chckChiken.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chckfried
            // 
            this.chckfried.AutoSize = true;
            this.chckfried.Location = new System.Drawing.Point(23, 32);
            this.chckfried.Name = "chckfried";
            this.chckfried.Size = new System.Drawing.Size(77, 19);
            this.chckfried.TabIndex = 0;
            this.chckfried.Text = "Fried Rice";
            this.chckfried.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericColdeDrinks);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.chckDrinks);
            this.groupBox1.Controls.Add(this.chckCoffee);
            this.groupBox1.Controls.Add(this.chckTea);
            this.groupBox1.Location = new System.Drawing.Point(284, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drinks";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // numericColdeDrinks
            // 
            this.numericColdeDrinks.Location = new System.Drawing.Point(127, 127);
            this.numericColdeDrinks.Name = "numericColdeDrinks";
            this.numericColdeDrinks.Size = new System.Drawing.Size(84, 23);
            this.numericColdeDrinks.TabIndex = 4;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(127, 83);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown5.TabIndex = 3;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(127, 32);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown6.TabIndex = 2;
            // 
            // chckDrinks
            // 
            this.chckDrinks.AutoSize = true;
            this.chckDrinks.Location = new System.Drawing.Point(23, 131);
            this.chckDrinks.Name = "chckDrinks";
            this.chckDrinks.Size = new System.Drawing.Size(87, 19);
            this.chckDrinks.TabIndex = 2;
            this.chckDrinks.Text = "Cold Drinks";
            this.chckDrinks.UseVisualStyleBackColor = true;
            // 
            // chckCoffee
            // 
            this.chckCoffee.AutoSize = true;
            this.chckCoffee.Location = new System.Drawing.Point(23, 83);
            this.chckCoffee.Name = "chckCoffee";
            this.chckCoffee.Size = new System.Drawing.Size(61, 19);
            this.chckCoffee.TabIndex = 1;
            this.chckCoffee.Text = "Coffee";
            this.chckCoffee.UseVisualStyleBackColor = true;
            // 
            // chckTea
            // 
            this.chckTea.AutoSize = true;
            this.chckTea.Location = new System.Drawing.Point(23, 32);
            this.chckTea.Name = "chckTea";
            this.chckTea.Size = new System.Drawing.Size(43, 19);
            this.chckTea.TabIndex = 0;
            this.chckTea.Text = "Tea";
            this.chckTea.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown7);
            this.groupBox2.Controls.Add(this.numericUpDown8);
            this.groupBox2.Controls.Add(this.numericUpDown9);
            this.groupBox2.Controls.Add(this.chckOrange);
            this.groupBox2.Controls.Add(this.chckApple);
            this.groupBox2.Controls.Add(this.chckMango);
            this.groupBox2.Location = new System.Drawing.Point(552, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 178);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Juice";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(127, 127);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown7.TabIndex = 4;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(127, 83);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown8.TabIndex = 3;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(127, 32);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown9.TabIndex = 2;
            // 
            // chckOrange
            // 
            this.chckOrange.AutoSize = true;
            this.chckOrange.Location = new System.Drawing.Point(23, 131);
            this.chckOrange.Name = "chckOrange";
            this.chckOrange.Size = new System.Drawing.Size(65, 19);
            this.chckOrange.TabIndex = 2;
            this.chckOrange.Text = "Orange";
            this.chckOrange.UseVisualStyleBackColor = true;
            // 
            // chckApple
            // 
            this.chckApple.AutoSize = true;
            this.chckApple.Location = new System.Drawing.Point(23, 83);
            this.chckApple.Name = "chckApple";
            this.chckApple.Size = new System.Drawing.Size(57, 19);
            this.chckApple.TabIndex = 1;
            this.chckApple.Text = "Apple";
            this.chckApple.UseVisualStyleBackColor = true;
            // 
            // chckMango
            // 
            this.chckMango.AutoSize = true;
            this.chckMango.Location = new System.Drawing.Point(23, 32);
            this.chckMango.Name = "chckMango";
            this.chckMango.Size = new System.Drawing.Size(64, 19);
            this.chckMango.TabIndex = 0;
            this.chckMango.Text = "Mango";
            this.chckMango.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(830, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(689, 231);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qty";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // TotalBox
            // 
            this.TotalBox.BackColor = System.Drawing.Color.Black;
            this.TotalBox.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalBox.ForeColor = System.Drawing.Color.Yellow;
            this.TotalBox.Location = new System.Drawing.Point(765, 432);
            this.TotalBox.Multiline = true;
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(172, 55);
            this.TotalBox.TabIndex = 9;
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(843, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 582);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Rice);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Rice.ResumeLayout(false);
            this.Rice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericdown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericColdeDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox Rice;
        private CheckBox chckveg;
        private CheckBox chckChiken;
        private CheckBox chckfried;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericdown;
        private GroupBox groupBox1;
        private NumericUpDown numericColdeDrinks;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private CheckBox chckDrinks;
        private CheckBox chckCoffee;
        private CheckBox chckTea;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown8;
        private NumericUpDown numericUpDown9;
        private CheckBox chckOrange;
        private CheckBox chckApple;
        private CheckBox chckMango;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private TextBox TotalBox;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}