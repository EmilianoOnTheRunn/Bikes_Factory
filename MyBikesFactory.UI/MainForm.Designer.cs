namespace MyBikesFactory.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBikeType = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblManufacturingYear = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSuspensionType = new System.Windows.Forms.Label();
            this.lblTireType = new System.Windows.Forms.Label();
            this.lblOriginalId = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.cbBikeType = new System.Windows.Forms.ComboBox();
            this.cbTireType = new System.Windows.Forms.ComboBox();
            this.cbSuspensionType = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtManufacturingYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtOriginalId = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBikes = new System.Windows.Forms.ListBox();
            this.rbDisplayAll = new System.Windows.Forms.RadioButton();
            this.rbDisplayRoad = new System.Windows.Forms.RadioButton();
            this.rbDisplayMountain = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBikeType
            // 
            this.lblBikeType.AutoSize = true;
            this.lblBikeType.Location = new System.Drawing.Point(27, 21);
            this.lblBikeType.Name = "lblBikeType";
            this.lblBikeType.Size = new System.Drawing.Size(56, 15);
            this.lblBikeType.TabIndex = 0;
            this.lblBikeType.Text = "Bike Type";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(190, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(349, 21);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 15);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblManufacturingYear
            // 
            this.lblManufacturingYear.AutoSize = true;
            this.lblManufacturingYear.Location = new System.Drawing.Point(27, 88);
            this.lblManufacturingYear.Name = "lblManufacturingYear";
            this.lblManufacturingYear.Size = new System.Drawing.Size(111, 15);
            this.lblManufacturingYear.TabIndex = 3;
            this.lblManufacturingYear.Text = "Manufacturing Year";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(190, 88);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 15);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            // 
            // lblSuspensionType
            // 
            this.lblSuspensionType.AutoSize = true;
            this.lblSuspensionType.Location = new System.Drawing.Point(349, 88);
            this.lblSuspensionType.Name = "lblSuspensionType";
            this.lblSuspensionType.Size = new System.Drawing.Size(94, 15);
            this.lblSuspensionType.TabIndex = 5;
            this.lblSuspensionType.Text = "Suspension Type";
            // 
            // lblTireType
            // 
            this.lblTireType.AutoSize = true;
            this.lblTireType.Location = new System.Drawing.Point(503, 88);
            this.lblTireType.Name = "lblTireType";
            this.lblTireType.Size = new System.Drawing.Size(53, 15);
            this.lblTireType.TabIndex = 6;
            this.lblTireType.Text = "Tire Type";
            // 
            // lblOriginalId
            // 
            this.lblOriginalId.AutoSize = true;
            this.lblOriginalId.Location = new System.Drawing.Point(453, 158);
            this.lblOriginalId.Name = "lblOriginalId";
            this.lblOriginalId.Size = new System.Drawing.Size(65, 15);
            this.lblOriginalId.TabIndex = 7;
            this.lblOriginalId.Text = "Original Id:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(27, 228);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(199, 15);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.Text = "Display All, Road. Or Mountain Bikes";
            // 
            // cbBikeType
            // 
            this.cbBikeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBikeType.FormattingEnabled = true;
            this.cbBikeType.Items.AddRange(new object[] {
            "Mountain",
            "RoadBike"});
            this.cbBikeType.Location = new System.Drawing.Point(27, 39);
            this.cbBikeType.Name = "cbBikeType";
            this.cbBikeType.Size = new System.Drawing.Size(121, 23);
            this.cbBikeType.TabIndex = 9;
            this.cbBikeType.SelectedIndexChanged += new System.EventHandler(this.cbBikeType_SelectedIndexChanged);
            // 
            // cbTireType
            // 
            this.cbTireType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTireType.FormattingEnabled = true;
            this.cbTireType.Items.AddRange(new object[] {
            "Regular ",
            "Commuter",
            "Gravel"});
            this.cbTireType.Location = new System.Drawing.Point(503, 106);
            this.cbTireType.Name = "cbTireType";
            this.cbTireType.Size = new System.Drawing.Size(121, 23);
            this.cbTireType.TabIndex = 10;
            // 
            // cbSuspensionType
            // 
            this.cbSuspensionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuspensionType.FormattingEnabled = true;
            this.cbSuspensionType.Items.AddRange(new object[] {
            "Front",
            "Rear ",
            "Dual"});
            this.cbSuspensionType.Location = new System.Drawing.Point(349, 106);
            this.cbSuspensionType.Name = "cbSuspensionType";
            this.cbSuspensionType.Size = new System.Drawing.Size(121, 23);
            this.cbSuspensionType.TabIndex = 11;
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Black",
            "Blue ",
            "Green",
            "Red"});
            this.cbColor.Location = new System.Drawing.Point(178, 106);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 23);
            this.cbColor.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(190, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 13;
            // 
            // txtManufacturingYear
            // 
            this.txtManufacturingYear.Location = new System.Drawing.Point(27, 109);
            this.txtManufacturingYear.Name = "txtManufacturingYear";
            this.txtManufacturingYear.Size = new System.Drawing.Size(111, 23);
            this.txtManufacturingYear.TabIndex = 14;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(349, 39);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 23);
            this.txtModel.TabIndex = 15;
            // 
            // txtOriginalId
            // 
            this.txtOriginalId.Enabled = false;
            this.txtOriginalId.Location = new System.Drawing.Point(524, 150);
            this.txtOriginalId.Name = "txtOriginalId";
            this.txtOriginalId.Size = new System.Drawing.Size(100, 23);
            this.txtOriginalId.TabIndex = 16;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(27, 350);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(146, 350);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(549, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lstBikes
            // 
            this.lstBikes.FormattingEnabled = true;
            this.lstBikes.ItemHeight = 15;
            this.lstBikes.Location = new System.Drawing.Point(27, 250);
            this.lstBikes.Name = "lstBikes";
            this.lstBikes.Size = new System.Drawing.Size(597, 94);
            this.lstBikes.TabIndex = 21;
            this.lstBikes.SelectedIndexChanged += new System.EventHandler(this.lstBikes_SelectedIndexChanged_1);
            // 
            // rbDisplayAll
            // 
            this.rbDisplayAll.AutoSize = true;
            this.rbDisplayAll.Checked = true;
            this.rbDisplayAll.Location = new System.Drawing.Point(259, 226);
            this.rbDisplayAll.Name = "rbDisplayAll";
            this.rbDisplayAll.Size = new System.Drawing.Size(39, 19);
            this.rbDisplayAll.TabIndex = 22;
            this.rbDisplayAll.TabStop = true;
            this.rbDisplayAll.Text = "All";
            this.rbDisplayAll.UseVisualStyleBackColor = true;
            this.rbDisplayAll.CheckedChanged += new System.EventHandler(this.rbDisplayAll_CheckedChanged_1);
            // 
            // rbDisplayRoad
            // 
            this.rbDisplayRoad.AutoSize = true;
            this.rbDisplayRoad.Location = new System.Drawing.Point(323, 226);
            this.rbDisplayRoad.Name = "rbDisplayRoad";
            this.rbDisplayRoad.Size = new System.Drawing.Size(52, 19);
            this.rbDisplayRoad.TabIndex = 23;
            this.rbDisplayRoad.Text = "Road";
            this.rbDisplayRoad.UseVisualStyleBackColor = true;
            this.rbDisplayRoad.CheckedChanged += new System.EventHandler(this.rbDisplayRoad_CheckedChanged);
            // 
            // rbDisplayMountain
            // 
            this.rbDisplayMountain.AutoSize = true;
            this.rbDisplayMountain.Location = new System.Drawing.Point(381, 226);
            this.rbDisplayMountain.Name = "rbDisplayMountain";
            this.rbDisplayMountain.Size = new System.Drawing.Size(77, 19);
            this.rbDisplayMountain.TabIndex = 24;
            this.rbDisplayMountain.Text = "Mountain";
            this.rbDisplayMountain.UseVisualStyleBackColor = true;
            this.rbDisplayMountain.CheckedChanged += new System.EventHandler(this.rbDisplayMountain_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(27, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = " Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(349, 185);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(275, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(374, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(677, 416);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rbDisplayMountain);
            this.Controls.Add(this.rbDisplayRoad);
            this.Controls.Add(this.rbDisplayAll);
            this.Controls.Add(this.lstBikes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtOriginalId);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturingYear);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbSuspensionType);
            this.Controls.Add(this.cbTireType);
            this.Controls.Add(this.cbBikeType);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblOriginalId);
            this.Controls.Add(this.lblTireType);
            this.Controls.Add(this.lblSuspensionType);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblManufacturingYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblBikeType);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBikeType;
        private Label lblId;
        private Label lblModel;
        private Label lblManufacturingYear;
        private Label lblColor;
        private Label lblSuspensionType;
        private Label lblTireType;
        private Label lblOriginalId;
        private Label lblDisplay;
        private ComboBox cbBikeType;
        private ComboBox cbTireType;
        private ComboBox cbSuspensionType;
        private ComboBox cbColor;
        private TextBox txtId;
        private TextBox txtManufacturingYear;
        private TextBox txtModel;
        private TextBox txtOriginalId;
        private Button btnRemove;
        private Button btnSearch;
        private Button btnSave;
        private Button btnExit;
        private ListBox lstBikes;
        private RadioButton rbDisplayAll;
        private RadioButton rbDisplayRoad;
        private RadioButton rbDisplayMountain;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
    }
}