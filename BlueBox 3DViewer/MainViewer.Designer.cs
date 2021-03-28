
namespace BlueBox_3DViewer
{
    partial class MainViewer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.objViewer1 = new wpfcomponent.OBJViewer();
            this.bOpenOBJ = new System.Windows.Forms.Button();
            this.bOpenFBX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Location = new System.Drawing.Point(12, 68);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(951, 647);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.objViewer1;
            // 
            // bOpenOBJ
            // 
            this.bOpenOBJ.Location = new System.Drawing.Point(12, 12);
            this.bOpenOBJ.Name = "bOpenOBJ";
            this.bOpenOBJ.Size = new System.Drawing.Size(197, 50);
            this.bOpenOBJ.TabIndex = 1;
            this.bOpenOBJ.Text = "Open 3D model\r\nobj, 3ds, stl, more...";
            this.bOpenOBJ.UseVisualStyleBackColor = true;
            // 
            // bOpenFBX
            // 
            this.bOpenFBX.Location = new System.Drawing.Point(215, 12);
            this.bOpenFBX.Name = "bOpenFBX";
            this.bOpenFBX.Size = new System.Drawing.Size(197, 50);
            this.bOpenFBX.TabIndex = 1;
            this.bOpenFBX.Text = "Open 3D model\r\nFBX ONLY";
            this.bOpenFBX.UseVisualStyleBackColor = true;
            // 
            // MainViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 727);
            this.Controls.Add(this.bOpenFBX);
            this.Controls.Add(this.bOpenOBJ);
            this.Controls.Add(this.elementHost1);
            this.Name = "MainViewer";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private wpfcomponent.OBJViewer objViewer1;
        private System.Windows.Forms.Button bOpenOBJ;
        private System.Windows.Forms.Button bOpenFBX;
    }
}

