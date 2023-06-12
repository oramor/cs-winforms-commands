namespace cs_winforms_commands
{
    public partial class MainForm : Form
    {
        bool _isMenuItemVisible = false;
        EntityMetadata _productEntity;

        public MainForm()
        {
            InitializeComponent();

            _productEntity = new EntityMetadata("Product") { IsShowAvailable = true };

            var cmd = new ShowEntityFormCommand();

            var programMenu = new ToolStripMenuItem("Program");

            var menuItem = new ToolStripMenuItem("Show Product") {
                Command = cmd,
                CommandParameter = _productEntity
            };

            programMenu.DropDownItems.Add(menuItem);

            mainFormMenuStrip.Items.Add(programMenu);
        }

        private void canShowProductsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _productEntity.IsShowAvailable = canShowProductsCheckBox.Checked;
        }
    }
}