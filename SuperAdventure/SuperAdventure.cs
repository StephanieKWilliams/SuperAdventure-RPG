using Engine;
namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();
            _player = new Player();

            _player.CurrentPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.level = 1;

            lblHitPoints.Text = _player.CurrentPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.level.ToString();

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
