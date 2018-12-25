namespace TestDevx
{
    partial class ucEditProduct
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
            this.txtPiece = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductFeatures = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datePurchasedDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiece.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductFeatures.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPiece
            // 
            this.txtPiece.EditValue = "";
            this.txtPiece.Enabled = false;
            this.txtPiece.Location = new System.Drawing.Point(441, 372);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPiece.Properties.Appearance.Options.UseFont = true;
            this.txtPiece.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPiece.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtPiece.Properties.Mask.BeepOnError = true;
            this.txtPiece.Properties.Mask.EditMask = "\\d+";
            this.txtPiece.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPiece.Properties.MaxLength = 5;
            this.txtPiece.Size = new System.Drawing.Size(120, 34);
            this.txtPiece.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(437, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pieces:";
            // 
            // txtProductFeatures
            // 
            this.txtProductFeatures.EditValue = "";
            this.txtProductFeatures.Location = new System.Drawing.Point(440, 255);
            this.txtProductFeatures.Name = "txtProductFeatures";
            this.txtProductFeatures.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductFeatures.Properties.Appearance.Options.UseFont = true;
            this.txtProductFeatures.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtProductFeatures.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtProductFeatures.Properties.Mask.EditMask = "\\p{L}+";
            this.txtProductFeatures.Properties.MaxLength = 50;
            this.txtProductFeatures.Size = new System.Drawing.Size(470, 34);
            this.txtProductFeatures.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(436, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product Features:";
            // 
            // txtProductName
            // 
            this.txtProductName.EditValue = "";
            this.txtProductName.Location = new System.Drawing.Point(94, 255);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtProductName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtProductName.Properties.Mask.EditMask = "\\p{L}+";
            this.txtProductName.Properties.MaxLength = 50;
            this.txtProductName.Size = new System.Drawing.Size(280, 34);
            this.txtProductName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product Name:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.5708F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.4292F));
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveProduct, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 451);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 75);
            this.tableLayoutPanel1.TabIndex = 21;
            this.tableLayoutPanel1.Visible = false;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(773, 13);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(168, 49);
            this.btnRemoveProduct.TabIndex = 7;
            this.btnRemoveProduct.Text = "Edit Product";
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(92, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Choose Product:";
            // 
            // cbProducts
            // 
            this.cbProducts.DropDownWidth = 350;
            this.cbProducts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbProducts.Location = new System.Drawing.Point(94, 131);
            this.cbProducts.Margin = new System.Windows.Forms.Padding(8);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(470, 33);
            this.cbProducts.TabIndex = 22;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            this.cbProducts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbProducts_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Purchased Date:";
            // 
            // datePurchasedDate
            // 
            this.datePurchasedDate.EditValue = null;
            this.datePurchasedDate.Enabled = false;
            this.datePurchasedDate.Location = new System.Drawing.Point(94, 373);
            this.datePurchasedDate.Name = "datePurchasedDate";
            this.datePurchasedDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.datePurchasedDate.Properties.Appearance.Options.UseFont = true;
            this.datePurchasedDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.datePurchasedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePurchasedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePurchasedDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.datePurchasedDate.Properties.Mask.BeepOnError = true;
            this.datePurchasedDate.Properties.Mask.EditMask = "f";
            this.datePurchasedDate.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.datePurchasedDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.datePurchasedDate.Size = new System.Drawing.Size(280, 34);
            this.datePurchasedDate.TabIndex = 15;
            // 
            // ucEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtPiece);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePurchasedDate);
            this.Controls.Add(this.txtProductFeatures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Name = "ucEditProduct";
            this.Size = new System.Drawing.Size(964, 526);
            this.Load += new System.EventHandler(this.ucEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPiece.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductFeatures.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPiece;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtProductFeatures;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnRemoveProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit datePurchasedDate;
    }
}
