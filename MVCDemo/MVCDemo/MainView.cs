namespace MVCDemo {
    public partial class MainView : Form {

        private MainController controller;
        public MainView() {
            InitializeComponent();
        }

        public void setMainController(MainController c) {
            controller = c;
        }
        private void onCustomerViewButtonClick(object sender, EventArgs e) {
            controller.showCustomerView();
        }

        private void onRealtorViewButtonClick(object sender, EventArgs e) {
            controller.showRealtorView();
        }
    }
}