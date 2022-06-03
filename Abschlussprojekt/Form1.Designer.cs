namespace Abschlussprojekt
{
    partial class Weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather));
            this.addressinput = new System.Windows.Forms.TextBox();
            this.clearinput = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.latitude = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.precipitationType = new System.Windows.Forms.Label();
            this.precipitationProbability = new System.Windows.Forms.Label();
            this.precipitationIntensity = new System.Windows.Forms.Label();
            this.pDescription = new System.Windows.Forms.TextBox();
            this.pType = new System.Windows.Forms.TextBox();
            this.pProbability = new System.Windows.Forms.TextBox();
            this.pIntensity = new System.Windows.Forms.TextBox();
            this.mm = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressinput
            // 
            this.addressinput.Location = new System.Drawing.Point(35, 12);
            this.addressinput.Name = "addressinput";
            this.addressinput.Size = new System.Drawing.Size(525, 22);
            this.addressinput.TabIndex = 0;
            this.addressinput.Text = "Address of the Location";
            this.addressinput.TextChanged += new System.EventHandler(this.addressinput_TextChanged);
            // 
            // clearinput
            // 
            this.clearinput.Location = new System.Drawing.Point(705, 12);
            this.clearinput.Name = "clearinput";
            this.clearinput.Size = new System.Drawing.Size(75, 25);
            this.clearinput.TabIndex = 1;
            this.clearinput.Text = "&Clear";
            this.clearinput.UseVisualStyleBackColor = true;
            this.clearinput.Click += new System.EventHandler(this.clearinput_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(435, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(635, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(125, 22);
            this.textBox4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Weather";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(35, 40);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(100, 23);
            this.latitude.TabIndex = 0;
            this.latitude.Text = "Latitude";
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(235, 40);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(100, 23);
            this.longitude.TabIndex = 7;
            this.longitude.Text = "Longitude";
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(435, 40);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(100, 23);
            this.temp.TabIndex = 8;
            this.temp.Text = "Temperature";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(635, 40);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 23);
            this.time.TabIndex = 9;
            this.time.Text = "Time (UTC)";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(635, 99);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(100, 23);
            this.description.TabIndex = 17;
            this.description.Text = "Description";
            // 
            // precipitationType
            // 
            this.precipitationType.Location = new System.Drawing.Point(435, 99);
            this.precipitationType.Name = "precipitationType";
            this.precipitationType.Size = new System.Drawing.Size(125, 23);
            this.precipitationType.TabIndex = 16;
            this.precipitationType.Text = "Precipitationtype";
            // 
            // precipitationProbability
            // 
            this.precipitationProbability.Location = new System.Drawing.Point(235, 99);
            this.precipitationProbability.Name = "precipitationProbability";
            this.precipitationProbability.Size = new System.Drawing.Size(163, 23);
            this.precipitationProbability.TabIndex = 15;
            this.precipitationProbability.Text = "Precipitationprobability";
            // 
            // precipitationIntensity
            // 
            this.precipitationIntensity.Location = new System.Drawing.Point(35, 99);
            this.precipitationIntensity.Name = "precipitationIntensity";
            this.precipitationIntensity.Size = new System.Drawing.Size(144, 23);
            this.precipitationIntensity.TabIndex = 10;
            this.precipitationIntensity.Text = "Precipitationintensity";
            // 
            // pDescription
            // 
            this.pDescription.Location = new System.Drawing.Point(635, 125);
            this.pDescription.Name = "pDescription";
            this.pDescription.ReadOnly = true;
            this.pDescription.Size = new System.Drawing.Size(125, 22);
            this.pDescription.TabIndex = 14;
            // 
            // pType
            // 
            this.pType.Location = new System.Drawing.Point(435, 125);
            this.pType.Name = "pType";
            this.pType.ReadOnly = true;
            this.pType.Size = new System.Drawing.Size(125, 22);
            this.pType.TabIndex = 13;
            // 
            // pProbability
            // 
            this.pProbability.Location = new System.Drawing.Point(235, 125);
            this.pProbability.Name = "pProbability";
            this.pProbability.ReadOnly = true;
            this.pProbability.Size = new System.Drawing.Size(125, 22);
            this.pProbability.TabIndex = 12;
            this.pProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pIntensity
            // 
            this.pIntensity.Location = new System.Drawing.Point(35, 125);
            this.pIntensity.Name = "pIntensity";
            this.pIntensity.ReadOnly = true;
            this.pIntensity.Size = new System.Drawing.Size(125, 22);
            this.pIntensity.TabIndex = 11;
            this.pIntensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pIntensity.TextChanged += new System.EventHandler(this.pIntensity_TextChanged);
            // 
            // mm
            // 
            this.mm.AutoSize = true;
            this.mm.Location = new System.Drawing.Point(166, 128);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(29, 16);
            this.mm.TabIndex = 18;
            this.mm.Text = "mm";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(364, 128);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(19, 16);
            this.percentageLabel.TabIndex = 19;
            this.percentageLabel.Text = "%";
            // 
            // Weather
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.description);
            this.Controls.Add(this.precipitationType);
            this.Controls.Add(this.precipitationProbability);
            this.Controls.Add(this.precipitationIntensity);
            this.Controls.Add(this.pDescription);
            this.Controls.Add(this.pType);
            this.Controls.Add(this.pProbability);
            this.Controls.Add(this.pIntensity);
            this.Controls.Add(this.time);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clearinput);
            this.Controls.Add(this.addressinput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Weather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Weather_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressinput;
        private System.Windows.Forms.Button clearinput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label longitude;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label precipitationType;
        private System.Windows.Forms.Label precipitationProbability;
        private System.Windows.Forms.Label precipitationIntensity;
        private System.Windows.Forms.TextBox pDescription;
        private System.Windows.Forms.TextBox pType;
        private System.Windows.Forms.TextBox pProbability;
        private System.Windows.Forms.TextBox pIntensity;
        private System.Windows.Forms.Label mm;
        private System.Windows.Forms.Label percentageLabel;
    }
}

