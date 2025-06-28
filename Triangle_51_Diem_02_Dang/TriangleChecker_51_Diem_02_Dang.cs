using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_51_Diem_02_Dang
{
    // Định nghĩa một class tên là TriangleChecker_51_Diem_02_Dang
    public class TriangleChecker_51_Diem_02_Dang
    {
        // Phương thức Execute nhận vào 3 số thực a, b, c đại diện cho 3 cạnh tam giác
        public string Execute_51_Diem_02_Dang (double a, double b, double c)
        {
            // Kiểm tra nếu bất kỳ cạnh nào <= 0 thì không hợp lệ
            if (a <= 0 || b <= 0 || c <= 0)
            {
                // Trả về thông báo lỗi
                return "Các cạnh phải lớn hơn 0.";
            }

            // Kiểm tra điều kiện để 3 cạnh tạo thành tam giác: tổng hai cạnh phải lớn hơn cạnh còn lại
            if (a + b > c && a + c > b && b + c > a)
            {
                // Nếu có ít nhất hai cạnh bằng nhau thì là tam giác cân
                if (a == b || a == c || b == c)
                {
                    // Trả về thông báo là tam giác cân
                    return "Đây là tam giác cân.";
                }
                else
                {
                    // Không có cạnh nào bằng nhau
                    return "Đây không phải là tam giác cân.";
                }
            }
            else
            {
                // Nếu không thoả điều kiện tam giác, trả về thông báo lỗi
                return "Ba cạnh không tạo thành tam giác.";
            }
        }
    }
}
