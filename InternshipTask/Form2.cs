using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternshipTask
{
    
    public partial class Form2 : Form
    {
        public class Department
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            public Nullable<Guid> ParentDepartmentId { get; set; }
        }

        

        public class empoyee
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public decimal ID { get; set; }
            public Guid DepartmentID { get; set; }
            public string FirstName { get; set; }
            public string SurName { get; set; }
            public string Patronymic { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string DocSeries { get; set; }
            public string DocNumber { get; set; }
            public string Position { get; set; }
        }
        public class TestDBContext : DbContext
        {

            public TestDBContext()

            : base("TestDB")
            { }

            public DbSet<Department> Departments { get; set; }
            public DbSet<empoyee> Employees { get; set; }
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {

                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }

        public Form2()
        {
            InitializeComponent();
        }



      
        

        private void Form2_Load(object sender, EventArgs e)
            {


            this.Text = "Рога и копыта";
            ToolStripMenuItem showStaff = new ToolStripMenuItem("Посмотреть сотрудников выбранного отдела");
            ToolStripMenuItem addEmployee = new ToolStripMenuItem("Добавить сотрудника");
            contextMenuStrip1.Items.AddRange(new[] { showStaff, addEmployee });
            addEmployee.Click += addEmployee_click;
            showStaff.Click += showStaff_Click;
            Database.SetInitializer<TestDBContext>(null);
                using (TestDBContext db = new TestDBContext())
                {
                    var deps = from dep in db.Departments where dep.ParentDepartmentId == null select dep;

                    foreach (Department dep in deps)
                    {

                        struct_Department.Nodes.Add(dep.Name);
                        
                        int k = struct_Department.Nodes.Count - 1;
                    struct_Department.Nodes[k].Tag = dep.Id;
                    

                    getTree(struct_Department.Nodes[k], dep);



                    }

                   



                }



            }
            private void getTree(TreeNode Node, Department depr)
            {


                using (TestDBContext db = new TestDBContext())
                {
                    var deps = from dep in db.Departments where dep.ParentDepartmentId==depr.Id  select dep;
                    foreach (Department dep in deps)
                    {
                        Node.Nodes.Add(dep.Name);
                        int k = Node.Nodes.Count - 1;
                    Node.Nodes[k].Tag = dep.Id;
                        getTree(Node.Nodes[k], dep);
                    }
                }

            }
        

       

        public TreeNode Node_Department;
        void addEmployee_click(object sender, EventArgs e)
        {
            if (Node_Department != null)
            {
                Employee em = new Employee();
                em.Show();
                em.newEmployee(Node_Department.Text);
            }
            
        }
        void showStaff_Click(object sender, EventArgs e)
        {
            ShowEmployee shE = new ShowEmployee();
            
            shE.Show();
            shE.showEmpl(Node_Department);
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {


                TreeNode node = struct_Department.GetNodeAt(e.Location);
                
               
               node.ContextMenuStrip = contextMenuStrip1;
                Node_Department=node;
                //ToolStripMenuItem x = sender as ToolStripMenuItem;
                

            }

        }
        

      
    }
}
