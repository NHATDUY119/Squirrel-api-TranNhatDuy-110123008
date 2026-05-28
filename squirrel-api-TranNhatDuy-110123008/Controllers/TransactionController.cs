using Microsoft.AspNetCore.Mvc;
using squirrel_api_TranNhatDuy_110123008.Models;
using System.Collections.Generic;
using System.Linq;

namespace squirrel_api_TranNhatDuy_110123008.Controllers
{
    [Route("api/giaodich")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        // Khởi tạo cứng 5 dòng dữ liệu mẫu
        private readonly List<Transaction> _transactions = new List<Transaction>
        {
            new Transaction { Id = 1, SoTaiKhoan = "1023456789", SoTien = 500000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 2, SoTaiKhoan = "1023456789", SoTien = 200000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 3, SoTaiKhoan = "1098765432", SoTien = 1000000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 4, SoTaiKhoan = "1098765432", SoTien = 150000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 5, SoTaiKhoan = "1055566677", SoTien = 300000, LoaiGiaoDich = "Nap tien" }
        };

        [HttpGet]
        public IActionResult GetNapTien()
        {
            // Chỉ lọc và trả về các giao dịch có loại là "Nap tien"
            var napTienList = _transactions.Where(t => t.LoaiGiaoDich == "Nap tien").ToList();
            return Ok(napTienList);
        }
    }
}