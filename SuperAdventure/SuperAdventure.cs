using Engine;
namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();
            _player = new Player(10, 10, 20, 0, 1);

            

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblHitPoints.Visible = false;
            lblGold.Visible = false;
            lblExperience.Visible = false;
            lblLevel.Visible = false;
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
