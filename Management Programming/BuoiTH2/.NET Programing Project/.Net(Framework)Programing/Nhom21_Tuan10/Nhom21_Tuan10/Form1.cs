using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nhom21_Tuan10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
// CẤP DATA
        DataSet ds = new DataSet();
        SqlDataAdapter daHS;
        SqlDataAdapter daQQ;

// TRUYỀN DATA VÀO FORM
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True");
            string sQueryHS = @"select * from hocsinh";
            daHS = new SqlDataAdapter(sQueryHS,con);
            daHS.Fill(ds, "tblHS");
            cbQueQuan.DataSource = ds.Tables["tblHS"];

            cbQueQuan.DisplayMember = "tenqq";
            cbQueQuan.ValueMember = "tenqq";
            dgvDSHS.DataSource = ds.Tables["tblHS"];
            dgvDSHS.Columns["mahs"].HeaderText = "Mã Học Sinh";
            dgvDSHS.Columns["holot"].HeaderText = "Họ Lót";
            dgvDSHS.Columns["tenhs"].HeaderText = "Tên Học Sinh";
            dgvDSHS.Columns["phai"].HeaderText = "Phái";
            dgvDSHS.Columns["ngaysinh"].HeaderText = "Ngày Sinh";           
            dgvDSHS.Columns["tenqq"].HeaderText = "Tên Quê Quán";

            //cmdINSERT
            string strAddStudent = "insert into hocsinh values(@MaHS, @HoLot, @TenHS, @Phai, @NgaySinh, @TenQQ)";
            SqlCommand cmdAddStudent = new SqlCommand(strAddStudent,con);
            cmdAddStudent.Parameters.Clear();
            cmdAddStudent.Parameters.Add("@MaHS", SqlDbType.NVarChar, 50, "mahs");
            cmdAddStudent.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmdAddStudent.Parameters.Add("@TenHS", SqlDbType.NVarChar, 50, "tenhs");
            cmdAddStudent.Parameters.Add("@Phai", SqlDbType.NVarChar, 50, "phai");
            cmdAddStudent.Parameters.Add("@NgaySinh", SqlDbType.Date, 50, "ngaysinh");
            cmdAddStudent.Parameters.Add("@TenQQ", SqlDbType.NVarChar, 50, "tenqq");
            daHS.InsertCommand = cmdAddStudent;

            //cmdDELETE
            string strDeleteStudent = "delete from hocsinh where tenqq = @TenQQ";
            SqlCommand cmdDeleteStudent = new SqlCommand(strDeleteStudent,con);
            cmdDeleteStudent.Parameters.Clear();
            cmdDeleteStudent.Parameters.Add("@MaHS", SqlDbType.NVarChar, 50, "mahs");
            cmdDeleteStudent.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmdDeleteStudent.Parameters.Add("@TenHS", SqlDbType.NVarChar, 50, "tenhs");
            cmdDeleteStudent.Parameters.Add("@Phai", SqlDbType.NVarChar, 50, "phai");
            cmdDeleteStudent.Parameters.Add("@NgaySinh", SqlDbType.Date, 50, "ngaysinh");
            cmdDeleteStudent.Parameters.Add("@TenQQ", SqlDbType.NVarChar, 50, "tenqq");
            daHS.DeleteCommand = cmdDeleteStudent;

            //cmdUPDATE
            string strUpdateStudent = "update hocsinh set mahs = @MaHS, holot = @HoLot,tenhs = @TenHS, phai = @Phai, ngaysinh = @NgaySinh where tenqq = @TenQQ";
            SqlCommand cmdUpdateStudent = new SqlCommand(strUpdateStudent, con);
            cmdUpdateStudent.Parameters.Add("@MaHS", SqlDbType.NVarChar, 50, "mahs");
            cmdUpdateStudent.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmdUpdateStudent.Parameters.Add("@TenHS", SqlDbType.NVarChar, 50, "tenhs");
            cmdUpdateStudent.Parameters.Add("@Phai", SqlDbType.NVarChar, 50, "phai");
            cmdUpdateStudent.Parameters.Add("@NgaySinh", SqlDbType.Date, 50, "ngaysinh");           
            cmdUpdateStudent.Parameters.Add("@TenQQ", SqlDbType.NVarChar, 50, "tenqq");
            daHS.UpdateCommand = cmdUpdateStudent;
        }

//CHỌN VÙNG TRONG DATAGRIDVIEW HIỆN THỊ CÁC THÔNG TIN TRÊN TEXTBOX
        private void dgvDSHS_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvDSHS.SelectedRows[0];
            txtMaSo.Text = dgvr.Cells["mahs"].Value.ToString();
            txtHoLot.Text = dgvr.Cells["holot"].Value.ToString();
            txtTen.Text = dgvr.Cells["tenhs"].Value.ToString();
            dateNgaySinh.Text = dgvr.Cells["ngaysinh"].Value.ToString();
            if (dgvr.Cells["phai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else if (dgvr.Cells["phai"].Value.ToString() == "Nữ")
            {
                radNu.Checked = true;
            }
            else
            {
                radNu.Checked = false;
                radNam.Checked = false;
            }               
            cbQueQuan.Text = dgvr.Cells["tenqq"].Value.ToString();
        }

//BUTTON ADD

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["tblHS"].NewRow();
            dr["mahs"] = txtMaSo.Text;
            dr["holot"] = txtHoLot.Text;
            dr["tenhs"] = txtTen.Text;
            if (radNam.Checked == true)
            {
                dr["phai"] = "Nam";
            }
            else if(radNu.Checked == true)
            {
                dr["phai"] = "Nữ";
            }
            else
            {
                dr["phai"] = "";
            }
            dr["ngaysinh"] = dateNgaySinh.Text;
            dr["tenqq"] = cbQueQuan.Text;
            ds.Tables["tblHS"].Rows.Add(dr);           
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

//BUTTON SỬA

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvDSHS.SelectedRows[0];
            dgvDSHS.BeginEdit(true);
            dgvr.Cells["mahs"].Value = txtMaSo.Text;
            dgvr.Cells["holot"].Value = txtHoLot.Text;
            dgvr.Cells["tenhs"].Value = txtTen.Text;
            if(radNam.Checked == true)
            {
                dgvr.Cells["phai"].Value = "Nam";
                
            }
            else if(radNu.Checked == true)
            {
                dgvr.Cells["phai"].Value = "Nữ";               
            }
            else
            {
                radNam.Checked = false;
                radNu.Checked = false;
            }           
            dgvr.Cells["ngaysinh"].Value = dateNgaySinh.Text;
            dgvr.Cells["tenqq"].Value = cbQueQuan.Text;
            dgvDSHS.EndEdit();                             
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

//BUTTON XOÁ
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvDSHS.SelectedRows.Count > 0)
            dgvDSHS.Rows.Remove(dgvDSHS.SelectedRows[0]);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                daHS.Update(ds,"tblHS");
                MessageBox.Show("Saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDSHS.Refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error "+ exc.Message, "Notification",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }          
        }
//BUTTON CANCEL
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ds.Tables["tblHS"].RejectChanges();
        }
//BUTTON EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult que;
            que = MessageBox.Show("Exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (que == DialogResult.OK) Application.Exit();
        }

        
    }
}
