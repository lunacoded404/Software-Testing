using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle_51_Diem_02_Dang;

namespace TriangleTester_51_Diem_02_Dang
{
    [TestClass]
    public class UnitTest_51_Diem_02_Dang
    {
        // Test trường hợp tam giác cân
        [TestMethod]
        public void TC01_51_Diem_02_Dang()
        {
            // Tạo đối tượng TriangleChecker_51_Diem_02_Dang
            var checker = new TriangleChecker_51_Diem_02_Dang();

            // Gọi phương thức Execute_51_Diem_02_Dang với 2 cạnh bằng nhau
            // Kết quả ra Pass 
            var result = checker.Execute_51_Diem_02_Dang(5, 5, 3);

            // Kiểm tra kết quả trả về là "Đây là tam giác cân."
            Assert.AreEqual("Đây là tam giác cân.", result);
        }
        // Test trường hợp fail của TC01_51_Diem_02_Dang 
        [TestMethod]
        public void TC05_51_Diem_02_Dang()
        {
            // Tạo đối tượng TriangleChecker_51_Diem_02_Dang
            var checker = new TriangleChecker_51_Diem_02_Dang();

            // Gọi phương thức Execute_51_Diem_02_Dang với 2 cạnh bằng nhau
            // Kết quả ra Fail 
            var result = checker.Execute_51_Diem_02_Dang(5, 5, 3);

            // Kiểm tra kết quả trả về là "Đây là tam giác cân."
            Assert.AreEqual("Đây không phải là tam giác cân.", result);
        }
        // Test trường hợp tam giác không cân
        [TestMethod]
        public void TC02_51_Diem_02_Dang()
        {
            // Tạo đối tượng TriangleChecker_51_Diem_02_Dang
            var checker = new TriangleChecker_51_Diem_02_Dang();

            // Gọi phương thức Execute_51_Diem_02_Dang với 3 cạnh khác nhau
            // Kết quả ra Pass
            var result = checker.Execute_51_Diem_02_Dang(5, 6, 7);

            // Kiểm tra kết quả trả về là "Đây không phải là tam giác cân."
            Assert.AreEqual("Đây không phải là tam giác cân.", result);
        }
        // Test trường hợp fail của TC02_51_Diem_02_Dang 
        [TestMethod]
        public void TC06_51_Diem_02_Dang()
        {
            // Tạo đối tượng TriangleChecker_51_Diem_02_Dang
            var checker = new TriangleChecker_51_Diem_02_Dang();

            // Gọi phương thức Execute_51_Diem_02_Dang với 3 cạnh khác nhau
            // Kết quả ra Fail
            var result = checker.Execute_51_Diem_02_Dang(5, 6, 7);

            // Kiểm tra kết quả trả về là "Đây không phải là tam giác cân."
            Assert.AreEqual("Đây là tam giác cân.", result);
        }
        // Test trường hợp không phải tam giác
        [TestMethod]
        public void TC03_51_Diem_02_Dang()
        {
            // Tạo đối tượng TriangleChecker_51_Diem_02_Dang
            var checker = new TriangleChecker_51_Diem_02_Dang();

            // Gọi phương thức Execute_51_Diem_02_Dang với các cạnh không tạo thành tam giác (ví dụ: 1 + 2 <= 3)
            // Kết quả ra Pass
            var result = checker.Execute_51_Diem_02_Dang(1, 2, 3);

            // Kiểm tra kết quả trả về là "Ba cạnh không tạo thành tam giác."
            Assert.AreEqual("Ba cạnh không tạo thành tam giác.", result);
        }
        // Test trường hợp fail của TC03_51_Diem_02_Dang 
        [TestMethod]
        public void TC07_51_Diem_02_Dang()
        {
            // Tạo đối tượng TriangleChecker_51_Diem_02_Dang
            var checker = new TriangleChecker_51_Diem_02_Dang();

            // Gọi phương thức Execute_51_Diem_02_Dang với các cạnh không tạo thành tam giác (ví dụ: 1 + 2 <= 3)
            // Kết quả ra Fail
            var result = checker.Execute_51_Diem_02_Dang(1, 2, 3);

            // Kiểm tra kết quả trả về là "Ba cạnh không tạo thành tam giác."
            Assert.AreEqual("Đây là tam giác cân.", result);
        }
        // Test trường hợp cạnh không hợp lệ (<= 0)
        [TestMethod]
        public void TC04_51_Diem_02_Dang() { 
        
            // Tạo đối tượng TriangleChecker_51_Diem_02_Dang
            var checker = new TriangleChecker_51_Diem_02_Dang();

            // Gọi phương thức Execute_51_Diem_02_Dang với các cạnh không hợp lệ
            // Kết quả ra Pass
            var result = checker.Execute_51_Diem_02_Dang(0, 5, 6);

            // Kiểm tra kết quả trả về là "Các cạnh phải lớn hơn 0."
            Assert.AreEqual("Các cạnh phải lớn hơn 0.", result);
        }
        // Test trường hợp fail của TC04_51_Diem_02_Dang
        [TestMethod]
        public void TC08_51_Diem_02_Dang()
        {

            // Tạo đối tượng TriangleChecker_51_Diem_02_Dang
            var checker = new TriangleChecker_51_Diem_02_Dang();

            // Gọi phương thức Execute_51_Diem_02_Dang với các cạnh không hợp lệ
            // Kết quả ra Fail
            var result = checker.Execute_51_Diem_02_Dang(0, 5, 6);

            // Kiểm tra kết quả trả về là "Các cạnh phải lớn hơn 0."
            Assert.AreEqual("Đây không phải là tam giác cân.", result);
        }
    }
}
