using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using static InternshipTask.Form2;


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
                    comboBox_departments.Items.Add(dep.Name);
                    
                    
                }
            }

        }
        public void newEmployee(string dep)
        {
            this.Text = "Новый сотрудник";
            button_updateEmployee.Visible = false;
            button_addEmployee.Visible = true;
            comboBox_departments.Text = dep;
            label_show_Employee_form.Text = dep;
            label_Age.Visible = false;
        }
        public empoyee global_man;
        
        public void LoadEmployee(ListViewItem empl)
        {
            this.Text = "Личные данные";
            label_show_Employee_form.Text = empl.Text;
            Guid Did = new Guid();
            Database.SetInitializer<TestDBContext>(null);
            using (TestDBContext db = new TestDBContext())
            {
                decimal id = Convert.ToDecimal(empl.Tag);
                empoyee man = db.Employees.Where(c=> c.ID==id).First();
                
                    
                        global_man = man;

                        Did = man.DepartmentID;
                        label_show_Employee_form.Text = man.FirstName + " " + man.Patronymic + " " + man.SurName;
                        textBox_Name.Text = man.FirstName;
                        textBox_patronymic.Text = man.Patronymic;
                        textbox_SurName.Text = man.SurName;
                        textBox_position.Text = man.Position;
                        dateTime_birhday.Value = man.DateOfBirth;
                        textBox_DocSeries.Text = man.DocSeries;
                        textBox_DocNumber.Text = man.DocNumber;
                        
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
                        label_Age.Text = Convert.ToString(Age) + suff;
                    

                var Depart = from dep in db.Departments where dep.Id == Did select dep;
                foreach (Department dep in Depart)
                {
                    comboBox_departments.Text = dep.Name;
                }
            }
        }

        

        

        

        
        ShowEmployee showEmployee1 = new ShowEmployee();
        public void getShow(ShowEmployee sh)
        {
            showEmployee1 = sh;
        }
        
        private void updateEmployee_click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < comboBox_departments.Items.Count; i++)
            {
                if (comboBox_departments.Items[i].ToString() == comboBox_departments.Text)

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
                    Guid Did = db.Departments.Where(c => c.Name == comboBox_departments.Text).First().Id;
                    var man = db.Employees.Where(c => c.ID == global_man.ID).First();
                    man.FirstName = textBox_Name.Text;

                    man.Patronymic = textBox_patronymic.Text;
                    man.SurName = textbox_SurName.Text;
                    man.Position = textBox_position.Text;
                    man.DateOfBirth = dateTime_birhday.Value;
                    man.DocSeries = textBox_DocSeries.Text;
                    man.DocNumber = textBox_DocNumber.Text;
                    man.DepartmentID = Did;
                    db.SaveChanges();
                    showEmployee1.updateList(man, comboBox_departments.Text);

                }

                if (MessageBox.Show("Данные сохранены") == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        private void addEmployee_click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < comboBox_departments.Items.Count; i++)
            {
                if (comboBox_departments.Items[i].ToString() == comboBox_departments.Text)

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
                    Guid Did = db.Departments.Where(c => c.Name == comboBox_departments.Text).First().Id;
                    empoyee man = new empoyee();
                    man.FirstName = textBox_Name.Text;

                    decimal id = db.Employees.Max(c => c.ID);
                    man.ID = id + 1;
                    man.Patronymic = textBox_patronymic.Text;
                    man.SurName = textbox_SurName.Text;
                    man.Position = textBox_position.Text;
                    man.DateOfBirth = dateTime_birhday.Value;
                    man.DocSeries = textBox_DocSeries.Text;
                    man.DocNumber = textBox_DocNumber.Text;
                    man.DepartmentID = Did;

                    db.Employees.Add(man);
                    showEmployee1.getNewList(man, comboBox_departments.Text);

                    db.SaveChanges();

                }

                if (MessageBox.Show("Новый сотрудник успешно добавлен") == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void Key_Name_Patronymic(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                textBox_patronymic.Focus();
            }
        }

        private void Key_Patronymic(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                textbox_SurName.Focus();
                
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox_Name.Focus();
                

            }
        }

        private void Key_SurName(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                comboBox_departments.Focus();

            }
            if (e.KeyCode == Keys.Up)
            {
                textBox_patronymic.Focus();


            }
        }

        private void Key_Department(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_position.Focus();

            }
            
        }

        private void key_position(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                dateTime_birhday.Focus();

            }
            if (e.KeyCode == Keys.Up)
            {
                comboBox_departments.Focus();


            }
        }

        private void Key_Series(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                dateTime_birhday.Focus();


            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                textBox_DocNumber.Focus();

            }
        }

        private void Key_birthday(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
               textBox_DocSeries.Focus();

            }
            if (e.KeyCode == Keys.Up)
            {
                textBox_position.Focus();

            }
        }

        private void Key_number(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox_DocSeries.Focus();

            }
        }
    }
}
