
namespace WindowsFormsAppMod
{
    partial class главное 
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
            this.каталогBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._44П_ПМ_01_ЗуевDataSet2 = new WindowsFormsAppMod._44П_ПМ_01_ЗуевDataSet2();
            this.каталогBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._44П_ПМ_01_ЗуевDataSet = new WindowsFormsAppMod._44П_ПМ_01_ЗуевDataSet();
            this.каталогTableAdapter = new WindowsFormsAppMod._44П_ПМ_01_ЗуевDataSetTableAdapters.КаталогTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.каталогBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.каталогTableAdapter1 = new WindowsFormsAppMod._44П_ПМ_01_ЗуевDataSet2TableAdapters.КаталогTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_ПМ_01_ЗуевDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_ПМ_01_ЗуевDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(941, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // каталогBindingSource2
            // 
            this.каталогBindingSource2.DataMember = "Каталог";
            this.каталогBindingSource2.DataSource = this._44П_ПМ_01_ЗуевDataSet2;
            // 
            // _44П_ПМ_01_ЗуевDataSet2
            // 
            this._44П_ПМ_01_ЗуевDataSet2.DataSetName = "_44П_ПМ_01_ЗуевDataSet2";
            this._44П_ПМ_01_ЗуевDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталогBindingSource
            // 
            this.каталогBindingSource.DataMember = "Каталог";
            this.каталогBindingSource.DataSource = this._44П_ПМ_01_ЗуевDataSet;
            // 
            // _44П_ПМ_01_ЗуевDataSet
            // 
            this._44П_ПМ_01_ЗуевDataSet.DataSetName = "_44П_ПМ_01_ЗуевDataSet";
            this._44П_ПМ_01_ЗуевDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталогTableAdapter
            // 
            this.каталогTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Корзина";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить в корзину";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество выбранных книг:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стоиость покупки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Разр скидки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            // 
            // каталогBindingSource1
            // 
            this.каталогBindingSource1.DataMember = "Каталог";
            this.каталогBindingSource1.DataSource = this._44П_ПМ_01_ЗуевDataSet;
            // 
            // каталогTableAdapter1
            // 
            this.каталогTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 60);
            this.button3.TabIndex = 11;
            this.button3.Text = "Очистить корзину";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // главное
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 616);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "главное";
            this.Text = "Главноe окно";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_ПМ_01_ЗуевDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._44П_ПМ_01_ЗуевDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _44П_ПМ_01_ЗуевDataSet _44П_ПМ_01_ЗуевDataSet;
        private System.Windows.Forms.BindingSource каталогBindingSource;
        private _44П_ПМ_01_ЗуевDataSetTableAdapters.КаталогTableAdapter каталогTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource каталогBindingSource1;
        private _44П_ПМ_01_ЗуевDataSet2 _44П_ПМ_01_ЗуевDataSet2;
        private System.Windows.Forms.BindingSource каталогBindingSource2;
        private _44П_ПМ_01_ЗуевDataSet2TableAdapters.КаталогTableAdapter каталогTableAdapter1;
        private System.Windows.Forms.Button button3;
    }
}

