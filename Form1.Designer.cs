namespace zachet_1_Shaidullin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.items_box = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_item_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // items_box
            // 
            this.items_box.FormattingEnabled = true;
            this.items_box.Location = new System.Drawing.Point(72, 218);
            this.items_box.Name = "items_box";
            this.items_box.Size = new System.Drawing.Size(675, 147);
            this.items_box.TabIndex = 0;
            this.items_box.SelectedIndexChanged += new System.EventHandler(this.items_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сортировка";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // remove_item_button
            // 
            this.remove_item_button.Enabled = false;
            this.remove_item_button.Location = new System.Drawing.Point(589, 168);
            this.remove_item_button.Name = "remove_item_button";
            this.remove_item_button.Size = new System.Drawing.Size(158, 32);
            this.remove_item_button.TabIndex = 4;
            this.remove_item_button.Text = "Удалить";
            this.remove_item_button.UseVisualStyleBackColor = true;
            this.remove_item_button.Click += new System.EventHandler(this.remove_item_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(606, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Удаление записи";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.ForeColor = System.Drawing.Color.Maroon;
            this.error_label.Location = new System.Drawing.Point(586, 34);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "id",
            "country",
            "hotel title",
            "count",
            "price"});
            this.comboBox1.Location = new System.Drawing.Point(75, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remove_item_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.items_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox items_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_item_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

