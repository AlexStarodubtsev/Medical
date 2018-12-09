namespace InternshipTask
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label_show_Employee_form = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.SurName = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.Label();
            this.DepartMent = new System.Windows.Forms.Label();
            this.Series = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_patronymic = new System.Windows.Forms.TextBox();
            this.textbox_SurName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_position = new System.Windows.Forms.TextBox();
            this.textBox_DocSeries = new System.Windows.Forms.TextBox();
            this.textBox_DocNumber = new System.Windows.Forms.TextBox();
            this.label_Age = new System.Windows.Forms.Label();
            this.comboBox_departments = new System.Windows.Forms.ComboBox();
            this.button_updateEmployee = new System.Windows.Forms.Button();
            this.dateTime_birhday = new System.Windows.Forms.DateTimePicker();
            this.button_addEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_show_Employee_form
            // 
            this.label_show_Employee_form.AutoSize = true;
            this.label_show_Employee_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_show_Employee_form.Location = new System.Drawing.Point(130, 9);
            this.label_show_Employee_form.Name = "label_show_Employee_form";
            this.label_show_Employee_form.Size = new System.Drawing.Size(59, 20);
            this.label_show_Employee_form.TabIndex = 0;
            this.label_show_Employee_form.Text = "label1";
            this.label_show_Employee_form.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(29, 41);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(39, 17);
            this.LName.TabIndex = 1;
            this.LName.Text = "Имя:";
            // 
            // SurName
            // 
            this.SurName.AutoSize = true;
            this.SurName.Location = new System.Drawing.Point(29, 112);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(74, 17);
            this.SurName.TabIndex = 2;
            this.SurName.Text = "Фамилия:";
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Location = new System.Drawing.Point(29, 78);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(75, 17);
            this.Patronymic.TabIndex = 3;
            this.Patronymic.Text = "Отчество:";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(29, 191);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(81, 17);
            this.Position.TabIndex = 4;
            this.Position.Text = "Должность";
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Location = new System.Drawing.Point(29, 229);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(115, 17);
            this.BirthDay.TabIndex = 5;
            this.BirthDay.Text = "Дата рождения:";
            // 
            // DepartMent
            // 
            this.DepartMent.AutoSize = true;
            this.DepartMent.Location = new System.Drawing.Point(29, 149);
            this.DepartMent.Name = "DepartMent";
            this.DepartMent.Size = new System.Drawing.Size(54, 17);
            this.DepartMent.TabIndex = 6;
            this.DepartMent.Text = "Отдел:";
            // 
            // Series
            // 
            this.Series.AutoSize = true;
            this.Series.Location = new System.Drawing.Point(31, 297);
            this.Series.Name = "Series";
            this.Series.Size = new System.Drawing.Size(53, 17);
            this.Series.TabIndex = 7;
            this.Series.Text = "Серия:";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(29, 338);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(55, 17);
            this.Number.TabIndex = 8;
            this.Number.Text = "Номер:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(168, 41);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(303, 22);
            this.textBox_Name.TabIndex = 9;
            this.textBox_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Name_Patronymic);
            // 
            // textBox_patronymic
            // 
            this.textBox_patronymic.Location = new System.Drawing.Point(168, 78);
            this.textBox_patronymic.Name = "textBox_patronymic";
            this.textBox_patronymic.Size = new System.Drawing.Size(303, 22);
            this.textBox_patronymic.TabIndex = 10;
            this.textBox_patronymic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Patronymic);
            // 
            // textbox_SurName
            // 
            this.textbox_SurName.Location = new System.Drawing.Point(168, 112);
            this.textbox_SurName.Name = "textbox_SurName";
            this.textbox_SurName.Size = new System.Drawing.Size(303, 22);
            this.textbox_SurName.TabIndex = 11;
            this.textbox_SurName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_SurName);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Документ";
            // 
            // textBox_position
            // 
            this.textBox_position.Location = new System.Drawing.Point(168, 188);
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(303, 22);
            this.textBox_position.TabIndex = 14;
            this.textBox_position.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_position);
            // 
            // textBox_DocSeries
            // 
            this.textBox_DocSeries.Location = new System.Drawing.Point(119, 297);
            this.textBox_DocSeries.Name = "textBox_DocSeries";
            this.textBox_DocSeries.Size = new System.Drawing.Size(108, 22);
            this.textBox_DocSeries.TabIndex = 16;
            this.textBox_DocSeries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Series);
            // 
            // textBox_DocNumber
            // 
            this.textBox_DocNumber.Location = new System.Drawing.Point(119, 335);
            this.textBox_DocNumber.Name = "textBox_DocNumber";
            this.textBox_DocNumber.Size = new System.Drawing.Size(108, 22);
            this.textBox_DocNumber.TabIndex = 17;
            this.textBox_DocNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_number);
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Location = new System.Drawing.Point(588, 12);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(46, 17);
            this.label_Age.TabIndex = 18;
            this.label_Age.Text = "label3";
            // 
            // comboBox_departments
            // 
            this.comboBox_departments.FormattingEnabled = true;
            this.comboBox_departments.Location = new System.Drawing.Point(168, 146);
            this.comboBox_departments.Name = "comboBox_departments";
            this.comboBox_departments.Size = new System.Drawing.Size(303, 24);
            this.comboBox_departments.TabIndex = 19;
            this.comboBox_departments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Department);
            // 
            // button_updateEmployee
            // 
            this.button_updateEmployee.Location = new System.Drawing.Point(459, 376);
            this.button_updateEmployee.Name = "button_updateEmployee";
            this.button_updateEmployee.Size = new System.Drawing.Size(98, 29);
            this.button_updateEmployee.TabIndex = 20;
            this.button_updateEmployee.Text = "Сохранить";
            this.button_updateEmployee.UseVisualStyleBackColor = true;
            this.button_updateEmployee.Click += new System.EventHandler(this.updateEmployee_click);
            // 
            // dateTime_birhday
            // 
            this.dateTime_birhday.Location = new System.Drawing.Point(168, 229);
            this.dateTime_birhday.Name = "dateTime_birhday";
            this.dateTime_birhday.Size = new System.Drawing.Size(303, 22);
            this.dateTime_birhday.TabIndex = 21;
            this.dateTime_birhday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_birthday);
            // 
            // button_addEmployee
            // 
            this.button_addEmployee.Location = new System.Drawing.Point(459, 376);
            this.button_addEmployee.Name = "button_addEmployee";
            this.button_addEmployee.Size = new System.Drawing.Size(98, 29);
            this.button_addEmployee.TabIndex = 22;
            this.button_addEmployee.Text = "Добавить";
            this.button_addEmployee.UseVisualStyleBackColor = true;
            this.button_addEmployee.Visible = false;
            this.button_addEmployee.Click += new System.EventHandler(this.addEmployee_click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.button_addEmployee);
            this.Controls.Add(this.dateTime_birhday);
            this.Controls.Add(this.button_updateEmployee);
            this.Controls.Add(this.comboBox_departments);
            this.Controls.Add(this.label_Age);
            this.Controls.Add(this.textBox_DocNumber);
            this.Controls.Add(this.textBox_DocSeries);
            this.Controls.Add(this.textBox_position);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_SurName);
            this.Controls.Add(this.textBox_patronymic);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Series);
            this.Controls.Add(this.DepartMent);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.SurName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.label_show_Employee_form);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_show_Employee_form;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label SurName;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label BirthDay;
        private System.Windows.Forms.Label DepartMent;
        private System.Windows.Forms.Label Series;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_patronymic;
        private System.Windows.Forms.TextBox textbox_SurName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_position;
        private System.Windows.Forms.TextBox textBox_DocSeries;
        private System.Windows.Forms.TextBox textBox_DocNumber;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.ComboBox comboBox_departments;
        private System.Windows.Forms.Button button_updateEmployee;
        private System.Windows.Forms.DateTimePicker dateTime_birhday;
        private System.Windows.Forms.Button button_addEmployee;
    }
}