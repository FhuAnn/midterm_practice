namespace Presentation.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        // Biến cờ để kiểm tra xem RequestId có null hay không
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        // Thuộc tính lưu thông báo lỗi, có thể tùy chọn
        public string? ErrorMessage { get; set; }

        // Thuộc tính để lưu chi tiết về lỗi
        public string? ErrorDetails { get; set; }
    }
}
