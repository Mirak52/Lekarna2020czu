
namespace lekarnaCZU2020.Pages
{
    partial class MainPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pharmaciesView = new System.Windows.Forms.ListView();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.roadViewList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countPathB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfSelectedL = new System.Windows.Forms.Label();
            this.toggleB = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            this.searchB = new System.Windows.Forms.Button();
            this.errorL = new System.Windows.Forms.Label();
            this.modeBox = new System.Windows.Forms.ComboBox();
            this.resultL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmaciesView
            // 
            this.pharmaciesView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pharmaciesView.GridLines = true;
            this.pharmaciesView.HideSelection = false;
            this.pharmaciesView.Location = new System.Drawing.Point(21, 167);
            this.pharmaciesView.Name = "pharmaciesView";
            this.pharmaciesView.Size = new System.Drawing.Size(562, 550);
            this.pharmaciesView.TabIndex = 0;
            this.pharmaciesView.UseCompatibleStateImageBehavior = false;
            this.pharmaciesView.SelectedIndexChanged += new System.EventHandler(this.pharmaciesView_SelectedIndexChanged);
            // 
            // filterBox
            // 
            this.filterBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Location = new System.Drawing.Point(21, 92);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(183, 24);
            this.filterBox.TabIndex = 1;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterTextBox.Location = new System.Drawing.Point(210, 92);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(373, 24);
            this.filterTextBox.TabIndex = 2;
            // 
            // roadViewList
            // 
            this.roadViewList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roadViewList.HideSelection = false;
            this.roadViewList.Location = new System.Drawing.Point(589, 448);
            this.roadViewList.MaximumSize = new System.Drawing.Size(10000, 5000);
            this.roadViewList.Name = "roadViewList";
            this.roadViewList.Size = new System.Drawing.Size(665, 269);
            this.roadViewList.TabIndex = 3;
            this.roadViewList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dostupné lékárny";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(589, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 278);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // countPathB
            // 
            this.countPathB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countPathB.Location = new System.Drawing.Point(1039, 400);
            this.countPathB.Name = "countPathB";
            this.countPathB.Size = new System.Drawing.Size(215, 42);
            this.countPathB.TabIndex = 6;
            this.countPathB.Text = "Vypočítat trasu";
            this.countPathB.UseVisualStyleBackColor = true;
            this.countPathB.Click += new System.EventHandler(this.countPathB_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(796, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 58);
            this.label2.TabIndex = 7;
            this.label2.Text = "Informace";
            // 
            // numberOfSelectedL
            // 
            this.numberOfSelectedL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberOfSelectedL.AutoSize = true;
            this.numberOfSelectedL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfSelectedL.Location = new System.Drawing.Point(895, 403);
            this.numberOfSelectedL.Name = "numberOfSelectedL";
            this.numberOfSelectedL.Size = new System.Drawing.Size(64, 39);
            this.numberOfSelectedL.TabIndex = 8;
            this.numberOfSelectedL.Text = "0/5";
            // 
            // toggleB
            // 
            this.toggleB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toggleB.Location = new System.Drawing.Point(589, 400);
            this.toggleB.Name = "toggleB";
            this.toggleB.Size = new System.Drawing.Size(215, 42);
            this.toggleB.TabIndex = 9;
            this.toggleB.Text = "Reset";
            this.toggleB.UseVisualStyleBackColor = true;
            this.toggleB.Click += new System.EventHandler(this.toggleB_Click);
            // 
            // backB
            // 
            this.backB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backB.Location = new System.Drawing.Point(1180, 0);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(102, 47);
            this.backB.TabIndex = 10;
            this.backB.Text = "Odejít";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // searchB
            // 
            this.searchB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchB.Location = new System.Drawing.Point(210, 123);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(373, 38);
            this.searchB.TabIndex = 11;
            this.searchB.Text = "Vyhledat";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // errorL
            // 
            this.errorL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorL.AutoSize = true;
            this.errorL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorL.ForeColor = System.Drawing.Color.Red;
            this.errorL.Location = new System.Drawing.Point(804, 88);
            this.errorL.Name = "errorL";
            this.errorL.Size = new System.Drawing.Size(0, 25);
            this.errorL.TabIndex = 12;
            // 
            // modeBox
            // 
            this.modeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Location = new System.Drawing.Point(21, 131);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(183, 24);
            this.modeBox.TabIndex = 13;
            // 
            // resultL
            // 
            this.resultL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultL.AutoSize = true;
            this.resultL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultL.Location = new System.Drawing.Point(871, 88);
            this.resultL.Name = "resultL";
            this.resultL.Size = new System.Drawing.Size(0, 25);
            this.resultL.TabIndex = 14;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultL);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.errorL);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.toggleB);
            this.Controls.Add(this.numberOfSelectedL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countPathB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roadViewList);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.pharmaciesView);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1282, 751);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView pharmaciesView;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.ListView roadViewList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button countPathB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfSelectedL;
        private System.Windows.Forms.Button toggleB;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Label errorL;
        private System.Windows.Forms.ComboBox modeBox;
        private System.Windows.Forms.Label resultL;
    }
}
