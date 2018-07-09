using IsKazalarıProje.DB;
using Microsoft.Office.Interop.Excel;
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

namespace IsKazalarıProje
{
    public partial class Crash : Form
    {
        public Crash()
        {
            InitializeComponent();
        }

        private void Crash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Default anaFrm = (Default)this.MdiParent;
            anaFrm.kazalarToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        public void getCrash()
        {
            using (BusinessCrashEntities db = new BusinessCrashEntities())
            {

                dataGridView1.DataSource = (from c in db.CrashUsers
                                            select new
                                            {
                                                c.Id,
                                                c.UserName,
                                                c.NameSurname,
                                                c.Age,
                                                c.Weight,
                                                c.Height,
                                                c.Class,
                                                c.CrashWhy,
                                                c.CrashPlace,
                                                c.CrashAbout,
                                                c.DateTime
                                            }).ToList();

                dataGridView1.Columns[0].HeaderText = "Kullanıcı Numarası";
                dataGridView1.Columns[1].HeaderText = "Oluşturan Kullanıcı";
                dataGridView1.Columns[2].HeaderText = "Kazazede Adı Soyadı";
                dataGridView1.Columns[3].HeaderText = "Kazazade Yaşı";
                dataGridView1.Columns[4].HeaderText = "Kilo";
                dataGridView1.Columns[5].HeaderText = "Boy";
                dataGridView1.Columns[6].HeaderText = "Bölüm";
                dataGridView1.Columns[7].HeaderText = "Kaza Nedeni";
                dataGridView1.Columns[8].HeaderText = "Kaza Yeri";
                dataGridView1.Columns[9].HeaderText = "Kaza Açıklaması";
                dataGridView1.Columns[10].HeaderText = "Kaza Oluşturulma Tarihi";

            }
        }

        private void Crash_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            getCrash();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;


            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "İş Kazası Geçirenler Listesi";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;


                //Loop through each row and read value from each column.
                for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(dataGridView1.Rows[i - 1].Cells[j].Value.ToString()))
                                dataGridView1.Rows[i - 1].Cells[j].Value = "";
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i-1].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Excell Başarıyla Oluşturuldu");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
     
        }
    }
}
