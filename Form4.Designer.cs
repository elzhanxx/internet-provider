namespace WindowsFormsApp2
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameoforganizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressoforganizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneoforganizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofminutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costofoneminuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneofoperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameofoperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.internet_providerDataSet2 = new WindowsFormsApp2.Internet_providerDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.receiptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptsTableAdapter = new WindowsFormsApp2.Internet_providerDataSet2TableAdapters.ReceiptsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_providerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameoforganizationDataGridViewTextBoxColumn,
            this.adressoforganizationDataGridViewTextBoxColumn,
            this.phoneoforganizationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.numberofminutesDataGridViewTextBoxColumn,
            this.costofoneminuteDataGridViewTextBoxColumn,
            this.grandtotalDataGridViewTextBoxColumn,
            this.phoneofoperatorDataGridViewTextBoxColumn,
            this.fullnameofoperatorDataGridViewTextBoxColumn,
            this.shiftnumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receiptsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameoforganizationDataGridViewTextBoxColumn
            // 
            this.nameoforganizationDataGridViewTextBoxColumn.DataPropertyName = "name_of_organization";
            this.nameoforganizationDataGridViewTextBoxColumn.HeaderText = "name_of_organization";
            this.nameoforganizationDataGridViewTextBoxColumn.Name = "nameoforganizationDataGridViewTextBoxColumn";
            // 
            // adressoforganizationDataGridViewTextBoxColumn
            // 
            this.adressoforganizationDataGridViewTextBoxColumn.DataPropertyName = "adress_of_organization";
            this.adressoforganizationDataGridViewTextBoxColumn.HeaderText = "adress_of_organization";
            this.adressoforganizationDataGridViewTextBoxColumn.Name = "adressoforganizationDataGridViewTextBoxColumn";
            // 
            // phoneoforganizationDataGridViewTextBoxColumn
            // 
            this.phoneoforganizationDataGridViewTextBoxColumn.DataPropertyName = "phone_of_organization";
            this.phoneoforganizationDataGridViewTextBoxColumn.HeaderText = "phone_of_organization";
            this.phoneoforganizationDataGridViewTextBoxColumn.Name = "phoneoforganizationDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // numberofminutesDataGridViewTextBoxColumn
            // 
            this.numberofminutesDataGridViewTextBoxColumn.DataPropertyName = "number_of_minutes";
            this.numberofminutesDataGridViewTextBoxColumn.HeaderText = "number_of_minutes";
            this.numberofminutesDataGridViewTextBoxColumn.Name = "numberofminutesDataGridViewTextBoxColumn";
            // 
            // costofoneminuteDataGridViewTextBoxColumn
            // 
            this.costofoneminuteDataGridViewTextBoxColumn.DataPropertyName = "cost_of_one_minute";
            this.costofoneminuteDataGridViewTextBoxColumn.HeaderText = "cost_of_one_minute";
            this.costofoneminuteDataGridViewTextBoxColumn.Name = "costofoneminuteDataGridViewTextBoxColumn";
            // 
            // grandtotalDataGridViewTextBoxColumn
            // 
            this.grandtotalDataGridViewTextBoxColumn.DataPropertyName = "grand_total";
            this.grandtotalDataGridViewTextBoxColumn.HeaderText = "grand_total";
            this.grandtotalDataGridViewTextBoxColumn.Name = "grandtotalDataGridViewTextBoxColumn";
            // 
            // phoneofoperatorDataGridViewTextBoxColumn
            // 
            this.phoneofoperatorDataGridViewTextBoxColumn.DataPropertyName = "phone_of_operator";
            this.phoneofoperatorDataGridViewTextBoxColumn.HeaderText = "phone_of_operator";
            this.phoneofoperatorDataGridViewTextBoxColumn.Name = "phoneofoperatorDataGridViewTextBoxColumn";
            // 
            // fullnameofoperatorDataGridViewTextBoxColumn
            // 
            this.fullnameofoperatorDataGridViewTextBoxColumn.DataPropertyName = "full_name_of_operator";
            this.fullnameofoperatorDataGridViewTextBoxColumn.HeaderText = "full_name_of_operator";
            this.fullnameofoperatorDataGridViewTextBoxColumn.Name = "fullnameofoperatorDataGridViewTextBoxColumn";
            // 
            // shiftnumberDataGridViewTextBoxColumn
            // 
            this.shiftnumberDataGridViewTextBoxColumn.DataPropertyName = "shift_number";
            this.shiftnumberDataGridViewTextBoxColumn.HeaderText = "shift_number";
            this.shiftnumberDataGridViewTextBoxColumn.Name = "shiftnumberDataGridViewTextBoxColumn";
            // 
            // receiptsBindingSource1
            // 
            this.receiptsBindingSource1.DataMember = "Receipts";
            this.receiptsBindingSource1.DataSource = this.internet_providerDataSet2;
            // 
            // internet_providerDataSet2
            // 
            this.internet_providerDataSet2.DataSetName = "Internet_providerDataSet2";
            this.internet_providerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя организации";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адрес организации";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер организации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Время начала";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Время конца";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Количество минут";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Стоимость одной минуты";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Итоговая сумма";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Номер оператора";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "ФИО оператора";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Номер смены";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 292);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 318);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(135, 344);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(400, 225);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(400, 247);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(400, 270);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 23;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(400, 292);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(400, 313);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 24;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(400, 337);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 25;
            // 
            // receiptsBindingSource
            // 
            this.receiptsBindingSource.DataMember = "Receipts";
            this.receiptsBindingSource.DataSource = this.internet_providerDataSet2;
            // 
            // receiptsTableAdapter
            // 
            this.receiptsTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 450);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internet_providerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private Internet_providerDataSet2 internet_providerDataSet2;
        private System.Windows.Forms.BindingSource receiptsBindingSource;
        private Internet_providerDataSet2TableAdapters.ReceiptsTableAdapter receiptsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameoforganizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressoforganizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneoforganizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofminutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costofoneminuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneofoperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameofoperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource receiptsBindingSource1;
    }
}

