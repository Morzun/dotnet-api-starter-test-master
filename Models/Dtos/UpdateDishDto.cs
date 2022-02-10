namespace dotnet_api_test.Models.Dtos
{
    public class UpdateDishDto
    {
        public string? Name { get; init; }

        public string? MadeBy { get; init; }

        public double? Cost { get; set; }
    }
}