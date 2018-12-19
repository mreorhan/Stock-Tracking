namespace TestDevx
{
    partial class ucAddProduct
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtProductFeatures = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPRoduct = new DevExpress.XtraEditors.SimpleButton();
            this.datePurchasedDate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPiece = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductFeatures.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiece.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtProductName
            // 
            this.txtProductName.EditValue = "";
            this.txtProductName.Location = new System.Drawing.Point(80, 134);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtProductName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtProductName.Properties.Mask.EditMask = "\\p{L}+";
            this.txtProductName.Size = new System.Drawing.Size(250, 34);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductFeatures
            // 
            this.txtProductFeatures.EditValue = "";
            this.txtProductFeatures.Location = new System.Drawing.Point(393, 134);
            this.txtProductFeatures.Name = "txtProductFeatures";
            this.txtProductFeatures.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductFeatures.Properties.Appearance.Options.UseFont = true;
            this.txtProductFeatures.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtProductFeatures.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtProductFeatures.Properties.Mask.EditMask = "\\p{L}+";
            this.txtProductFeatures.Size = new System.Drawing.Size(470, 34);
            this.txtProductFeatures.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(389, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Özellikleri:";
            // 
            // btnAddPRoduct
            // 
            this.btnAddPRoduct.Location = new System.Drawing.Point(699, 352);
            this.btnAddPRoduct.Name = "btnAddPRoduct";
            this.btnAddPRoduct.Size = new System.Drawing.Size(164, 49);
            this.btnAddPRoduct.TabIndex = 4;
            this.btnAddPRoduct.Text = "Add Product";
            this.btnAddPRoduct.Click += new System.EventHandler(this.btnAddPRoduct_Click);
            // 
            // datePurchasedDate
            // 
            this.datePurchasedDate.EditValue = null;
            this.datePurchasedDate.Location = new System.Drawing.Point(80, 252);
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
            this.datePurchasedDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.datePurchasedDate.Size = new System.Drawing.Size(250, 34);
            this.datePurchasedDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Satın Alma Tarihi:";
            // 
            // txtPrice
            // 
            this.txtPrice.EditValue = "";
            this.txtPrice.Location = new System.Drawing.Point(393, 252);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPrice.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtPrice.Properties.Mask.BeepOnError = true;
            this.txtPrice.Properties.Mask.EditMask = "c";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Size = new System.Drawing.Size(192, 34);
            this.txtPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(389, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Fiyatı:";
            // 
            // txtPiece
            // 
            this.txtPiece.EditValue = "";
            this.txtPiece.Location = new System.Drawing.Point(619, 252);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPiece.Properties.Appearance.Options.UseFont = true;
            this.txtPiece.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPiece.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtPiece.Properties.Mask.BeepOnError = true;
            this.txtPiece.Properties.Mask.EditMask = "\\d+";
            this.txtPiece.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPiece.Size = new System.Drawing.Size(120, 34);
            this.txtPiece.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(615, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ürün Adedi:";
            // 
            // ucAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPiece);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePurchasedDate);
            this.Controls.Add(this.btnAddPRoduct);
            this.Controls.Add(this.txtProductFeatures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Name = "ucAddProduct";
            this.Size = new System.Drawing.Size(926, 486);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductFeatures.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiece.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtProductFeatures;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnAddPRoduct;
        private DevExpress.XtraEditors.DateEdit datePurchasedDate;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtPiece;
        private System.Windows.Forms.Label label5;
    }
}
