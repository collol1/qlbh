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

namespace qlbh
{
    public partial class frmDMSanPham : Form
    {
        private int childFormNumber = 0;

        private string frmDMSanPham_message;


        SqlConnection conn = new SqlConnection("sever=DESKTOP-042JQUM\\SQLEXPRESS; database=qlbh; intergrated security=true");

        public frmDMSanPham()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void sanphamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanphamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlbhDataSet);

        }
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void frmDMSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlbhDataSet.sanpham' table. You can move, or remove it, as needed.
            this.sanphamTableAdapter.Fill(this.qlbhDataSet.sanpham);
            adapter = new SqlDataAdapter("select * from Sanpham", conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            ds = new DataSet();

            adapter.Fill(ds, "tblSanPham");

            dGVSanPham.DataSource = ds.Tables["tblSanPham"];

            dGVSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            dGVSanPham.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
             vitri = e.RowIndex;
                    if (vitri == -1 || ds.Tables["tblSanPham"].Rows.Count <= 0)

                    {

                        MessageBox.Show("Chon lai dong du lieu can xoa"); return;

                    }
                    DataRow row = ds.Tables["tblSanPham"].Rows[vitri];

                    row.Delete();

                    adapter.Update(ds.Tables["tblSanPham"]);

                
            }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtsp.Clear();
            txttensp.Clear();
            txtsl.Clear();
            txtdongia.Clear();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try

            {

                DataTable table = ds.Tables["tblSanPham"];

                DataRow row = table.NewRow();
                row["TenSP"] = txttensp.Text;

                row["DonGia"] = txtdongia.Text;

                row["SoLuong"] = txtsl.Text;

                table.Rows.Add(row);

                adapter.Update(table);

                frmDMSanPham_Load(sender, e);

            }

            catch (Exception ex)

            {
                MessageBox.Show("Loi Update" + ex.Message);
            }
        }
        int vitri = -1;
        private void btnsua_Click(object sender, EventArgs e)
        {


            if (vitri == -1)

            {

                MessageBox.Show("Chon dong du lieu can sua! ");

                return;

            }



            DataRow row = ds.Tables["tblSanPham"].Rows[vitri];

            row.BeginEdit();

            row["TenSP"] = txtsp.Text;

            row["DonGia"] = txtdongia.Text;

            row["SoLuong"] = txtsl.Text;

            row.EndEdit();

            adapter.Update(ds.Tables["tblSanPham"]);


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {


            if

            (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu này ko?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {

                if (vitri == -1 || ds.Tables["tblSanPham"].Rows.Count <= 0)

                {

                    MessageBox.Show("Chon lai dong du lieu can xoa"); return;

                }
                DataRow row = ds.Tables["tblSanPham"].Rows[vitri];

                row.Delete();

                adapter.Update(ds.Tables["tblSanPham"]);

            }

        }
    }
}
