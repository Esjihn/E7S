namespace E7S
{
    partial class ArrowUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpFacingDirection = new System.Windows.Forms.Button();
            this.btnLeftFacingDirection = new System.Windows.Forms.Button();
            this.btnDownFacingDirection = new System.Windows.Forms.Button();
            this.btnRightFacingDirection = new System.Windows.Forms.Button();
            this.btnRightTeleportDirection = new System.Windows.Forms.Button();
            this.btnDownTeleportDirection = new System.Windows.Forms.Button();
            this.btnLeftTeleportDirection = new System.Windows.Forms.Button();
            this.btnUpTeleportDirection = new System.Windows.Forms.Button();
            this.lblTeleportDirection = new System.Windows.Forms.Label();
            this.lblDirectionWanted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpFacingDirection
            // 
            this.btnUpFacingDirection.Location = new System.Drawing.Point(56, 59);
            this.btnUpFacingDirection.Name = "btnUpFacingDirection";
            this.btnUpFacingDirection.Size = new System.Drawing.Size(45, 34);
            this.btnUpFacingDirection.TabIndex = 0;
            this.btnUpFacingDirection.UseVisualStyleBackColor = true;
            // 
            // btnLeftFacingDirection
            // 
            this.btnLeftFacingDirection.Location = new System.Drawing.Point(21, 99);
            this.btnLeftFacingDirection.Name = "btnLeftFacingDirection";
            this.btnLeftFacingDirection.Size = new System.Drawing.Size(45, 34);
            this.btnLeftFacingDirection.TabIndex = 0;
            this.btnLeftFacingDirection.UseVisualStyleBackColor = true;
            // 
            // btnDownFacingDirection
            // 
            this.btnDownFacingDirection.Location = new System.Drawing.Point(56, 139);
            this.btnDownFacingDirection.Name = "btnDownFacingDirection";
            this.btnDownFacingDirection.Size = new System.Drawing.Size(45, 34);
            this.btnDownFacingDirection.TabIndex = 0;
            this.btnDownFacingDirection.UseVisualStyleBackColor = true;
            // 
            // btnRightFacingDirection
            // 
            this.btnRightFacingDirection.Location = new System.Drawing.Point(91, 99);
            this.btnRightFacingDirection.Name = "btnRightFacingDirection";
            this.btnRightFacingDirection.Size = new System.Drawing.Size(45, 34);
            this.btnRightFacingDirection.TabIndex = 0;
            this.btnRightFacingDirection.UseVisualStyleBackColor = true;
            // 
            // btnRightTeleportDirection
            // 
            this.btnRightTeleportDirection.Location = new System.Drawing.Point(244, 99);
            this.btnRightTeleportDirection.Name = "btnRightTeleportDirection";
            this.btnRightTeleportDirection.Size = new System.Drawing.Size(45, 34);
            this.btnRightTeleportDirection.TabIndex = 0;
            this.btnRightTeleportDirection.UseVisualStyleBackColor = true;
            // 
            // btnDownTeleportDirection
            // 
            this.btnDownTeleportDirection.Location = new System.Drawing.Point(209, 139);
            this.btnDownTeleportDirection.Name = "btnDownTeleportDirection";
            this.btnDownTeleportDirection.Size = new System.Drawing.Size(45, 34);
            this.btnDownTeleportDirection.TabIndex = 0;
            this.btnDownTeleportDirection.UseVisualStyleBackColor = true;
            // 
            // btnLeftTeleportDirection
            // 
            this.btnLeftTeleportDirection.Location = new System.Drawing.Point(174, 99);
            this.btnLeftTeleportDirection.Name = "btnLeftTeleportDirection";
            this.btnLeftTeleportDirection.Size = new System.Drawing.Size(45, 34);
            this.btnLeftTeleportDirection.TabIndex = 0;
            this.btnLeftTeleportDirection.UseVisualStyleBackColor = true;
            // 
            // btnUpTeleportDirection
            // 
            this.btnUpTeleportDirection.Location = new System.Drawing.Point(209, 59);
            this.btnUpTeleportDirection.Name = "btnUpTeleportDirection";
            this.btnUpTeleportDirection.Size = new System.Drawing.Size(45, 34);
            this.btnUpTeleportDirection.TabIndex = 0;
            this.btnUpTeleportDirection.UseVisualStyleBackColor = true;
            // 
            // lblTeleportDirection
            // 
            this.lblTeleportDirection.AutoSize = true;
            this.lblTeleportDirection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTeleportDirection.Location = new System.Drawing.Point(0, 37);
            this.lblTeleportDirection.Name = "lblTeleportDirection";
            this.lblTeleportDirection.Size = new System.Drawing.Size(144, 19);
            this.lblTeleportDirection.TabIndex = 1;
            this.lblTeleportDirection.Text = "Teleport Direction";
            // 
            // lblDirectionWanted
            // 
            this.lblDirectionWanted.AutoSize = true;
            this.lblDirectionWanted.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDirectionWanted.Location = new System.Drawing.Point(159, 37);
            this.lblDirectionWanted.Name = "lblDirectionWanted";
            this.lblDirectionWanted.Size = new System.Drawing.Size(139, 19);
            this.lblDirectionWanted.TabIndex = 1;
            this.lblDirectionWanted.Text = "Direction Wanted";
            // 
            // ArrowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.lblDirectionWanted);
            this.Controls.Add(this.lblTeleportDirection);
            this.Controls.Add(this.btnUpTeleportDirection);
            this.Controls.Add(this.btnLeftTeleportDirection);
            this.Controls.Add(this.btnDownTeleportDirection);
            this.Controls.Add(this.btnRightTeleportDirection);
            this.Controls.Add(this.btnRightFacingDirection);
            this.Controls.Add(this.btnDownFacingDirection);
            this.Controls.Add(this.btnLeftFacingDirection);
            this.Controls.Add(this.btnUpFacingDirection);
            this.Name = "ArrowUserControl";
            this.Size = new System.Drawing.Size(510, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpFacingDirection;
        private System.Windows.Forms.Button btnLeftFacingDirection;
        private System.Windows.Forms.Button btnDownFacingDirection;
        private System.Windows.Forms.Button btnRightFacingDirection;
        private System.Windows.Forms.Button btnRightTeleportDirection;
        private System.Windows.Forms.Button btnDownTeleportDirection;
        private System.Windows.Forms.Button btnLeftTeleportDirection;
        private System.Windows.Forms.Button btnUpTeleportDirection;
        private System.Windows.Forms.Label lblTeleportDirection;
        private System.Windows.Forms.Label lblDirectionWanted;
    }
}
