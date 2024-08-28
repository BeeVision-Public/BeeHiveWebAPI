namespace BeeHive.WebAPI.DTOs
{
    public class TextDetectionAPIInputDTO
    {
        public string ReceiversAddress { get; set; }

        public string ReceiversName { get; set; }

        public string SerialNumber { get; set; }

        public string Barcode { get; set; }

        public string Time { get; set; }

        public string Date { get; set; }

        public long MeasurementID { get; set; }

        public object OCRText { get; set; }
    }
}
