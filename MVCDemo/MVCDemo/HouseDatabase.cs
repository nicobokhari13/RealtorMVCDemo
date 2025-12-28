using System.Data;

namespace MVCDemo {
    public class HouseDatabase {

        public DataTable houses { get; private set; }
        public HouseDatabase() {
            houses = new DataTable();
            houses.Columns.Add("ID", typeof(int));
            houses.PrimaryKey = new DataColumn[] { houses.Columns["ID"] };
            DataColumn IDColumnn = houses.Columns["ID"];
            IDColumnn.AutoIncrement = true;
            houses.Columns.Add("Price", typeof(double));
            houses.Columns.Add("Address", typeof(String));
            houses.Columns.Add("City", typeof(String));
            houses.Columns.Add("Zip", typeof(String));
            houses.Columns.Add("Property Type", typeof(String));
            houses.Columns.Add("Year Built", typeof(int));
            houses.Columns.Add("Number of Bedrooms", typeof(int));
        }

        public void addHouse(HouseModel newHouse) {
            DataRow row = houses.NewRow();
            row["Price"] = newHouse.price;
            row["Address"] = newHouse.address;
            row["City"] = newHouse.city;
            row["Zip"] = newHouse.zip;
            row["Property Type"] = newHouse.propertyType;
            row["Year Built"] = newHouse.year;
            row["Number of Bedrooms"] = newHouse.numberBedrooms;
            houses.Rows.Add(row);
        }
        public void updateHouse(int id, HouseModel updatedHouse) {
            DataRow row = houses.Rows[id];
            row["Price"] = updatedHouse.price;
            row["Address"] = updatedHouse.address;
            row["City"] = updatedHouse.city;
            row["Zip"] = updatedHouse.zip;
            row["Property Type"] = updatedHouse.propertyType;
            row["Year"] = updatedHouse.year;
            row["Number of Bedrooms"] = updatedHouse.numberBedrooms;
        }

        public DataTable searchHouses(String searchString) {
            DataTable results = houses.Clone();
            foreach (DataRow row in houses.Rows) {
                foreach (DataColumn col in houses.Columns) {
                    String house = row[col.ColumnName].ToString();
                    if (house.Contains(searchString)) {
                        results.Rows.Add(row.ItemArray);
                        break;
                    }
                }
            }
            return results;
        }
    }
}

