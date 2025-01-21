namespace SmartReserve.App.Outros
{
    partial class RelatorioAulasDisp
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
            flowLayoutPanelAulasDisp = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanelAulasDisp
            // 
            flowLayoutPanelAulasDisp.AutoScroll = true;
            flowLayoutPanelAulasDisp.Location = new Point(33, 134);
            flowLayoutPanelAulasDisp.Name = "flowLayoutPanelAulasDisp";
            flowLayoutPanelAulasDisp.Size = new Size(415, 235);
            flowLayoutPanelAulasDisp.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(109, 75);
            label1.Name = "label1";
            label1.Size = new Size(274, 46);
            label1.TabIndex = 1;
            label1.Text = "Aulas disponíveis";
            // 
            // RelatorioAulasDisp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 410);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelAulasDisp);
            Name = "RelatorioAulasDisp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Relatório";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected FlowLayoutPanel flowLayoutPanelAulasDisp;
        public Label label1;
    }
}