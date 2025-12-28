using System.Data;

namespace MVCDemo {
    public partial class CustomerView : Form {

        CustomerController controller;
        public CustomerView() {
            InitializeComponent();
        }

        public void setCustomerController(CustomerController c) {
            controller = c;
        }

        private void onMainViewButtonClick(object sender, EventArgs e) {
            controller.showMainView();
        }

        public void setUpSearchResultsList() {

            foreach (DataRow row in controller.houseDatabase.houses.Rows) {
                ListViewItem houseListing = new ListViewItem(row["Address"].ToString());
                houseListing.SubItems.Add(row["City"].ToString());
                houseListing.SubItems.Add(row["Zip"].ToString());
                houseListing.SubItems.Add(row["ID"].ToString());
                SearchResults.Items.Add(houseListing);
            }
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                SearchButton_Click(sender, e);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(this.SearchBox.Text)) {
                return;
            }
            updateSearchResults(controller.executeSearch(this.SearchBox.Text));
        }

        public void updateSearchResults(DataTable results) {
            SearchResults.Items.Clear();
            String[] allValues = new String[4];
            foreach (DataRow row in results.Rows) {
                allValues[0] = row["Address"].ToString();
                allValues[1] = row["City"].ToString();
                allValues[2] = row["Zip"].ToString();
                allValues[3] = row["ID"].ToString();
                ListViewItem houseListing = new ListViewItem(allValues);
                SearchResults.Items.Add(houseListing);
            }
        }

        private void SearchResults_MouseDoubleClick(object sender, MouseEventArgs e) {
            ListViewHitTestInfo info = SearchResults.HitTest(e.X, e.Y);
            ListViewItem houseListing = info.Item;
            if (houseListing == null) {
                return;
            }
            controller.setUpHouseView(houseListing);
            controller.showHouseView();
        }

        private void ResetSearchButton_Click(object sender, EventArgs e) {
            SearchResults.Items.Clear();
            setUpSearchResultsList();
        }
    }
}
