using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class frmStudentManagement : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        private Student currentStudent;
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.cmbFaculty.DataSource = listFacultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.StudentName;
                if (item.Faculty != null)
                    dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore.ToString();
                if (item.Major != null)
                    dgvStudent.Rows[index].Cells[4].Value = item.Major.MajorName;
                //ShowAvatar(item.Avatar);
            }
        }
        private void ShowAvatar(string ImageName)
        {
            if (string.IsNullOrEmpty(ImageName))
            {
                picAvatarSet.Image = null;
            }
            else
            {
                // Get the image path
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", ImageName);
                if (File.Exists(imagePath))
                {
                    picAvatarSet.Image = System.Drawing.Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show($"File không tồn tại: {imagePath}");
                    picAvatarSet.Image = null;
                }

                picAvatarSet.Refresh();
            }
        }

        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvStudent);
            var listFacultys = facultyService.GetAll();
            var listStudents = studentService.GetAll();
            FillFalcultyCombobox(listFacultys);

            // Ensure the Images directory exists
            string imageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            if (!Directory.Exists(imageFolderPath))
            {
                Directory.CreateDirectory(imageFolderPath);
            }

            BindGrid(listStudents);

        }
        private void ResetInputFields()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
            cmbFaculty.SelectedIndex = -1;
            picAvatarSet.Image = null; // Clear the image
            currentStudent = null;
        }

        private bool ValidateInput()
        {

            bool valid = true;
            err.Clear();
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtAverageScore.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }

            if (txtStudentID.Text.Length != 10 || !txtStudentID.Text.All(char.IsDigit))
            {
                err.SetError(txtStudentID, "Mã số sinh viên không hợp lệ.");
                valid = false;
            }

            if (!decimal.TryParse(txtAverageScore.Text, out decimal avgScore) || avgScore < 0 || avgScore > 10)
            {
                err.SetError(txtAverageScore, "Điểm trung bình sinh viên không hợp lệ.");
                valid = false;
            }

            if (txtFullName.Text.Length < 3 || txtFullName.Text.Length > 100 ||
                !txtFullName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                err.SetError(txtFullName, "Tên sinh viên không hợp lệ.");
                valid = false;
            }

            return valid;
        }
        private void UpdateStudentList()
        {
            try
            {
                var listFalcultys = facultyService.GetAll(); // Get faculties
                var listStudent = studentService.GetAll(); // Get students
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (!ValidateInput()) return;

            // Check if the student already exists
            bool exists = dgvStudent.Rows.Cast<DataGridViewRow>()
                                          .Any(r => r.Cells[0].Value.ToString() == txtStudentID.Text);

            if (!exists)
            {
                try
                {
                    // Create new student object
                    Student newStudent = new Student
                    {
                        StudentID = txtStudentID.Text,
                        StudentName = txtFullName.Text,
                        FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                        AverageScore = double.Parse(txtAverageScore.Text),
                        Avatar = $"{txtStudentID.Text}.jpg" // Assuming jpg as the default format
                    };

                    // Add new student to the database
                    studentService.AddStudent(newStudent);
                    UpdateStudentList();

                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại.");
            }
            ResetInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (!ValidateInput()) return;

            try
            {
                var student = studentService.GetStudentById(txtStudentID.Text); // Get student by ID
                if (student != null)
                {
                    // Update student info
                    student.StudentName = txtFullName.Text;
                    student.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                    student.AverageScore = double.Parse(txtAverageScore.Text);
                    if (picAvatarSet.Image != null)
                    {
                        // Save the avatar to the server and get the filename
                        string fileName = $"{student.StudentID}.png"; // Change this if your format is different
                        string filePath = Path.Combine("Images", fileName);
                        picAvatarSet.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                        student.Avatar = fileName; // Set the avatar property to the filename
                    }

                    studentService.UpdateStudent(student); // Update student in database

                    UpdateStudentList();

                    MessageBox.Show("Sửa dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ResetInputFields();
            txtStudentID.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                // Load data from DataGridView to input fields
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtFullName.Text = row.Cells[1].Value.ToString();
                cmbFaculty.Text = row.Cells[2].Value.ToString();
                txtAverageScore.Text = row.Cells[3].Value.ToString();

                // Load avatar
                currentStudent = studentService.GetStudentById(txtStudentID.Text); // Load current student
                ShowAvatar(currentStudent?.Avatar); // Show the avatar
            }
            txtStudentID.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var student = studentService.GetStudentById(txtStudentID.Text);
                    if (student != null)
                    {
                        studentService.DeleteStudent(txtStudentID.Text); // Delete student from database

                        // Optionally, delete the student's avatar image if it exists
                        string avatarPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", $"{student.StudentID}.jpg");
                        if (File.Exists(avatarPath))
                        {
                            File.Delete(avatarPath); // Remove avatar image
                        }

                        UpdateStudentList();
                        MessageBox.Show("Xóa dữ liệu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            txtStudentID.Enabled = true;
            btnAdd.Enabled = true;
            ResetInputFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                         "Xác nhận thoát",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAverageScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Ngăn chặn nhập ký tự không hợp lệ
            }

            // Ngăn chặn nhập nhiều dấu thập phân
            if (e.KeyChar == '.' && txtAverageScore.Text.Contains("."))
            {
                e.Handled = true; // Ngăn chặn thêm dấu thập phân nếu đã có
            }
        }

        
        private void btnAvatarSet_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh đại diện";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    string destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", $"{txtStudentID.Text}.jpg");

                    // Copy the image to the Images folder
                    File.Copy(filePath, destinationPath, true);

                    // Load the image into the PictureBox
                    picAvatarSet.Image = System.Drawing.Image.FromFile(destinationPath);
                }
            }
        }

        private void chkMajor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                List<Student> listStudent = studentService.GetAll();

                // Filter based on checkbox status
                if (chkMajor.Checked)
                {
                    listStudent = listStudent.Where(s => s.MajorID == null || s.MajorID == 0).ToList(); // Assuming 0 or null indicates no major
                }

                FillFalcultyCombobox(facultyService.GetAll());
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
