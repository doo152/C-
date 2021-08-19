using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_ListType
{
    public partial class FrmDgvList : Form
    {

        private List<Student> studentsList = null;
        public FrmDgvList()
        {
            InitializeComponent();
            initForm();
        }
        // initial data
        public void initForm()
        {

            #region Instance definition for a List
            Student student1 = new Student("10003", "Ken", 1, "M", 80);
            Student student2 = new Student("10002", "John", 23, "M", 87);
            Student student3 = new Student("10001", "Peter", 32, "M", 89);
            Student student4 = new Student("10005", "Adlie", 25, "M", 86);
            Student student5 = new Student("10004", "Matt", 28, "M", 85);
            Student student6 = new Student { StudentId = "10006", StudentName = "Mary", StudentAge = 23, StudentGender = "F", StudentScore = 90 };
            studentsList = new List<Student>()
            {
                student1, student2, student3, student4, student5, student6
            };
            #endregion
            
        }

        private void dgvDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmDgvList_Load(object sender, EventArgs e)
        {

        }
        // load data to datagridview
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            this.dgvDataView.DataSource = studentsList;
            // Auto Adjust Columns' width
            this.dgvDataView.AutoResizeColumns();
        }

        // Sort data by students' score and descent order
        private void btnSortDesc_Click(object sender, EventArgs e)
        {
             studentsList.Sort(new studentScoreDesc());
            // Force data to refresh after button clicked
            this.dgvDataView.Refresh();
        }
        // Sort data by students' id and ascent order
        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            studentsList.Sort(new studentIdAsc());
            this.dgvDataView.Refresh();
        }
    }
}
