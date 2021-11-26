
namespace StarNewHotelDesktop.Screens
{
    partial class QuartosOcupadosScreen
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
            this.dgvQuarto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuarto
            // 
            this.dgvQuarto.AllowUserToAddRows = false;
            this.dgvQuarto.AllowUserToDeleteRows = false;
            this.dgvQuarto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuarto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuarto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuarto.Location = new System.Drawing.Point(11, 7);
            this.dgvQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuarto.Name = "dgvQuarto";
            this.dgvQuarto.ReadOnly = true;
            this.dgvQuarto.RowHeadersVisible = false;
            this.dgvQuarto.RowHeadersWidth = 51;
            this.dgvQuarto.RowTemplate.Height = 24;
            this.dgvQuarto.Size = new System.Drawing.Size(486, 334);
            this.dgvQuarto.TabIndex = 33;
            // 
            // QuartosOcupadosScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 352);
            this.Controls.Add(this.dgvQuarto);
            this.Name = "QuartosOcupadosScreen";
            this.Text = "QuartosOcupadosScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuarto;
    }
}