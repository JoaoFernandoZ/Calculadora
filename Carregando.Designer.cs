namespace Calculadora
{
    partial class Carregando
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carregando));
            label1 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(760, 41);
            label1.TabIndex = 0;
            label1.Text = "Carregando";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 80);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(760, 33);
            progressBar1.TabIndex = 1;
            // 
            // Carregando
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 161);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Carregando";
            Text = "Tela de Carregamento - Calculadora";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
    }
}
