namespace cs_winforms_commands
{
    public partial class MainForm : Form
    {
        readonly EntityMetadata _productEntity;
        readonly EntityMetadata _subjectEntity;

        public MainForm()
        {
            InitializeComponent();

            _productEntity = new EntityMetadata("Product") { IsShowAvailable = canShowProductsCheckBox.Checked };
            _subjectEntity = new EntityMetadata("Subject") { IsShowAvailable = canShowSubjectsCheckBox.Checked };

            var cmd = new ShowEntityFormCommand();

            var programMenu = new ToolStripMenuItem("Program");

            var productMenuItem = new ToolStripMenuItem("Show Product") {
                Command = cmd,
                CommandParameter = _productEntity
            };

            var subjectMenuItem = new ToolStripMenuItem("Show Subject") {
                Command = cmd,
                CommandParameter = _subjectEntity
            };

            programMenu.DropDownItems.AddRange(new[] { productMenuItem, subjectMenuItem });
            mainFormMenuStrip.Items.Add(programMenu);
        }

        private void canShowProductsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _productEntity.IsShowAvailable = canShowProductsCheckBox.Checked;
        }

        private void canShowSubjectsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _subjectEntity.IsShowAvailable = canShowSubjectsCheckBox.Checked;
        }
    }
}