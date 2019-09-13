namespace ApartmentSmart
{
    partial class frmrptPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrptPayment));
            this.crvShow = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvShow
            // 
            this.crvShow.ActiveViewIndex = -1;
            this.crvShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvShow.DisplayStatusBar = false;
            this.crvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvShow.Location = new System.Drawing.Point(0, 0);
            this.crvShow.Name = "crvShow";
            this.crvShow.Size = new System.Drawing.Size(836, 629);
            this.crvShow.TabIndex = 0;
            this.crvShow.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmrptPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 629);
            this.Controls.Add(this.crvShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrptPayment";
            this.Load += new System.EventHandler(this.frmrptContract_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvShow;
    }
}