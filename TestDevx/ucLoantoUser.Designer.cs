namespace TestDevx
{
    partial class ucLoantoUser
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
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.btnAddLoan = new DevExpress.XtraEditors.SimpleButton();
            this.txtPiece = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiece.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUser
            // 
            this.cbUser.DropDownWidth = 350;
            this.cbUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(23, 60);
            this.cbUser.Margin = new System.Windows.Forms.Padding(8);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(280, 33);
            this.cbUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose User for Loan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(425, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose a Product for Loan:";
            // 
            // cbProducts
            // 
            this.cbProducts.DropDownWidth = 350;
            this.cbProducts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(429, 60);
            this.cbProducts.Margin = new System.Windows.Forms.Padding(8);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(280, 33);
            this.cbProducts.TabIndex = 3;
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(545, 174);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(164, 49);
            this.btnAddLoan.TabIndex = 5;
            this.btnAddLoan.Text = "Add Loan";
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // txtPiece
            // 
            this.txtPiece.EditValue = "";
            this.txtPiece.Location = new System.Drawing.Point(23, 180);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPiece.Properties.Appearance.Options.UseFont = true;
            this.txtPiece.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPiece.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtPiece.Properties.Mask.BeepOnError = true;
            this.txtPiece.Properties.Mask.EditMask = "\\d+";
            this.txtPiece.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPiece.Size = new System.Drawing.Size(120, 34);
            this.txtPiece.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of products to be registered:";
            // 
            // ucLoantoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPiece);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddLoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUser);
            this.Name = "ucLoantoUser";
            this.Size = new System.Drawing.Size(914, 518);
            this.Load += new System.EventHandler(this.ucLoantoUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPiece.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProducts;
        private DevExpress.XtraEditors.SimpleButton btnAddLoan;
        private DevExpress.XtraEditors.TextEdit txtPiece;
        private System.Windows.Forms.Label label5;
    }
}
