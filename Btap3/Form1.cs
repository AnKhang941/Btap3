﻿using Btap3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btap3
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVien employeeForm = new frmNhanVien();
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                string[] row = new string[] {
                    employeeForm.MSNV,
                    employeeForm.TenNV,
                    employeeForm.LuongCB
                };
                dgvNhanVien.Rows.Add(row);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
                frmNhanVien employeeForm = new frmNhanVien(

                );

                if (employeeForm.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells[0].Value = employeeForm.MSNV;
                    selectedRow.Cells[1].Value = employeeForm.TenNV;
                    selectedRow.Cells[2].Value = employeeForm.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                dgvNhanVien.Rows.RemoveAt(dgvNhanVien.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmList_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form đã được tải!");
        }

        private void frmList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Bạn có chắc chắn muốn thoát?",
          "Xác nhận thoát",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
          );
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
