namespace fat_secret
{
    partial class main_window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.current_kkal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.pb_total_kkal = new System.Windows.Forms.ProgressBar();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dg_dinner = new System.Windows.Forms.DataGridView();
            this.dinner_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinner_product_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinner_product_proteins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinner_product_fats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinner_product_carbonhydrates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinner_product_calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dg_lunch = new System.Windows.Forms.DataGridView();
            this.lunch_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunch_product_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunch_product_proteins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunch_product_fats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunch_product_carbonhydrates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunch_product_calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dg_breakfast = new System.Windows.Forms.DataGridView();
            this.breakfast_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfast_product_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfast_product_proteins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfast_product_fats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfast_product_carbonhydrates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfast_product_calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gist_week = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_RSK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_RSK = new System.Windows.Forms.Button();
            this.pb_KA = new System.Windows.Forms.PictureBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.cb_dinweight = new System.Windows.Forms.ComboBox();
            this.tb_KA = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.make_report = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_breakfast)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gist_week)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_KA)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 658);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.current_kkal);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.add_button);
            this.tabPage1.Controls.Add(this.pb_total_kkal);
            this.tabPage1.Controls.Add(this.dt_Date);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.dg_dinner);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dg_lunch);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dg_breakfast);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 632);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Дневник";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(188, 571);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(9, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "|";
            // 
            // current_kkal
            // 
            this.current_kkal.AutoSize = true;
            this.current_kkal.Location = new System.Drawing.Point(142, 571);
            this.current_kkal.Name = "current_kkal";
            this.current_kkal.Size = new System.Drawing.Size(13, 13);
            this.current_kkal.TabIndex = 36;
            this.current_kkal.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Употребленные калории: ";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(381, 21);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // pb_total_kkal
            // 
            this.pb_total_kkal.BackColor = System.Drawing.Color.Yellow;
            this.pb_total_kkal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pb_total_kkal.Location = new System.Drawing.Point(10, 587);
            this.pb_total_kkal.Name = "pb_total_kkal";
            this.pb_total_kkal.Size = new System.Drawing.Size(363, 23);
            this.pb_total_kkal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_total_kkal.TabIndex = 35;
            // 
            // dt_Date
            // 
            this.dt_Date.Enabled = false;
            this.dt_Date.Location = new System.Drawing.Point(10, 21);
            this.dt_Date.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dt_Date.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(121, 20);
            this.dt_Date.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "Ужин";
            // 
            // dg_dinner
            // 
            this.dg_dinner.AllowUserToResizeColumns = false;
            this.dg_dinner.AllowUserToResizeRows = false;
            this.dg_dinner.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_dinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dinner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dinner_product,
            this.dinner_product_weight,
            this.dinner_product_proteins,
            this.dinner_product_fats,
            this.dinner_product_carbonhydrates,
            this.dinner_product_calories});
            this.dg_dinner.Location = new System.Drawing.Point(10, 432);
            this.dg_dinner.Name = "dg_dinner";
            this.dg_dinner.RowHeadersVisible = false;
            this.dg_dinner.Size = new System.Drawing.Size(313, 110);
            this.dg_dinner.TabIndex = 33;
            this.dg_dinner.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dinner_CellContentDoubleClick);
            // 
            // dinner_product
            // 
            this.dinner_product.HeaderText = "Продукт";
            this.dinner_product.Name = "dinner_product";
            this.dinner_product.ReadOnly = true;
            // 
            // dinner_product_weight
            // 
            this.dinner_product_weight.HeaderText = "г";
            this.dinner_product_weight.Name = "dinner_product_weight";
            this.dinner_product_weight.ReadOnly = true;
            this.dinner_product_weight.Width = 40;
            // 
            // dinner_product_proteins
            // 
            this.dinner_product_proteins.HeaderText = "Б";
            this.dinner_product_proteins.Name = "dinner_product_proteins";
            this.dinner_product_proteins.ReadOnly = true;
            this.dinner_product_proteins.Width = 40;
            // 
            // dinner_product_fats
            // 
            this.dinner_product_fats.HeaderText = "Ж";
            this.dinner_product_fats.Name = "dinner_product_fats";
            this.dinner_product_fats.ReadOnly = true;
            this.dinner_product_fats.Width = 40;
            // 
            // dinner_product_carbonhydrates
            // 
            this.dinner_product_carbonhydrates.HeaderText = "У";
            this.dinner_product_carbonhydrates.Name = "dinner_product_carbonhydrates";
            this.dinner_product_carbonhydrates.ReadOnly = true;
            this.dinner_product_carbonhydrates.Width = 40;
            // 
            // dinner_product_calories
            // 
            this.dinner_product_calories.HeaderText = "ккал";
            this.dinner_product_calories.Name = "dinner_product_calories";
            this.dinner_product_calories.ReadOnly = true;
            this.dinner_product_calories.Width = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Обед";
            // 
            // dg_lunch
            // 
            this.dg_lunch.AllowUserToResizeColumns = false;
            this.dg_lunch.AllowUserToResizeRows = false;
            this.dg_lunch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_lunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lunch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lunch_product,
            this.lunch_product_weight,
            this.lunch_product_proteins,
            this.lunch_product_fats,
            this.lunch_product_carbonhydrates,
            this.lunch_product_calories});
            this.dg_lunch.Location = new System.Drawing.Point(10, 254);
            this.dg_lunch.Name = "dg_lunch";
            this.dg_lunch.RowHeadersVisible = false;
            this.dg_lunch.Size = new System.Drawing.Size(313, 110);
            this.dg_lunch.TabIndex = 31;
            this.dg_lunch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lunch_CellContentDoubleClick);
            // 
            // lunch_product
            // 
            this.lunch_product.HeaderText = "Продукт";
            this.lunch_product.Name = "lunch_product";
            this.lunch_product.ReadOnly = true;
            // 
            // lunch_product_weight
            // 
            this.lunch_product_weight.HeaderText = "г";
            this.lunch_product_weight.Name = "lunch_product_weight";
            this.lunch_product_weight.ReadOnly = true;
            this.lunch_product_weight.Width = 40;
            // 
            // lunch_product_proteins
            // 
            this.lunch_product_proteins.HeaderText = "Б";
            this.lunch_product_proteins.Name = "lunch_product_proteins";
            this.lunch_product_proteins.ReadOnly = true;
            this.lunch_product_proteins.Width = 40;
            // 
            // lunch_product_fats
            // 
            this.lunch_product_fats.HeaderText = "Ж";
            this.lunch_product_fats.Name = "lunch_product_fats";
            this.lunch_product_fats.ReadOnly = true;
            this.lunch_product_fats.Width = 40;
            // 
            // lunch_product_carbonhydrates
            // 
            this.lunch_product_carbonhydrates.HeaderText = "У";
            this.lunch_product_carbonhydrates.Name = "lunch_product_carbonhydrates";
            this.lunch_product_carbonhydrates.ReadOnly = true;
            this.lunch_product_carbonhydrates.Width = 40;
            // 
            // lunch_product_calories
            // 
            this.lunch_product_calories.HeaderText = "ккал";
            this.lunch_product_calories.Name = "lunch_product_calories";
            this.lunch_product_calories.Width = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Завтрак";
            // 
            // dg_breakfast
            // 
            this.dg_breakfast.AllowUserToResizeColumns = false;
            this.dg_breakfast.AllowUserToResizeRows = false;
            this.dg_breakfast.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_breakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_breakfast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.breakfast_product,
            this.breakfast_product_weight,
            this.breakfast_product_proteins,
            this.breakfast_product_fats,
            this.breakfast_product_carbonhydrates,
            this.breakfast_product_calories});
            this.dg_breakfast.Location = new System.Drawing.Point(10, 89);
            this.dg_breakfast.Name = "dg_breakfast";
            this.dg_breakfast.RowHeadersVisible = false;
            this.dg_breakfast.Size = new System.Drawing.Size(313, 110);
            this.dg_breakfast.TabIndex = 1;
            this.dg_breakfast.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_breakfast_CellDoubleClick);
            // 
            // breakfast_product
            // 
            this.breakfast_product.HeaderText = "Продукт";
            this.breakfast_product.Name = "breakfast_product";
            this.breakfast_product.ReadOnly = true;
            // 
            // breakfast_product_weight
            // 
            this.breakfast_product_weight.HeaderText = "г";
            this.breakfast_product_weight.Name = "breakfast_product_weight";
            this.breakfast_product_weight.ReadOnly = true;
            this.breakfast_product_weight.Width = 40;
            // 
            // breakfast_product_proteins
            // 
            this.breakfast_product_proteins.HeaderText = "Б";
            this.breakfast_product_proteins.Name = "breakfast_product_proteins";
            this.breakfast_product_proteins.ReadOnly = true;
            this.breakfast_product_proteins.Width = 40;
            // 
            // breakfast_product_fats
            // 
            this.breakfast_product_fats.HeaderText = "Ж";
            this.breakfast_product_fats.Name = "breakfast_product_fats";
            this.breakfast_product_fats.ReadOnly = true;
            this.breakfast_product_fats.Width = 40;
            // 
            // breakfast_product_carbonhydrates
            // 
            this.breakfast_product_carbonhydrates.HeaderText = "У";
            this.breakfast_product_carbonhydrates.Name = "breakfast_product_carbonhydrates";
            this.breakfast_product_carbonhydrates.ReadOnly = true;
            this.breakfast_product_carbonhydrates.Width = 40;
            // 
            // breakfast_product_calories
            // 
            this.breakfast_product_calories.HeaderText = "ккал";
            this.breakfast_product_calories.Name = "breakfast_product_calories";
            this.breakfast_product_calories.ReadOnly = true;
            this.breakfast_product_calories.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.make_report);
            this.tabPage2.Controls.Add(this.gist_week);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 632);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчёты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gist_week
            // 
            chartArea1.Name = "ChartArea1";
            this.gist_week.ChartAreas.Add(chartArea1);
            this.gist_week.Location = new System.Drawing.Point(29, 125);
            this.gist_week.Name = "gist_week";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.gist_week.Series.Add(series1);
            this.gist_week.Size = new System.Drawing.Size(410, 376);
            this.gist_week.TabIndex = 0;
            this.gist_week.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.tb_height);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tb_RSK);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btn_RSK);
            this.tabPage3.Controls.Add(this.pb_KA);
            this.tabPage3.Controls.Add(this.cb_gender);
            this.tabPage3.Controls.Add(this.cb_dinweight);
            this.tabPage3.Controls.Add(this.tb_KA);
            this.tabPage3.Controls.Add(this.tb_weight);
            this.tabPage3.Controls.Add(this.tb_age);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(474, 632);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Рассчёт РСК";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "ккал";
            // 
            // tb_height
            // 
            this.tb_height.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_height.Location = new System.Drawing.Point(190, 124);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(80, 20);
            this.tb_height.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(152, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Рост";
            // 
            // tb_RSK
            // 
            this.tb_RSK.Location = new System.Drawing.Point(238, 396);
            this.tb_RSK.Name = "tb_RSK";
            this.tb_RSK.Size = new System.Drawing.Size(67, 20);
            this.tb_RSK.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(179, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "=>";
            // 
            // btn_RSK
            // 
            this.btn_RSK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RSK.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RSK.Location = new System.Drawing.Point(54, 380);
            this.btn_RSK.Name = "btn_RSK";
            this.btn_RSK.Size = new System.Drawing.Size(109, 49);
            this.btn_RSK.TabIndex = 41;
            this.btn_RSK.Text = "Рассчитать РСК";
            this.btn_RSK.UseVisualStyleBackColor = true;
            this.btn_RSK.Click += new System.EventHandler(this.btn_RSK_Click);
            // 
            // pb_KA
            // 
            this.pb_KA.Image = global::fat_secret.Properties.Resources.KA;
            this.pb_KA.Location = new System.Drawing.Point(6, 207);
            this.pb_KA.Name = "pb_KA";
            this.pb_KA.Size = new System.Drawing.Size(461, 123);
            this.pb_KA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_KA.TabIndex = 40;
            this.pb_KA.TabStop = false;
            // 
            // cb_gender
            // 
            this.cb_gender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Ж",
            "М"});
            this.cb_gender.Location = new System.Drawing.Point(190, 88);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(80, 21);
            this.cb_gender.TabIndex = 39;
            // 
            // cb_dinweight
            // 
            this.cb_dinweight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_dinweight.FormattingEnabled = true;
            this.cb_dinweight.Items.AddRange(new object[] {
            "снизить",
            "увеличить",
            "сохранить"});
            this.cb_dinweight.Location = new System.Drawing.Point(190, 180);
            this.cb_dinweight.Name = "cb_dinweight";
            this.cb_dinweight.Size = new System.Drawing.Size(80, 21);
            this.cb_dinweight.TabIndex = 38;
            // 
            // tb_KA
            // 
            this.tb_KA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_KA.Location = new System.Drawing.Point(190, 162);
            this.tb_KA.Name = "tb_KA";
            this.tb_KA.Size = new System.Drawing.Size(80, 20);
            this.tb_KA.TabIndex = 37;
            // 
            // tb_weight
            // 
            this.tb_weight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_weight.Location = new System.Drawing.Point(190, 143);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(80, 20);
            this.tb_weight.TabIndex = 36;
            // 
            // tb_age
            // 
            this.tb_age.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_age.Location = new System.Drawing.Point(190, 108);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(80, 20);
            this.tb_age.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(92, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Динамика веса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Коэффициент активности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(157, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Вес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(132, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Возраст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Пол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ввести параметры";
            // 
            // make_report
            // 
            this.make_report.Location = new System.Drawing.Point(181, 96);
            this.make_report.Name = "make_report";
            this.make_report.Size = new System.Drawing.Size(126, 23);
            this.make_report.TabIndex = 1;
            this.make_report.Text = "Сделать отчёт";
            this.make_report.UseVisualStyleBackColor = true;
            this.make_report.Click += new System.EventHandler(this.make_report_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main_window";
            this.Text = "Fat Secret";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_breakfast)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gist_week)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_KA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_RSK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_RSK;
        private System.Windows.Forms.PictureBox pb_KA;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.ComboBox cb_dinweight;
        private System.Windows.Forms.TextBox tb_KA;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_breakfast;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dg_dinner;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dg_lunch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_Date;
        private System.Windows.Forms.ProgressBar pb_total_kkal;
        private System.Windows.Forms.DataVisualization.Charting.Chart gist_week;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfast_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfast_product_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfast_product_proteins;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfast_product_fats;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfast_product_carbonhydrates;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfast_product_calories;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinner_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinner_product_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinner_product_proteins;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinner_product_fats;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinner_product_carbonhydrates;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinner_product_calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunch_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunch_product_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunch_product_proteins;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunch_product_fats;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunch_product_carbonhydrates;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunch_product_calories;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label current_kkal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button make_report;
    }
}

