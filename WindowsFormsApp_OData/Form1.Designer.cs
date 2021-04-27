
namespace WindowsFormsApp_OData
{
    partial class CharProcuctPrice
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartPriceforProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.downloadData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.selectFiltButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maxPriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPriceforProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPriceforProduct
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPriceforProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPriceforProduct.Legends.Add(legend1);
            this.chartPriceforProduct.Location = new System.Drawing.Point(25, 26);
            this.chartPriceforProduct.Name = "chartPriceforProduct";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Price";
            this.chartPriceforProduct.Series.Add(series1);
            this.chartPriceforProduct.Size = new System.Drawing.Size(909, 463);
            this.chartPriceforProduct.TabIndex = 0;
            this.chartPriceforProduct.Text = "chart1";
            title1.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Price - Product";
            title1.Text = "Price - Product";
            this.chartPriceforProduct.Titles.Add(title1);
            this.chartPriceforProduct.Click += new System.EventHandler(this.PriceProduct_char);
            // 
            // downloadData
            // 
            this.downloadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadData.Location = new System.Drawing.Point(959, 26);
            this.downloadData.Name = "downloadData";
            this.downloadData.Size = new System.Drawing.Size(154, 48);
            this.downloadData.TabIndex = 1;
            this.downloadData.Text = "Download data";
            this.downloadData.UseVisualStyleBackColor = true;
            this.downloadData.Click += new System.EventHandler(this.LoadData_button);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(956, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            this.label1.Click += new System.EventHandler(this.DataShort_label);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(959, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show structure data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowJson_button);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(959, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sort all products";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SortData_button);
            // 
            // selectFiltButton
            // 
            this.selectFiltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectFiltButton.Location = new System.Drawing.Point(1048, 315);
            this.selectFiltButton.Name = "selectFiltButton";
            this.selectFiltButton.Size = new System.Drawing.Size(72, 30);
            this.selectFiltButton.TabIndex = 8;
            this.selectFiltButton.Text = "select";
            this.selectFiltButton.UseVisualStyleBackColor = true;
            this.selectFiltButton.Click += new System.EventHandler(this.FiltrPrice_button);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(959, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxPriceLabel.Location = new System.Drawing.Point(956, 291);
            this.maxPriceLabel.Name = "maxPriceLabel";
            this.maxPriceLabel.Size = new System.Drawing.Size(176, 21);
            this.maxPriceLabel.TabIndex = 10;
            this.maxPriceLabel.Text = "Enter the maximum price:";
            this.maxPriceLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1142, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // CharProcuctPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxPriceLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selectFiltButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downloadData);
            this.Controls.Add(this.chartPriceforProduct);
            this.Name = "CharProcuctPrice";
            this.Text = "Chart Price - Product";
            ((System.ComponentModel.ISupportInitialize)(this.chartPriceforProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPriceforProduct;
        private System.Windows.Forms.Button downloadData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button selectFiltButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label maxPriceLabel;
        private System.Windows.Forms.Label label2;
    }
}

