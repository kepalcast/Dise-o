namespace TrabajoFinal
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
            this.btnCrearCuenta = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnIniciarSesion = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.AutoSize = true;
            this.btnCrearCuenta.Depth = 0;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearCuenta.Location = new System.Drawing.Point(174, 174);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrearCuenta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnCrearCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Ripple = true;
            this.btnCrearCuenta.Size = new System.Drawing.Size(153, 30);
            this.btnCrearCuenta.TabIndex = 1;
            this.btnCrearCuenta.TabStop = true;
            this.btnCrearCuenta.Text = "NO TENGO CUENTA";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(174, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(297, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "MARQUE LA OPCIÓN DE SU PREFERENCIA";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoSize = true;
            this.btnIniciarSesion.Depth = 0;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarSesion.Location = new System.Drawing.Point(349, 174);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciarSesion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnIniciarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Ripple = true;
            this.btnIniciarSesion.Size = new System.Drawing.Size(130, 30);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.TabStop = true;
            this.btnIniciarSesion.Text = "TENGO CUENTA";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.CheckedChanged += new System.EventHandler(this.btnIniciarSesion_CheckedChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(174, 86);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(305, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "¡BIENVENIDO A TU BANCO DE CONFIANZA!";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(430, 224);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 284);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnCrearCuenta);
            this.Name = "Form1";
            this.Text = "BANCO NACIONAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRadioButton btnCrearCuenta;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton btnIniciarSesion;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
    }
}