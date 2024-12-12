namespace ISDS309Group4GroceryStoreProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exit curent tab
            this.Hide();
            //Then open new tab
            Tab_Home tabMeat = new Tab_Home();
            //.Show = open new tab, (can alt tab to others)
            //.ShowDialog = open new tab but you can't eddit others while its open
            tabMeat.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists("ProjectData"))
            {
                string dataFolder = "ProjectData", path = "";
                //Make the folder
                Directory.CreateDirectory(dataFolder);
                path = Path.Combine(dataFolder, "inventory.txt");

                //Add inventory file to it (opens stream)
                File.Create(path);




            }

        }
    }
}
