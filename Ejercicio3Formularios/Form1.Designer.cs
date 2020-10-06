namespace Ejercicio3Formularios
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
            this.cdlMenuColor = new System.Windows.Forms.ColorDialog();
            this.fdlMenuFuente = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTexto = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnTipoLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige el color de fondo de este formulario y el tipo de letra del cuadro de texto" +
    "";
            // 
            // txbTexto
            // 
            this.txbTexto.Location = new System.Drawing.Point(246, 233);
            this.txbTexto.Name = "txbTexto";
            this.txbTexto.Size = new System.Drawing.Size(156, 22);
            this.txbTexto.TabIndex = 1;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(142, 153);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnTipoLetra
            // 
            this.btnTipoLetra.Location = new System.Drawing.Point(535, 153);
            this.btnTipoLetra.Name = "btnTipoLetra";
            this.btnTipoLetra.Size = new System.Drawing.Size(111, 23);
            this.btnTipoLetra.TabIndex = 3;
            this.btnTipoLetra.Text = "Tipo de letra";
            this.btnTipoLetra.UseVisualStyleBackColor = true;
            this.btnTipoLetra.Click += new System.EventHandler(this.btnTipoLetra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTipoLetra);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txbTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog cdlMenuColor;
        private System.Windows.Forms.FontDialog fdlMenuFuente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTexto;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnTipoLetra;
    }
}

