
namespace Lab1._2
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
            this.button1 = new System.Windows.Forms.Button();
            this.xKoordinate = new System.Windows.Forms.TextBox();
            this.yKoordinate = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.high = new System.Windows.Forms.TextBox();
            this.numberPassengers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.speed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.portTxt = new System.Windows.Forms.Label();
            this.xColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearReleaseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPassengersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xKoordinate
            // 
            this.xKoordinate.Location = new System.Drawing.Point(23, 55);
            this.xKoordinate.Name = "xKoordinate";
            this.xKoordinate.Size = new System.Drawing.Size(70, 27);
            this.xKoordinate.TabIndex = 1;
            // 
            // yKoordinate
            // 
            this.yKoordinate.Location = new System.Drawing.Point(99, 56);
            this.yKoordinate.Name = "yKoordinate";
            this.yKoordinate.Size = new System.Drawing.Size(66, 27);
            this.yKoordinate.TabIndex = 2;
            this.yKoordinate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(174, 55);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(104, 27);
            this.price.TabIndex = 4;
            // 
            // high
            // 
            this.high.Location = new System.Drawing.Point(628, 54);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(92, 27);
            this.high.TabIndex = 5;
            // 
            // numberPassengers
            // 
            this.numberPassengers.Location = new System.Drawing.Point(745, 53);
            this.numberPassengers.Name = "numberPassengers";
            this.numberPassengers.Size = new System.Drawing.Size(120, 27);
            this.numberPassengers.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Высота";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество пассажиров";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Plane";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Ship";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xColumn,
            this.portColumn,
            this.yColumn,
            this.priceColumn,
            this.yearReleaseColumn,
            this.numberPassengersColumn,
            this.highColumn});
            this.dataGridView1.Location = new System.Drawing.Point(225, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(805, 343);
            this.dataGridView1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 27);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(284, 54);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(115, 27);
            this.speed.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Скорость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Дата выпуска";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(936, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 20;
            // 
            // portTxt
            // 
            this.portTxt.AutoSize = true;
            this.portTxt.Location = new System.Drawing.Point(946, 30);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(44, 20);
            this.portTxt.TabIndex = 21;
            this.portTxt.Text = "Порт";
            // 
            // xColumn
            // 
            this.xColumn.HeaderText = "X";
            this.xColumn.MinimumWidth = 6;
            this.xColumn.Name = "xColumn";
            this.xColumn.Width = 125;
            // 
            // portColumn
            // 
            this.portColumn.HeaderText = "Порт";
            this.portColumn.MinimumWidth = 6;
            this.portColumn.Name = "portColumn";
            this.portColumn.Width = 125;
            // 
            // yColumn
            // 
            this.yColumn.HeaderText = "Y";
            this.yColumn.MinimumWidth = 6;
            this.yColumn.Name = "yColumn";
            this.yColumn.Width = 125;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Цена";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.Width = 125;
            // 
            // yearReleaseColumn
            // 
            this.yearReleaseColumn.HeaderText = "Год выпуска";
            this.yearReleaseColumn.MinimumWidth = 6;
            this.yearReleaseColumn.Name = "yearReleaseColumn";
            this.yearReleaseColumn.Width = 125;
            // 
            // numberPassengersColumn
            // 
            this.numberPassengersColumn.HeaderText = "Количество пассажиров";
            this.numberPassengersColumn.MinimumWidth = 6;
            this.numberPassengersColumn.Name = "numberPassengersColumn";
            this.numberPassengersColumn.Width = 125;
            // 
            // highColumn
            // 
            this.highColumn.HeaderText = "High";
            this.highColumn.MinimumWidth = 6;
            this.highColumn.Name = "highColumn";
            this.highColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 552);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberPassengers);
            this.Controls.Add(this.high);
            this.Controls.Add(this.price);
            this.Controls.Add(this.yKoordinate);
            this.Controls.Add(this.xKoordinate);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox xKoordinate;
        private System.Windows.Forms.TextBox yKoordinate;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox high;
        private System.Windows.Forms.TextBox numberPassengers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label portTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn xColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearReleaseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPassengersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highColumn;
    }
}

