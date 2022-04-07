
namespace Ruchki
{
    partial class FrmMaterial
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
            this.наименованиеМатериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоВУпаковкеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальноеКоличествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типМатериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialssimportBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Ruchki.DataSet2();
            this.materialssimportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Ruchki.DataSet1();
            this.materials_s_import_TableAdapter = new Ruchki.DataSet1TableAdapters.materials_s_import_TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.materialssimportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialssimportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.materialssimportBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.materials_s_import_TableAdapter1 = new Ruchki.DataSet2TableAdapters.materials_s_import_TableAdapter();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialssimportBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.materialssimportBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеМатериалаDataGridViewTextBoxColumn,
            this.количествоНаСкладеDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn,
            this.количествоВУпаковкеDataGridViewTextBoxColumn,
            this.минимальноеКоличествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.изображениеDataGridViewTextBoxColumn,
            this.типМатериалаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialssimportBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(64, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1052, 306);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(441, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // наименованиеМатериалаDataGridViewTextBoxColumn
            // 
            this.наименованиеМатериалаDataGridViewTextBoxColumn.DataPropertyName = "Наименование материала";
            this.наименованиеМатериалаDataGridViewTextBoxColumn.HeaderText = "Наименование материала";
            this.наименованиеМатериалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеМатериалаDataGridViewTextBoxColumn.Name = "наименованиеМатериалаDataGridViewTextBoxColumn";
            this.наименованиеМатериалаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.HeaderText = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоНаСкладеDataGridViewTextBoxColumn.Name = "количествоНаСкладеDataGridViewTextBoxColumn";
            this.количествоНаСкладеDataGridViewTextBoxColumn.Width = 125;
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоВУпаковкеDataGridViewTextBoxColumn
            // 
            this.количествоВУпаковкеDataGridViewTextBoxColumn.DataPropertyName = "Количество в упаковке";
            this.количествоВУпаковкеDataGridViewTextBoxColumn.HeaderText = "Количество в упаковке";
            this.количествоВУпаковкеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоВУпаковкеDataGridViewTextBoxColumn.Name = "количествоВУпаковкеDataGridViewTextBoxColumn";
            this.количествоВУпаковкеDataGridViewTextBoxColumn.Width = 125;
            // 
            // минимальноеКоличествоDataGridViewTextBoxColumn
            // 
            this.минимальноеКоличествоDataGridViewTextBoxColumn.DataPropertyName = "Минимальное количество";
            this.минимальноеКоличествоDataGridViewTextBoxColumn.HeaderText = "Минимальное количество";
            this.минимальноеКоличествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.минимальноеКоличествоDataGridViewTextBoxColumn.Name = "минимальноеКоличествоDataGridViewTextBoxColumn";
            this.минимальноеКоличествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // изображениеDataGridViewTextBoxColumn
            // 
            this.изображениеDataGridViewTextBoxColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.изображениеDataGridViewTextBoxColumn.Name = "изображениеDataGridViewTextBoxColumn";
            this.изображениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // типМатериалаDataGridViewTextBoxColumn
            // 
            this.типМатериалаDataGridViewTextBoxColumn.DataPropertyName = "Тип материала";
            this.типМатериалаDataGridViewTextBoxColumn.HeaderText = "Тип материала";
            this.типМатериалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типМатериалаDataGridViewTextBoxColumn.Name = "типМатериалаDataGridViewTextBoxColumn";
            this.типМатериалаDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialssimportBindingSource6
            // 
            this.materialssimportBindingSource6.DataMember = "materials_s_import$";
            this.materialssimportBindingSource6.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialssimportBindingSource
            // 
            this.materialssimportBindingSource.DataMember = "materials_s_import$";
            this.materialssimportBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materials_s_import_TableAdapter
            // 
            this.materials_s_import_TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество строк:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Title",
            "Cost",
            "CountInStock"});
            this.comboBox1.Location = new System.Drawing.Point(428, 71);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(656, 73);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 449);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(899, 73);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Фильтрация";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 448);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Удалить запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // materialssimportBindingSource1
            // 
            this.materialssimportBindingSource1.DataMember = "materials_s_import$";
            this.materialssimportBindingSource1.DataSource = this.dataSet1;
            // 
            // materialssimportBindingSource2
            // 
            this.materialssimportBindingSource2.DataMember = "materials_s_import$";
            this.materialssimportBindingSource2.DataSource = this.dataSet1;
            // 
            // materialssimportBindingSource3
            // 
            this.materialssimportBindingSource3.DataMember = "materials_s_import$";
            this.materialssimportBindingSource3.DataSource = this.dataSet2;
            // 
            // materials_s_import_TableAdapter1
            // 
            this.materials_s_import_TableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // materialssimportBindingSource4
            // 
            this.materialssimportBindingSource4.DataMember = "materials_s_import$";
            this.materialssimportBindingSource4.DataSource = this.dataSet1BindingSource;
            // 
            // materialssimportBindingSource5
            // 
            this.materialssimportBindingSource5.DataMember = "materials_s_import$";
            this.materialssimportBindingSource5.DataSource = this.dataSet2;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(473, 448);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 571);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1171, 618);
            this.MinimumSize = new System.Drawing.Size(847, 520);
            this.Name = "FrmMaterial";
            this.Text = "FrmMaterial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialssimportBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource materialssimportBindingSource;
        private DataSet1TableAdapters.materials_s_import_TableAdapter materials_s_import_TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource materialssimportBindingSource1;
        private System.Windows.Forms.BindingSource materialssimportBindingSource2;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource materialssimportBindingSource3;
        private DataSet2TableAdapters.materials_s_import_TableAdapter materials_s_import_TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеМатериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоВУпаковкеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальноеКоличествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изображениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типМатериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materialssimportBindingSource6;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource materialssimportBindingSource4;
        private System.Windows.Forms.BindingSource materialssimportBindingSource5;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private System.Windows.Forms.Button button5;
    }
}

