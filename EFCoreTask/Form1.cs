using TodoDomain;
using System.Windows.Forms;
using ToDoListData;
using Microsoft.EntityFrameworkCore;
//using System.Runtime.InteropServices;
//using ToDoListData;


namespace EFCoreTask
{
    public partial class Form1 : Form
    {
        private tmDBContext TmDBContext;
        public Form1()
        {
            InitializeComponent();
            TmDBContext = new tmDBContext();

            var statuses = TmDBContext.StatusTable.ToList();
            foreach (var status in statuses)
            {
                cboStatus.Items.Add(status);
            }
            RefreshDataAsync();
        }

        private async Task RefreshDataAsync()
        {
            BindingSource bindingSource = new BindingSource();

            var query = from t in TmDBContext.Tasks
                        orderby t.DueDate
                        select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };
            bindingSource.DataSource = await query.ToListAsync();
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Refresh();
            //throw new NotImplementedException();
        }

        private async void cmdCreateTask_Click(object sender, EventArgs e)
        {
            if (cboStatus.SelectedItem != null && txtTask.Text != String.Empty)
            {
                var newTask = new TodoDomain.Tasks
                {
                    Name = txtTask.Text,
                    StatusId = (cboStatus.SelectedItem as TodoDomain.Status).Id,
                    DueDate = dateTimePicker1.Value
                };

                await TmDBContext.Tasks.AddAsync(newTask);
                await TmDBContext.SaveChangesAsync();
                RefreshDataAsync();
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("Please, enter the required data");
            }

        }

        private async void cmdUpdateTask_Click(object sender, EventArgs e)
        {
            if (cmdUpdateTask.Text == "Update")
            {
                txtTask.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedCells[3].Value;

                foreach (Status s in cboStatus.Items)
                {
                    if (s.Name == dataGridView1.SelectedCells[2].Value.ToString())
                    {
                        cboStatus.SelectedItem = s;
                    }
                }
                cmdUpdateTask.Text = "Save";
            }
            else if (cmdUpdateTask.Text == "Save")
            {
                var t = TmDBContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);
                t.Name = txtTask.Text;
                t.StatusId = (cboStatus.SelectedItem as Status).Id;
                t.DueDate = dateTimePicker1.Value;

                await TmDBContext.SaveChangesAsync();

                RefreshDataAsync();
                cmdUpdateTask.Text = "Update";
                txtTask.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                cboStatus.Text = "Please Select....";
            }

        }

        private async void cmdDeleteTask_Click(object sender, EventArgs e)
        {
            var taskId = (int)dataGridView1.SelectedCells[0].Value;
            var task = await TmDBContext.Tasks.FindAsync(taskId);

            if (task != null)
            {
                TmDBContext.Tasks.Remove(task);
                MessageBox.Show("Are Sure you  want to delete?");
                await TmDBContext.SaveChangesAsync();
                await RefreshDataAsync();
            }
            else
            {
                MessageBox.Show("Task not found.");
            }



            //var task = TmDBContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);
            //TmDBContext.Tasks.Remove(task);
            //MessageBox.Show("Are Sure you  want  to delete");
            //TmDBContext.SaveChanges();
            //refreshData();
        }

        private async void cmdCancelTask_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                cmdUpdateTask.Invoke((Action)(() => { cmdUpdateTask.Text = "Update"; }));
                txtTask.Invoke((Action)(() => { txtTask.Text = string.Empty; }));
                dateTimePicker1.Invoke((Action)(() => { dateTimePicker1.Value = DateTime.Now; }));
                cboStatus.Invoke((Action)(() => { cboStatus.Text = "Please Select..."; }));
            });


            //cmdUpdateTask.Text = "Update";
            //txtTask.Text = string.Empty;
            //dateTimePicker1.Value = DateTime.Now;
            //cboStatus.Text = "Please Select....";
        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async Task SearchAsync(string taskName)
        {
            BindingSource bindingSource = new BindingSource();

            try
            {
                var query = from t in TmDBContext.Tasks
                            where t.Name.Contains(taskName)
                            orderby t.DueDate
                            select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };
                bindingSource.DataSource = await query.ToListAsync();
                dataGridView1.DataSource = bindingSource;
                dataGridView1.Refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void texSearch_TextChanged(object sender, EventArgs e)
        {
            string taskName = texSearch.Text;
            await SearchAsync(taskName);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}