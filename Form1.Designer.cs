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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pb_total_kkal = new System.Windows.Forms.ProgressBar();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dg_dinner = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dg_lunch = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dg_breakfast = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.gist_week = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_breakfast)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_KA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gist_week)).BeginInit();
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
            // pb_total_kkal
            // 
            this.pb_total_kkal.Location = new System.Drawing.Point(10, 587);
            this.pb_total_kkal.Name = "pb_total_kkal";
            this.pb_total_kkal.Size = new System.Drawing.Size(363, 23);
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
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dg_dinner.Location = new System.Drawing.Point(10, 432);
            this.dg_dinner.Name = "dg_dinner";
            this.dg_dinner.RowHeadersVisible = false;
            this.dg_dinner.Size = new System.Drawing.Size(363, 110);
            this.dg_dinner.TabIndex = 33;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.FillWeight = 120F;
            this.dataGridViewComboBoxColumn2.Frozen = true;
            this.dataGridViewComboBoxColumn2.HeaderText = "Продукт";
            this.dataGridViewComboBoxColumn2.MinimumWidth = 120;
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "г";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Б";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Ж";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 40;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "У";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "ккал";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 50;
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
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dg_lunch.Location = new System.Drawing.Point(10, 254);
            this.dg_lunch.Name = "dg_lunch";
            this.dg_lunch.RowHeadersVisible = false;
            this.dg_lunch.Size = new System.Drawing.Size(363, 110);
            this.dg_lunch.TabIndex = 31;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.FillWeight = 120F;
            this.dataGridViewComboBoxColumn1.Frozen = true;
            this.dataGridViewComboBoxColumn1.HeaderText = "Продукт";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 120;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "г";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Б";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ж";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "У";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ккал";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
            this.dg_breakfast.Location = new System.Drawing.Point(10, 89);
            this.dg_breakfast.Name = "dg_breakfast";
            this.dg_breakfast.RowHeadersVisible = false;
            this.dg_breakfast.Size = new System.Drawing.Size(363, 110);
            this.dg_breakfast.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 120F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Продукт";
            this.Column1.MinimumWidth = 120;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "г";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Б";
            this.Column3.Name = "Column3";
            this.Column3.Width = 40;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ж";
            this.Column5.Name = "Column5";
            this.Column5.Width = 40;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "У";
            this.Column4.Name = "Column4";
            this.Column4.Width = 40;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ккал";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gist_week);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 632);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчёты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
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
            // gist_week
            // 
            chartArea1.Name = "ChartArea1";
            this.gist_week.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gist_week.Legends.Add(legend1);
            this.gist_week.Location = new System.Drawing.Point(66, 118);
            this.gist_week.Name = "gist_week";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.gist_week.Series.Add(series1);
            this.gist_week.Size = new System.Drawing.Size(300, 300);
            this.gist_week.TabIndex = 0;
            this.gist_week.Text = "chart1";
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "main_window";
            this.Text = "Fat Secret";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_breakfast)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_KA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gist_week)).EndInit();
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
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dg_dinner;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dg_lunch;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_Date;
        private System.Windows.Forms.ProgressBar pb_total_kkal;
        private System.Windows.Forms.DataVisualization.Charting.Chart gist_week;
    }
}

