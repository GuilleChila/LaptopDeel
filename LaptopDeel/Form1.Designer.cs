namespace LaptopDeel
{
    partial class Form1
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
            label1 = new Label();
            kryptonWorkspace1 = new Krypton.Workspace.KryptonWorkspace();
            ((System.ComponentModel.ISupportInitialize)kryptonWorkspace1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 118);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // kryptonWorkspace1
            // 
            kryptonWorkspace1.ActivePage = null;
            kryptonWorkspace1.CompactFlags = Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences | Krypton.Workspace.CompactFlags.PromoteLeafs | Krypton.Workspace.CompactFlags.AtLeastOneVisibleCell;
            kryptonWorkspace1.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            kryptonWorkspace1.Location = new Point(157, 143);
            kryptonWorkspace1.Name = "kryptonWorkspace1";
            // 
            // 
            // 
            kryptonWorkspace1.Root.UniqueName = "7397db378ccf47e1b4b3912207727fa8";
            kryptonWorkspace1.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile;
            kryptonWorkspace1.Size = new Size(301, 151);
            kryptonWorkspace1.SplitterWidth = 5;
            kryptonWorkspace1.TabIndex = 1;
            kryptonWorkspace1.TabStop = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kryptonWorkspace1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)kryptonWorkspace1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Krypton.Workspace.KryptonWorkspace kryptonWorkspace1;
    }
}
