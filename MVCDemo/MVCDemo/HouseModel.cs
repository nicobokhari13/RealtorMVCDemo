namespace MVCDemo {
    public class HouseModel {
        public double price { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String zip { get; set; }
        public String propertyType { get; set; }
        public int year { get; set; }
        public int numberBedrooms { get; set; }
        public HouseModel(double price, String address, String city, String zip, String propertyType, int year, int numberBedrooms) {
            this.price = price;
            this.address = address;
            this.city = city;
            this.zip = zip;
            this.propertyType = propertyType;
            this.year = year;
            this.numberBedrooms = numberBedrooms;
        }
    }
}
