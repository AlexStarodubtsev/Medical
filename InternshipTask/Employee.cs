using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections;
using static InternshipTask.Form2;
using static InternshipTask.ShowEmployee;

namespace InternshipTask
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Database.SetInitializer<TestDBContext>(null);
            using (TestDBContext db = new TestDBContext())
            {
                var Data = db.Departments;
                foreach(Department dep in Data)
                {
                    comboBox1.Items.Add(dep.Name);
                    
                    
                }
            }

        }
        public void newEmployee(string dep)
        {
            button1.Visible = false;
            button2.Visible = true;
            comboBox1.Text = dep;
            label1.Text = dep;
            label3.Visible = false;
        }
        public empoyee global_man;
        
        public void LoadEmployee(ListViewItem empl)
        {
            label1.Text = empl.Text;
            Guid Did = new Guid();
            Database.SetInitializer<TestDBContext>(null);
            using (TestDBContext db = new TestDBContext())
            {
                var Data = db.Employees;
                foreach(empoyee man in Data)
                    {

                    if (empl.Tag.Equals(man.ID))
                    {
                        global_man = man;

                        Did = man.DepartmentID;
                        label1.Text = man.FirstName + " " + man.Patronymic + " " + man.SurName;
                        textBox1.Text = man.FirstName;
                        textBox2.Text = man.Patronymic;
                        textBox3.Text = man.SurName;
                        textBox5.Text = man.Position;
                        dateTimePicker1.Value = man.DateOfBirth;
                        textBox7.Text = man.DocSeries;
                        textBox8.Text = man.DocNumber;
                        
                        TimeSpan ts = DateTime.Now.Subtract(man.DateOfBirth);
                        DateTime zeroTime = new DateTime(1, 1, 1);
                        int Age = (zeroTime + ts).Year - 1;
                        string suff = "";
                        if (Age % 10 == 1 && Age % 100 != 11)
                        {
                            suff = " год";
                        }

                        else
                        {
                            if ((Age % 10 == 2 || Age % 10 == 3 || Age % 10 == 4) && (Age % 100) / 10 != 1)
                            {
                                suff = " года";
                            }
                            else suff = " лет";
                        }
                        label3.Text = Convert.ToString(Age) + suff;
                    }

                }
                var Depart = from dep in db.Departments where dep.Id == Did select dep;
                foreach (Department dep in Depart)
                {
                    comboBox1.Text = dep.Name;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        ShowEmployee showEmployee1 = new ShowEmployee();
        public void getShow(ShowEmployee sh)
        {
            showEmployee1 = sh;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i =0; i<comboBox1.Items.Count; i++)
            {
                if (comboBox1.Items[i].ToString() == comboBox1.Text)

                {
                    flag = true;
                    break;
                }
            }
            if (!flag)

                MessageBox.Show("Ошибка! Такого отдела не существует");
            else
            {
                Database.SetInitializer<TestDBContext>(null);
                using (TestDBContext db = new TestDBContext())
                {
                    Guid Did = db.Departments.Where(c => c.Name == comboBox1.Text).First().Id;
                    var man = db.Employees.Where(c => c.ID == global_man.ID).First();
                    man.FirstName = textBox1.Text;
                   
                    man.Patronymic = textBox2.Text;
                    man.SurName = textBox3.Text;
                    man.Position = textBox5.Text;
                    man.DateOfBirth = dateTimePicker1.Value;
                    man.DocSeries = textBox7.Text;
                    man.DocNumber = textBox8.Text;
                    man.DepartmentID = Did;
                    db.SaveChanges();
                    showEmployee1.updateList(man, comboBox1.Text);
                    
                }
                
                if (MessageBox.Show("Данные сохранены") == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            bool flag = false;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Items[i].ToString() == comboBox1.Text)

                {
                    flag = true;
                    break;
                }
            }
            if (!flag)

                MessageBox.Show("Ошибка! Такого отдела не существует");
            else
            {
                Database.SetInitializer<TestDBContext>(null);
                using (TestDBContext db = new TestDBContext())
                {
                    Guid Did = db.Departments.Where(c => c.Name == comboBox1.Text).First().Id;
                    empoyee man = new empoyee();
                    man.FirstName = textBox1.Text;

                    decimal id = db.Employees.Max(c => c.ID);
                    man.ID = id + 1;
                    man.Patronymic = textBox2.Text;
                    man.SurName = textBox3.Text;
                    man.Position = textBox5.Text;
                    man.DateOfBirth = dateTimePicker1.Value;
                    man.DocSeries = textBox7.Text;
                    man.DocNumber = textBox8.Text;
                    man.DepartmentID = Did;
                    
                    db.Employees.Add(man);
                    showEmployee1.getNewList(man, comboBox1.Text);

                    db.SaveChanges();
                    
                }
                
                if (MessageBox.Show("Новый сотрудник успешно добавлен") == DialogResult.OK)
                {
                    this.Close();
                }
            }
            
            
        }
    }
}
