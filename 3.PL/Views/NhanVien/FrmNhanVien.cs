﻿using System;
using System.Linq;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Views.NhanVien;

namespace _3.PL.Views
{
    public partial class FrmNhanVien : Form
    {
        private INhanVienService _NhanVienService;
        private IChucVuService _chucVuService;
        private string _maWhenClick;
        public FrmNhanVien()
        {
            InitializeComponent();
            _NhanVienService = new NhanVienService();
            _chucVuService = new ChucVuService();
            LoadDataNV();
            loadDataCV();
            lb_MaFail.Visible = false;
            lb_HoTenFail.Visible = false;
            lb_NgaySinhFail.Visible = false;
            lb_EmailFail.Visible = false;
            lb_SDTFail.Visible = false;
            lb_MatKauFail.Visible = false;
            lb_VaiTroFail.Visible = false;
        }

        public void loadDataCV()
        {
            cbb_cvNV.Items.Clear();
            foreach (var x in _chucVuService.GetAll())
            {
                cbb_cvNV.Items.Add(x.Ten);
            }

        }
        public void LoadDataNV()
        {
            int stt = 1;
            dgrid_DtNhanVien.ColumnCount = 12;
            dgrid_DtNhanVien.Columns[0].Name = "STT";
            dgrid_DtNhanVien.Columns[1].Name = "MaNV";
            dgrid_DtNhanVien.Columns[2].Name = "Họ Và Tên";
            dgrid_DtNhanVien.Columns[3].Name = "Giới Tính";
            dgrid_DtNhanVien.Columns[4].Name = "Ngày Sinh";
            dgrid_DtNhanVien.Columns[5].Name = "Địa Chỉ";
            dgrid_DtNhanVien.Columns[6].Name = "SĐT";
            dgrid_DtNhanVien.Columns[7].Name = "Email";
            dgrid_DtNhanVien.Columns[8].Name = "Trạng Thái";
            dgrid_DtNhanVien.Columns[9].Name = "Mật Khẩu";
            dgrid_DtNhanVien.Columns[10].Name = "Chức Vụ";
            dgrid_DtNhanVien.Columns[11].Name = "Ca Làm Việc";
            dgrid_DtNhanVien.Rows.Clear();
            foreach (var x in _NhanVienService.GetAll())
            {
                dgrid_DtNhanVien.Rows.Add(stt++, x.Ma, x.Ten, x.GioiTinh, x.NgaySinh, x.DiaChi, x.SDT, x.Email,
                    x.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Động", x.MatKhau,x.TenCv);
            }
        }

        private QlNhanVienView GetDatafromGui()
        {
            QlNhanVienView nv =  new QlNhanVienView();
            var cv = _chucVuService.GetAll().FirstOrDefault(c => c.Ten.ToLower() == cbb_cvNV.Text.ToLower());
            if (cv != null)
            {
                nv = new QlNhanVienView()
                {
                    Ma = txt_maNV.Text,
                    Ten = txt_nameNV.Text,
                    GioiTinh = rb_nam.Checked ? "Nam" : "Nữ",
                    NgaySinh = dtpc_NgaySinh.Value,
                    Email = txt_emailNV.Text,
                    SDT = txt_sdtNV.Text,
                    MatKhau = txt_mkNV.Text,
                    DiaChi = txt_DiaChi.Text,
                    TrangThai = rbtn_HoatDong.Checked ? 1 : 0,
                    MaCV = cv.Ma
                };
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
            
            return nv;
        }
        private void btn_addNV_Click(object sender, EventArgs e)
        {
            //Check();
            if (Check())
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm nhân viên này không ? ", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_NhanVienService.add(GetDatafromGui()));
                    LoadDataNV();
                }
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show(_NhanVienService.add(GetDatafromGui()));
            }
        }

        private void btn_addCV_Click(object sender, EventArgs e)
        {
            FrmChucVu  frm = new FrmChucVu();
            frm.ShowDialog();
            loadDataCV();
        }

        public bool Check()
        {
           
            if (txt_nameNV.Text.Trim() == "")
            {
                lb_HoTenFail.Visible = true;
                lb_HoTenFail.Text = "không được để trống tên";
               
            }
            else
            {
                if (dtpc_NgaySinh.Text.Trim() == "")
                {
                    lb_NgaySinhFail.Visible = true;
                    lb_NgaySinhFail.Text = "vui lòng chọn ngày sinh";
                    
                }
                else
                {
                    if (txt_emailNV.Text.Trim() == "")
                    {
                        lb_EmailFail.Visible = true;
                        lb_EmailFail.Text = "không được để trống email";
                       
                    }
                    else
                    {
                        if (txt_sdtNV.Text.Trim() == "")
                        {
                            lb_SDTFail.Visible = true;
                            lb_SDTFail.Text = "không được để trống SDT";
                            
                        }
                        else
                        {
                            if (txt_mkNV.Text.Trim() == "")
                            {
                                lb_MatKauFail.Visible = true;
                                lb_MatKauFail.Text = "không được để trống mật khẩu";
                                
                            }
                            else
                            {
                                if (cbb_cvNV.Text.Trim() == "")
                                {
                                    lb_VaiTroFail.Visible = true;
                                    lb_VaiTroFail.Text = "vui lòng chọn vai trò";
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }


        private void txt_nameNV_TextChanged(object sender, EventArgs e)
        {
            lb_HoTenFail.Visible = false;
        }

        private void dtpc_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            lb_NgaySinhFail.Visible = false;
        }

        private void txt_emailNV_TextChanged(object sender, EventArgs e)
        {
            lb_EmailFail.Visible = false;
        }

        private void txt_sdtNV_TextChanged(object sender, EventArgs e)
        {
            lb_SDTFail.Visible = false;
        }

        private void txt_mkNV_TextChanged(object sender, EventArgs e)
        {
            lb_MatKauFail.Visible = false;
        }

        private void cbb_cvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_VaiTroFail.Visible = false;
        }

        private void dgrid_DtNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _NhanVienService.GetAll().Count)
            {
                return;
            }
            _maWhenClick = dgrid_DtNhanVien.Rows[rowIndex].Cells[1].Value.ToString();
            var _nhanVienVew = _NhanVienService.GetAll().FirstOrDefault(c => c.Ma == _maWhenClick);
            txt_maNV.Text = _nhanVienVew.Ma;
            txt_nameNV.Text = _nhanVienVew.Ten;
            dtpc_NgaySinh.Text =
            txt_mkNV.Text = _nhanVienVew.MatKhau;
            txt_DiaChi.Text = _nhanVienVew.DiaChi;

        }
    }
}
