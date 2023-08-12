using WinFormsApp1.Models;
using WinFormsApp1.Repository;

namespace WinFormsApp1
{
    public partial class UserForm : Form
    {
        private readonly IStudentRepository _studentRepo;

        public UserForm()
        {
            InitializeComponent();
            _studentRepo = new StudentRespository(new DataContext());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DataContext _context = new DataContext())
            {
                StudentDGV.DataSource = _studentRepo.GetAllStudent();
                //StudentDGV.DataSource = _context.Students.ToList();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            _studentRepo.AddStudent(StudentNameTxt.Text);
            StudentDGV.DataSource = _studentRepo.GetAllStudent();
        }
    }
}
