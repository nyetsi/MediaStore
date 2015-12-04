namespace MediaStore.Data.DataModels
{
    public class Cd : Media
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Album { get; set; }
    }
}
