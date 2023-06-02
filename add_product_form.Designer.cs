namespace fat_secret
{
    partial class add_product_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_button = new System.Windows.Forms.Button();
            this.period_selector = new System.Windows.Forms.ComboBox();
            this.product_selector = new System.Windows.Forms.ComboBox();
            this.product_weight = new System.Windows.Forms.TextBox();
            this.proteins_weight = new System.Windows.Forms.TextBox();
            this.fats_weight = new System.Windows.Forms.TextBox();
            this.carbonhydrates_weight = new System.Windows.Forms.TextBox();
            this.calories_weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(123, 196);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // period_selector
            // 
            this.period_selector.FormattingEnabled = true;
            this.period_selector.Items.AddRange(new object[] {
            "Завтрак",
            "Обед",
            "Ужин"});
            this.period_selector.Location = new System.Drawing.Point(102, 15);
            this.period_selector.Name = "period_selector";
            this.period_selector.Size = new System.Drawing.Size(121, 21);
            this.period_selector.TabIndex = 1;
            this.period_selector.SelectedIndex = 0;
            // 
            // product_selector
            // 
            this.product_selector.FormattingEnabled = true;
            this.product_selector.Location = new System.Drawing.Point(102, 39);
            this.product_selector.Name = "product_selector";
            this.product_selector.Size = new System.Drawing.Size(121, 21);
            this.product_selector.TabIndex = 2;
            this.product_selector.SelectedIndexChanged += new System.EventHandler(this.product_selector_SelectedIndexChanged);
            // 
            // product_weight
            // 
            this.product_weight.Location = new System.Drawing.Point(112, 66);
            this.product_weight.Name = "product_weight";
            this.product_weight.Size = new System.Drawing.Size(100, 20);
            this.product_weight.TabIndex = 3;
            this.product_weight.Text = "0";
            this.product_weight.TextChanged += new System.EventHandler(this.product_weight_TextChanged);
            // 
            // proteins_weight
            // 
            this.proteins_weight.Location = new System.Drawing.Point(112, 92);
            this.proteins_weight.Name = "proteins_weight";
            this.proteins_weight.ReadOnly = true;
            this.proteins_weight.Size = new System.Drawing.Size(100, 20);
            this.proteins_weight.TabIndex = 4;
            this.proteins_weight.Text = "0";
            // 
            // fats_weight
            // 
            this.fats_weight.Location = new System.Drawing.Point(112, 118);
            this.fats_weight.Name = "fats_weight";
            this.fats_weight.ReadOnly = true;
            this.fats_weight.Size = new System.Drawing.Size(100, 20);
            this.fats_weight.TabIndex = 5;
            this.fats_weight.Text = "0";
            // 
            // carbonhydrates_weight
            // 
            this.carbonhydrates_weight.Location = new System.Drawing.Point(112, 144);
            this.carbonhydrates_weight.Name = "carbonhydrates_weight";
            this.carbonhydrates_weight.ReadOnly = true;
            this.carbonhydrates_weight.Size = new System.Drawing.Size(100, 20);
            this.carbonhydrates_weight.TabIndex = 6;
            this.carbonhydrates_weight.Text = "0";
            // 
            // calories_weight
            // 
            this.calories_weight.Location = new System.Drawing.Point(112, 170);
            this.calories_weight.Name = "calories_weight";
            this.calories_weight.ReadOnly = true;
            this.calories_weight.Size = new System.Drawing.Size(100, 20);
            this.calories_weight.TabIndex = 7;
            this.calories_weight.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Период приёма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Продукт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вес, г";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Белки, г";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Жиры, г";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Углеводы, г";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ккал";
            // 
            // add_product_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 249);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calories_weight);
            this.Controls.Add(this.carbonhydrates_weight);
            this.Controls.Add(this.fats_weight);
            this.Controls.Add(this.proteins_weight);
            this.Controls.Add(this.product_weight);
            this.Controls.Add(this.product_selector);
            this.Controls.Add(this.period_selector);
            this.Controls.Add(this.add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "add_product_form";
            this.Text = "Добавления продукта в дневник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox period_selector;
        private System.Windows.Forms.ComboBox product_selector;
        private System.Windows.Forms.TextBox product_weight;
        private System.Windows.Forms.TextBox proteins_weight;
        private System.Windows.Forms.TextBox fats_weight;
        private System.Windows.Forms.TextBox carbonhydrates_weight;
        private System.Windows.Forms.TextBox calories_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}