namespace WindowsFormsApp2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.internet_providerDataSet2 = new WindowsFormsApp2.Internet_providerDataSet2();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp2.Internet_providerDataSet2TableAdapters.EmployeesTableAdapter();
            this.internet_providerDataSet1 = new WindowsFormsApp2.Internet_providerDataSet1();
            this.internetproviderDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter1 = new WindowsFormsApp2.Internet_providerDataSet1TableAdapters.EmployeesTableAdapter();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_providerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_providerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetproviderDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 270);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 296);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Должность";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Домашний адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Домашний телефон";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 322);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Сотовый телефон";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.homeaddressDataGridViewTextBoxColumn,
            this.homephoneDataGridViewTextBoxColumn,
            this.mobilephoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // internet_providerDataSet2
            // 
            this.internet_providerDataSet2.DataSetName = "Internet_providerDataSet2";
            this.internet_providerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.internet_providerDataSet2;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // internet_providerDataSet1
            // 
            this.internet_providerDataSet1.DataSetName = "Internet_providerDataSet1";
            this.internet_providerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // internetproviderDataSet1BindingSource
            // 
            this.internetproviderDataSet1BindingSource.DataSource = this.internet_providerDataSet1;
            this.internetproviderDataSet1BindingSource.Position = 0;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.internetproviderDataSet1BindingSource;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "full_name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // homeaddressDataGridViewTextBoxColumn
            // 
            this.homeaddressDataGridViewTextBoxColumn.DataPropertyName = "home_address";
            this.homeaddressDataGridViewTextBoxColumn.HeaderText = "home_address";
            this.homeaddressDataGridViewTextBoxColumn.Name = "homeaddressDataGridViewTextBoxColumn";
            // 
            // homephoneDataGridViewTextBoxColumn
            // 
            this.homephoneDataGridViewTextBoxColumn.DataPropertyName = "home_phone";
            this.homephoneDataGridViewTextBoxColumn.HeaderText = "home_phone";
            this.homephoneDataGridViewTextBoxColumn.Name = "homephoneDataGridViewTextBoxColumn";
            // 
            // mobilephoneDataGridViewTextBoxColumn
            // 
            this.mobilephoneDataGridViewTextBoxColumn.DataPropertyName = "mobile_phone";
            this.mobilephoneDataGridViewTextBoxColumn.HeaderText = "mobile_phone";
            this.mobilephoneDataGridViewTextBoxColumn.Name = "mobilephoneDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_providerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_providerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetproviderDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Internet_providerDataSet2 internet_providerDataSet2;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Internet_providerDataSet2TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource internetproviderDataSet1BindingSource;
        private Internet_providerDataSet1 internet_providerDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private Internet_providerDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilephoneDataGridViewTextBoxColumn;
    }
}

