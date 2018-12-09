namespace InternshipTask
{
    partial class ShowEmployee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEmployee));
            this.listView1 = new System.Windows.Forms.ListView();
            this.departName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_Add_Employee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(56, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(681, 337);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getMenu);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OpenEmployee);
            // 
            // departName
            // 
            this.departName.AutoSize = true;
            this.departName.Font = new System.Drawing.Font("Microsoft Himalaya", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departName.Location = new System.Drawing.Point(101, 20);
            this.departName.Name = "departName";
            this.departName.Size = new System.Drawing.Size(54, 19);
            this.departName.TabIndex = 1;
            this.departName.Text = "label1";
            this.departName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_Add_Employee
            // 
            this.button_Add_Employee.Location = new System.Drawing.Point(610, 12);
            this.button_Add_Employee.Name = "button_Add_Employee";
            this.button_Add_Employee.Size = new System.Drawing.Size(106, 51);
            this.button_Add_Employee.TabIndex = 3;
            this.button_Add_Employee.Text = "Добавить сотрудника";
            this.button_Add_Employee.UseVisualStyleBackColor = true;
            this.button_Add_Employee.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Add_Employee);
            this.Controls.Add(this.departName);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowEmployee";
            this.Text = "ShowEmployee";
            this.Load += new System.EventHandler(this.ShowEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label departName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_Add_Employee;
    }
}