namespace Exc2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new DevComponents.DotNetBar.LabelX();
            this.txtNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNumRomana = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnRomana = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnSair = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lbl
            // 
            // 
            // 
            // 
            this.lbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(12, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(230, 53);
            this.lbl.Symbol = "58138";
            this.lbl.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl.TabIndex = 0;
            this.lbl.Text = " Insira Um Número";
            // 
            // txtNum
            // 
            // 
            // 
            // 
            this.txtNum.Border.Class = "TextBoxBorder";
            this.txtNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNum.Location = new System.Drawing.Point(249, 24);
            this.txtNum.Name = "txtNum";
            this.txtNum.PreventEnterBeep = true;
            this.txtNum.Size = new System.Drawing.Size(335, 30);
            this.txtNum.TabIndex = 0;
            // 
            // txtNumRomana
            // 
            // 
            // 
            // 
            this.txtNumRomana.Border.Class = "TextBoxBorder";
            this.txtNumRomana.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNumRomana.Location = new System.Drawing.Point(12, 158);
            this.txtNumRomana.Name = "txtNumRomana";
            this.txtNumRomana.PreventEnterBeep = true;
            this.txtNumRomana.ReadOnly = true;
            this.txtNumRomana.Size = new System.Drawing.Size(572, 30);
            this.txtNumRomana.TabIndex = 2;
            // 
            // btnRomana
            // 
            this.btnRomana.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRomana.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnRomana.Location = new System.Drawing.Point(12, 85);
            this.btnRomana.Name = "btnRomana";
            this.btnRomana.Size = new System.Drawing.Size(134, 48);
            this.btnRomana.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRomana.Symbol = "";
            this.btnRomana.TabIndex = 3;
            this.btnRomana.Text = " Romana";
            this.btnRomana.Click += new System.EventHandler(this.btnRomana_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnGuardar.Location = new System.Drawing.Point(224, 85);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 48);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.Symbol = "";
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = " Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSair.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnSair.Location = new System.Drawing.Point(449, 85);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 48);
            this.btnSair.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSair.Symbol = "";
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = " Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(596, 200);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRomana);
            this.Controls.Add(this.txtNumRomana);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNum;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNumRomana;
        private DevComponents.DotNetBar.ButtonX btnRomana;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.ButtonX btnSair;
    }
}

