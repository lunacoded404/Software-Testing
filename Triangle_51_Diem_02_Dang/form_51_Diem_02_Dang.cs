using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_51_Diem_02_Dang
{
    // Định nghĩa lớp Form_51_Diem_02_Dang kế thừa từ lớp Form của Windows Forms
    public partial class form_51_Diem_02_Dang : Form
    {
        // Hàm khởi tạo của Form_51_Diem_02_Dang, sẽ được gọi khi form được tạo ra
        public form_51_Diem_02_Dang()
        {
            // Hàm này tạo các control trên form (như button, textbox...)
            InitializeComponent();
        }

        // Sự kiện khi người dùng click vào nút "Kiểm tra" (btnCheck_51_Diem_02_Dang)
        private void btnCheck_51_Diem_02_Dang_Click(object sender, EventArgs e)
        {
            // Thử chuyển đổi giá trị nhập vào từ các TextBox thành số thực (double)
            if (double.TryParse(txtA_51_Diem_02_Dang.Text, out double a) &&
            double.TryParse(txtB_51_Diem_02_Dang.Text, out double b) &&
            double.TryParse(txtC_51_Diem_02_Dang.Text, out double c))
            {
                // Tạo một đối tượng của class TriangleChecker_51_Diem_02_Dang để gọi phương thức Execute_51_Diem_02_Dang
                var checker = new TriangleChecker_51_Diem_02_Dang();

                /* Gọi phương thức Execute_51_Diem_02_Dang của TriangleChecker_51_Diem_02_Dang
                   hiển thị kết quả trên txtResult_51_Diem_02_Dang */
                txtResult_51_Diem_02_Dang.Text = checker.Execute_51_Diem_02_Dang(a, b, c);
            }
            else
            {
                // Nếu không thể chuyển đổi giá trị nhập vào thành số thực, thông báo lỗi
                txtResult_51_Diem_02_Dang.Text = "Vui lòng nhập số hợp lệ cho các cạnh.";
            }
        }
    }
}
