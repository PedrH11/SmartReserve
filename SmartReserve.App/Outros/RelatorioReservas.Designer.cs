namespace SmartReserve.App.Outros
{
    partial class RelatorioReservas
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
            label1 = new Label();
            flowLayoutReservas = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(171, 87);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 0;
            label1.Text = "Reservas efetuadas";
            // 
            // flowLayoutReservas
            // 
            flowLayoutReservas.AutoScroll = true;
            flowLayoutReservas.Location = new Point(30, 127);
            flowLayoutReservas.Name = "flowLayoutReservas";
            flowLayoutReservas.Size = new Size(548, 286);
            flowLayoutReservas.TabIndex = 1;
            // 
            // RelatorioReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(flowLayoutReservas);
            Controls.Add(label1);
            Name = "RelatorioReservas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Relatório";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label label1;
        protected FlowLayoutPanel flowLayoutReservas;
    }
}