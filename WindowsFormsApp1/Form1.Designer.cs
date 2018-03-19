namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Palindrome_Button = new System.Windows.Forms.Button();
            this.Palindrome_Input_Textbox = new System.Windows.Forms.TextBox();
            this.Palindrome_Input_Label = new System.Windows.Forms.Label();
            this.Buying_And_Selling_Button = new System.Windows.Forms.Button();
            this.Find_Palindrome_Activation_Button = new System.Windows.Forms.Button();
            this.Palindrome_Output = new System.Windows.Forms.TextBox();
            this.Find_If_Palindrome_Button = new System.Windows.Forms.Button();
            this.Buying_And_Selling_Start_Button = new System.Windows.Forms.Button();
            this.BAS_Num_Threads_input = new System.Windows.Forms.TextBox();
            this.BAS_Num_Products_Input = new System.Windows.Forms.TextBox();
            this.BAS_Thread_Label = new System.Windows.Forms.Label();
            this.BAS_Product_Num_Label = new System.Windows.Forms.Label();
            this.P2_Warships_To_Spawn = new System.Windows.Forms.TextBox();
            this.BAS_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Step_BAS_Simulation_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BAS_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Palindrome_Button
            // 
            this.Palindrome_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Palindrome_Button.Location = new System.Drawing.Point(12, 26);
            this.Palindrome_Button.Name = "Palindrome_Button";
            this.Palindrome_Button.Size = new System.Drawing.Size(696, 75);
            this.Palindrome_Button.TabIndex = 0;
            this.Palindrome_Button.Text = "Palindrome";
            this.Palindrome_Button.UseVisualStyleBackColor = true;
            this.Palindrome_Button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Palindrome_Input_Textbox
            // 
            this.Palindrome_Input_Textbox.Location = new System.Drawing.Point(817, 70);
            this.Palindrome_Input_Textbox.Name = "Palindrome_Input_Textbox";
            this.Palindrome_Input_Textbox.Size = new System.Drawing.Size(570, 31);
            this.Palindrome_Input_Textbox.TabIndex = 1;
            this.Palindrome_Input_Textbox.Visible = false;
            this.Palindrome_Input_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Palindrome_Input_Textbox_KeyDown);
            // 
            // Palindrome_Input_Label
            // 
            this.Palindrome_Input_Label.AutoSize = true;
            this.Palindrome_Input_Label.Location = new System.Drawing.Point(812, 32);
            this.Palindrome_Input_Label.Name = "Palindrome_Input_Label";
            this.Palindrome_Input_Label.Size = new System.Drawing.Size(205, 25);
            this.Palindrome_Input_Label.TabIndex = 3;
            this.Palindrome_Input_Label.Text = "Input string to check";
            this.Palindrome_Input_Label.Visible = false;
            // 
            // Buying_And_Selling_Button
            // 
            this.Buying_And_Selling_Button.Location = new System.Drawing.Point(12, 126);
            this.Buying_And_Selling_Button.Name = "Buying_And_Selling_Button";
            this.Buying_And_Selling_Button.Size = new System.Drawing.Size(696, 75);
            this.Buying_And_Selling_Button.TabIndex = 5;
            this.Buying_And_Selling_Button.Text = "Buying And Selling";
            this.Buying_And_Selling_Button.UseVisualStyleBackColor = true;
            this.Buying_And_Selling_Button.Click += new System.EventHandler(this.Buying_And_Selling_Click);
            // 
            // Find_Palindrome_Activation_Button
            // 
            this.Find_Palindrome_Activation_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Find_Palindrome_Activation_Button.Location = new System.Drawing.Point(817, 107);
            this.Find_Palindrome_Activation_Button.Name = "Find_Palindrome_Activation_Button";
            this.Find_Palindrome_Activation_Button.Size = new System.Drawing.Size(256, 45);
            this.Find_Palindrome_Activation_Button.TabIndex = 9;
            this.Find_Palindrome_Activation_Button.Text = "Find Largest Palindrome";
            this.Find_Palindrome_Activation_Button.UseVisualStyleBackColor = true;
            this.Find_Palindrome_Activation_Button.Visible = false;
            this.Find_Palindrome_Activation_Button.Click += new System.EventHandler(this.Find_Palindrome_Activation_Button_Click);
            // 
            // Palindrome_Output
            // 
            this.Palindrome_Output.Location = new System.Drawing.Point(817, 158);
            this.Palindrome_Output.Name = "Palindrome_Output";
            this.Palindrome_Output.ReadOnly = true;
            this.Palindrome_Output.Size = new System.Drawing.Size(570, 31);
            this.Palindrome_Output.TabIndex = 10;
            this.Palindrome_Output.Visible = false;
            // 
            // Find_If_Palindrome_Button
            // 
            this.Find_If_Palindrome_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Find_If_Palindrome_Button.Location = new System.Drawing.Point(1079, 107);
            this.Find_If_Palindrome_Button.Name = "Find_If_Palindrome_Button";
            this.Find_If_Palindrome_Button.Size = new System.Drawing.Size(308, 45);
            this.Find_If_Palindrome_Button.TabIndex = 11;
            this.Find_If_Palindrome_Button.Text = "Check If Input Is Palindrome";
            this.Find_If_Palindrome_Button.UseVisualStyleBackColor = true;
            this.Find_If_Palindrome_Button.Visible = false;
            this.Find_If_Palindrome_Button.Click += new System.EventHandler(this.Find_If_Palindrome_Button_Click);
            // 
            // Buying_And_Selling_Start_Button
            // 
            this.Buying_And_Selling_Start_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Buying_And_Selling_Start_Button.Location = new System.Drawing.Point(817, 107);
            this.Buying_And_Selling_Start_Button.Name = "Buying_And_Selling_Start_Button";
            this.Buying_And_Selling_Start_Button.Size = new System.Drawing.Size(256, 45);
            this.Buying_And_Selling_Start_Button.TabIndex = 12;
            this.Buying_And_Selling_Start_Button.Text = "Start Simulation";
            this.Buying_And_Selling_Start_Button.UseVisualStyleBackColor = true;
            this.Buying_And_Selling_Start_Button.Visible = false;
            this.Buying_And_Selling_Start_Button.Click += new System.EventHandler(this.Buying_And_Selling_Start_Button_Click);
            // 
            // BAS_Num_Threads_input
            // 
            this.BAS_Num_Threads_input.Location = new System.Drawing.Point(817, 70);
            this.BAS_Num_Threads_input.Name = "BAS_Num_Threads_input";
            this.BAS_Num_Threads_input.Size = new System.Drawing.Size(283, 31);
            this.BAS_Num_Threads_input.TabIndex = 13;
            this.BAS_Num_Threads_input.Visible = false;
            // 
            // BAS_Num_Products_Input
            // 
            this.BAS_Num_Products_Input.Location = new System.Drawing.Point(1108, 70);
            this.BAS_Num_Products_Input.Name = "BAS_Num_Products_Input";
            this.BAS_Num_Products_Input.Size = new System.Drawing.Size(256, 31);
            this.BAS_Num_Products_Input.TabIndex = 14;
            this.BAS_Num_Products_Input.Visible = false;
            // 
            // BAS_Thread_Label
            // 
            this.BAS_Thread_Label.AutoSize = true;
            this.BAS_Thread_Label.Location = new System.Drawing.Point(812, 32);
            this.BAS_Thread_Label.Name = "BAS_Thread_Label";
            this.BAS_Thread_Label.Size = new System.Drawing.Size(288, 25);
            this.BAS_Thread_Label.TabIndex = 15;
            this.BAS_Thread_Label.Text = "Number of Threads to spawn";
            this.BAS_Thread_Label.Visible = false;
            // 
            // BAS_Product_Num_Label
            // 
            this.BAS_Product_Num_Label.AutoSize = true;
            this.BAS_Product_Num_Label.Location = new System.Drawing.Point(1103, 32);
            this.BAS_Product_Num_Label.Name = "BAS_Product_Num_Label";
            this.BAS_Product_Num_Label.Size = new System.Drawing.Size(202, 25);
            this.BAS_Product_Num_Label.TabIndex = 16;
            this.BAS_Product_Num_Label.Text = "Number of Products";
            this.BAS_Product_Num_Label.Visible = false;
            // 
            // P2_Warships_To_Spawn
            // 
            this.P2_Warships_To_Spawn.Location = new System.Drawing.Point(817, 158);
            this.P2_Warships_To_Spawn.Name = "P2_Warships_To_Spawn";
            this.P2_Warships_To_Spawn.Size = new System.Drawing.Size(256, 31);
            this.P2_Warships_To_Spawn.TabIndex = 19;
            this.P2_Warships_To_Spawn.Visible = false;
            // 
            // BAS_Chart
            // 
            chartArea1.AxisX.Title = "Product Number";
            chartArea1.AxisY.Title = "Stock";
            chartArea1.Name = "ChartArea1";
            this.BAS_Chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.BAS_Chart.Legends.Add(legend1);
            this.BAS_Chart.Location = new System.Drawing.Point(12, 224);
            this.BAS_Chart.Name = "BAS_Chart";
            this.BAS_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Products";
            this.BAS_Chart.Series.Add(series1);
            this.BAS_Chart.Size = new System.Drawing.Size(1375, 493);
            this.BAS_Chart.TabIndex = 20;
            this.BAS_Chart.Text = "BAS_Chart";
            this.BAS_Chart.Visible = false;
            // 
            // Step_BAS_Simulation_Button
            // 
            this.Step_BAS_Simulation_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Step_BAS_Simulation_Button.Location = new System.Drawing.Point(817, 158);
            this.Step_BAS_Simulation_Button.Name = "Step_BAS_Simulation_Button";
            this.Step_BAS_Simulation_Button.Size = new System.Drawing.Size(256, 45);
            this.Step_BAS_Simulation_Button.TabIndex = 21;
            this.Step_BAS_Simulation_Button.Text = "Next Simulation Step";
            this.Step_BAS_Simulation_Button.UseVisualStyleBackColor = true;
            this.Step_BAS_Simulation_Button.Visible = false;
            this.Step_BAS_Simulation_Button.Click += new System.EventHandler(this.Step_BAS_Simulation_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 729);
            this.Controls.Add(this.Step_BAS_Simulation_Button);
            this.Controls.Add(this.BAS_Chart);
            this.Controls.Add(this.P2_Warships_To_Spawn);
            this.Controls.Add(this.BAS_Product_Num_Label);
            this.Controls.Add(this.BAS_Thread_Label);
            this.Controls.Add(this.BAS_Num_Products_Input);
            this.Controls.Add(this.BAS_Num_Threads_input);
            this.Controls.Add(this.Buying_And_Selling_Start_Button);
            this.Controls.Add(this.Find_If_Palindrome_Button);
            this.Controls.Add(this.Palindrome_Output);
            this.Controls.Add(this.Find_Palindrome_Activation_Button);
            this.Controls.Add(this.Buying_And_Selling_Button);
            this.Controls.Add(this.Palindrome_Input_Label);
            this.Controls.Add(this.Palindrome_Input_Textbox);
            this.Controls.Add(this.Palindrome_Button);
            this.Name = "Form1";
            this.Text = "PPolley Interview Questions";
            ((System.ComponentModel.ISupportInitialize)(this.BAS_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Palindrome_Button;
        private System.Windows.Forms.TextBox Palindrome_Input_Textbox;
        private System.Windows.Forms.Label Palindrome_Input_Label;
        private System.Windows.Forms.Button Buying_And_Selling_Button;
        private System.Windows.Forms.Button Find_Palindrome_Activation_Button;
        private System.Windows.Forms.TextBox Palindrome_Output;
        private System.Windows.Forms.Button Find_If_Palindrome_Button;
        private System.Windows.Forms.Button Buying_And_Selling_Start_Button;
        private System.Windows.Forms.TextBox BAS_Num_Threads_input;
        private System.Windows.Forms.TextBox BAS_Num_Products_Input;
        private System.Windows.Forms.Label BAS_Thread_Label;
        private System.Windows.Forms.Label BAS_Product_Num_Label;
        private System.Windows.Forms.TextBox P2_Warships_To_Spawn;
        private System.Windows.Forms.DataVisualization.Charting.Chart BAS_Chart;
        private System.Windows.Forms.Button Step_BAS_Simulation_Button;
    }
}

