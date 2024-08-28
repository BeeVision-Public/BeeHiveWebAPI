namespace BeeHive.WebAPI.DTOs
{
    public class MeasurementAPIInputDTO
    {
        public string Operator { get; set; }

        public string SortTime { get; set; }

        public string Label { get; set; }

        public string WeightUnit { get; set; }

        public string Time { get; set; }

        public double? DimWt { get; set; }

        public int? Gate { get; set; }

        public string BranchID { get; set; }

        public int? StatusCode { get; set; }

        public object ObjectType { get; set; }

        public object BatchName { get; set; }

        public int? IsRegular { get; set; }

        public string LabelSource { get; set; }

        public string BarcodeSource { get; set; }

        public double? Height { get; set; }

        public double? Width { get; set; }

        public object CropCoordinates { get; set; }

        public string RouteCode { get; set; }

        public string NoSortCause { get; set; }

        public string SortDate { get; set; }

        public string Date { get; set; }

        public string Weight { get; set; }

        public string StatusMessage { get; set; }

        public string ImageBase64 { get; set; }

        public int? RealVolume { get; set; }

        public string DimUnit { get; set; }

        public double? ObjectTypeConfidence { get; set; }

        public string RouteDesc { get; set; }

        public string SerialNumber { get; set; }

        public string UnitID { get; set; }

        public double Length { get; set; }
        public string Barcode { get; set; }

        public string AssignmentConfig { get; set; }

        public long MeasurementID { get; set; }

        public string BarcodeType { get; set; }
    }
}
