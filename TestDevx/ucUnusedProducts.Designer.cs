namespace TestDevx
{
    partial class ucUnusedProducts
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
            this.gridUnused = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUnused
            // 
            this.gridUnused.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUnused.Location = new System.Drawing.Point(0, 0);
            this.gridUnused.MainView = this.gridView1;
            this.gridUnused.Name = "gridUnused";
            this.gridUnused.Size = new System.Drawing.Size(726, 475);
            this.gridUnused.TabIndex = 0;
            this.gridUnused.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridUnused;
            this.gridView1.Name = "gridView1";
            // 
            // ucUnusedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridUnused);
            this.Name = "ucUnusedProducts";
            this.Size = new System.Drawing.Size(726, 475);
            ((System.ComponentModel.ISupportInitialize)(this.gridUnused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridUnused;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
