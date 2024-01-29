namespace BakeryDesignPatterns.DAL.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string AboutCollecitonName { get; set; }
        public string TestimonialCollecitonName { get; set; }
        public string ClientCollecitonName { get; set; }
        public string ProductCollecitonName { get; set; }
        public string ServiceCollecitonName { get; set; }
    }
}
