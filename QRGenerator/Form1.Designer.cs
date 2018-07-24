namespace QRGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnGenerarQR = new DevComponents.DotNetBar.ButtonX();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtCadena = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // btnGenerarQR
            // 
            this.btnGenerarQR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerarQR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGenerarQR.Location = new System.Drawing.Point(242, 11);
            this.btnGenerarQR.Name = "btnGenerarQR";
            this.btnGenerarQR.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarQR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGenerarQR.TabIndex = 0;
            this.btnGenerarQR.Text = "Generar QR";
            this.btnGenerarQR.Click += new System.EventHandler(this.btnGenerarQR_Click);
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(67, 76);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(193, 191);
            this.picQR.TabIndex = 1;
            this.picQR.TabStop = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(89, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Contenido QR : ";
            // 
            // txtCadena
            // 
            this.txtCadena.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCadena.Border.Class = "TextBoxBorder";
            this.txtCadena.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCadena.DisabledBackColor = System.Drawing.Color.White;
            this.txtCadena.ForeColor = System.Drawing.Color.Black;
            this.txtCadena.Location = new System.Drawing.Point(98, 14);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.PreventEnterBeep = true;
            this.txtCadena.Size = new System.Drawing.Size(138, 20);
            this.txtCadena.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 306);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.btnGenerarQR);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Generador de QR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnGenerarQR;
        private System.Windows.Forms.PictureBox picQR;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCadena;
    }
}

