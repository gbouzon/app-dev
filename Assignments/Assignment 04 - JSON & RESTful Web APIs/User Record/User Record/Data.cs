namespace User_Record
{
    class Data
    {
        public int page { get; set; } //not going to be used
        public int per_page { get; set; } //not going to be used
        public int total { get; set; } //not going to be used
        public int total_pages { get; set; } //not going to be used

        public User[] data { get; set; } //array containing users to be displayed
        public Support support { get; set; } //not going to be used
    }
}