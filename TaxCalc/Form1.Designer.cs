namespace TaxCalc
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pricetBox = new System.Windows.Forms.TextBox();
            this.taxPriceBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pricetBox
            // 
            this.pricetBox.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pricetBox.Location = new System.Drawing.Point(249, 55);
            this.pricetBox.Name = "pricetBox";
            this.pricetBox.Size = new System.Drawing.Size(421, 29);
            this.pricetBox.TabIndex = 0;
            this.pricetBox.TextChanged += new System.EventHandler(this.pricetBox_TextChanged);
            // 
            // taxPriceBox
            // 
            this.taxPriceBox.Enabled = false;
            this.taxPriceBox.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.taxPriceBox.Location = new System.Drawing.Point(249, 155);
            this.taxPriceBox.Name = "taxPriceBox";
            this.taxPriceBox.Size = new System.Drawing.Size(420, 29);
            this.taxPriceBox.TabIndex = 1;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.calcButton.Location = new System.Drawing.Point(500, 265);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(170, 58);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "計算する";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(64, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "税抜価格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(67, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "税込価格";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.taxPriceBox);
            this.Controls.Add(this.pricetBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pricetBox;
        private System.Windows.Forms.TextBox taxPriceBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

