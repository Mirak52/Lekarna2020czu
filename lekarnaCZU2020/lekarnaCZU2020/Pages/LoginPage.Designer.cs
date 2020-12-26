
namespace lekarnaCZU2020.Pages
{
    partial class LoginPage
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.databaseB = new System.Windows.Forms.Button();
            this.documentationB = new System.Windows.Forms.Button();
            this.statusL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(531, 232);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(220, 31);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Přihlásit se";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(442, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Přehled lékáren a doprava mezi nimi";
            // 
            // databaseB
            // 
            this.databaseB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.databaseB.Location = new System.Drawing.Point(531, 290);
            this.databaseB.Name = "databaseB";
            this.databaseB.Size = new System.Drawing.Size(220, 31);
            this.databaseB.TabIndex = 7;
            this.databaseB.Text = "Aktualizovat databázi";
            this.databaseB.UseVisualStyleBackColor = true;
            this.databaseB.Click += new System.EventHandler(this.databaseB_Click);
            // 
            // documentationB
            // 
            this.documentationB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.documentationB.Location = new System.Drawing.Point(531, 346);
            this.documentationB.Name = "documentationB";
            this.documentationB.Size = new System.Drawing.Size(220, 31);
            this.documentationB.TabIndex = 8;
            this.documentationB.Text = "Dokumentace";
            this.documentationB.UseVisualStyleBackColor = true;
            // 
            // statusL
            // 
            this.statusL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusL.AutoSize = true;
            this.statusL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusL.Location = new System.Drawing.Point(442, 158);
            this.statusL.Name = "statusL";
            this.statusL.Size = new System.Drawing.Size(0, 29);
            this.statusL.TabIndex = 9;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 704);
            this.Controls.Add(this.statusL);
            this.Controls.Add(this.documentationB);
            this.Controls.Add(this.databaseB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginPage";
            this.Text = "Přihlášení";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button databaseB;
        private System.Windows.Forms.Button documentationB;
        public System.Windows.Forms.Label statusL;
    }
}

