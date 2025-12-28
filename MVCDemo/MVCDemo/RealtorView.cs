namespace MVCDemo {
    public partial class RealtorView : Form {

        RealtorController controller;
        public RealtorView() {
            InitializeComponent();
        }

        public void setRealtorController(RealtorController r) {
            controller = r;
        }

        private void onMainViewButtonClic(object sender, EventArgs e) {
            controller.showMainView();
        }
    }
}
