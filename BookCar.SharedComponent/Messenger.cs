using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.SharedComponent
{
    public static class Messenger
    {
        public static string UpdateCompleted = "Cập nhật thành công";
        public static string InsertCompleted = "Thêm thành công";
        public static string InsertFailed = "Thêm thất bại";
        public static string UpdateFailed = "Cập nhật thất bại";
    }
}
