
namespace ParcialDeJohnDoe.Windows
{
    partial class frmCubosAE
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
            this.components = new System.ComponentModel.Container();
            this.RellenoComboBox = new System.Windows.Forms.ComboBox();
            this.AristaTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PuntosRadioButton = new System.Windows.Forms.RadioButton();
            this.RayasRadioButton = new System.Windows.Forms.RadioButton();
            this.ContinuoRadioButton = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RellenoComboBox
            // 
            this.RellenoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RellenoComboBox.FormattingEnabled = true;
            this.RellenoComboBox.Location = new System.Drawing.Point(171, 71);
            this.RellenoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RellenoComboBox.Name = "RellenoComboBox";
            this.RellenoComboBox.Size = new System.Drawing.Size(371, 24);
            this.RellenoComboBox.TabIndex = 58;
            // 
            // AristaTextBox
            // 
            this.AristaTextBox.Location = new System.Drawing.Point(171, 36);
            this.AristaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AristaTextBox.MaxLength = 50;
            this.AristaTextBox.Name = "AristaTextBox";
            this.AristaTextBox.Size = new System.Drawing.Size(371, 22);
            this.AristaTextBox.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(425, 226);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 75);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(33, 226);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 75);
            this.btnOK.TabIndex = 54;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Relleno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Arista:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PuntosRadioButton);
            this.groupBox1.Controls.Add(this.RayasRadioButton);
            this.groupBox1.Controls.Add(this.ContinuoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(171, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(324, 80);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Trazo ";
            // 
            // PuntosRadioButton
            // 
            this.PuntosRadioButton.AutoSize = true;
            this.PuntosRadioButton.Location = new System.Drawing.Point(187, 23);
            this.PuntosRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PuntosRadioButton.Name = "PuntosRadioButton";
            this.PuntosRadioButton.Size = new System.Drawing.Size(73, 21);
            this.PuntosRadioButton.TabIndex = 1;
            this.PuntosRadioButton.Text = "Puntos";
            this.PuntosRadioButton.UseVisualStyleBackColor = true;
            // 
            // RayasRadioButton
            // 
            this.RayasRadioButton.AutoSize = true;
            this.RayasRadioButton.Location = new System.Drawing.Point(105, 23);
            this.RayasRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RayasRadioButton.Name = "RayasRadioButton";
            this.RayasRadioButton.Size = new System.Drawing.Size(69, 21);
            this.RayasRadioButton.TabIndex = 1;
            this.RayasRadioButton.Text = "Rayas";
            this.RayasRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContinuoRadioButton
            // 
            this.ContinuoRadioButton.AutoSize = true;
            this.ContinuoRadioButton.Checked = true;
            this.ContinuoRadioButton.Location = new System.Drawing.Point(8, 23);
            this.ContinuoRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContinuoRadioButton.Name = "ContinuoRadioButton";
            this.ContinuoRadioButton.Size = new System.Drawing.Size(85, 21);
            this.ContinuoRadioButton.TabIndex = 0;
            this.ContinuoRadioButton.TabStop = true;
            this.ContinuoRadioButton.Text = "Continuo";
            this.ContinuoRadioButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCubosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 318);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RellenoComboBox);
            this.Controls.Add(this.AristaTextBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCubosAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RellenoComboBox;
        private System.Windows.Forms.TextBox AristaTextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PuntosRadioButton;
        private System.Windows.Forms.RadioButton RayasRadioButton;
        private System.Windows.Forms.RadioButton ContinuoRadioButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}