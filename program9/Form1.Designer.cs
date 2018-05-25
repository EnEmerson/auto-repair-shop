namespace program9
{
    partial class automotiveShop
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
            this.oilLubeGroup = new System.Windows.Forms.GroupBox();
            this.lubeJob = new System.Windows.Forms.CheckBox();
            this.oilChange = new System.Windows.Forms.CheckBox();
            this.oilTypeGroup = new System.Windows.Forms.GroupBox();
            this.synthOil = new System.Windows.Forms.RadioButton();
            this.mixedOil = new System.Windows.Forms.RadioButton();
            this.regOil = new System.Windows.Forms.RadioButton();
            this.miscGroup = new System.Windows.Forms.GroupBox();
            this.tireRot = new System.Windows.Forms.CheckBox();
            this.repMuffler = new System.Windows.Forms.CheckBox();
            this.inspection = new System.Windows.Forms.CheckBox();
            this.partsLabGroup = new System.Windows.Forms.GroupBox();
            this.laborInput = new System.Windows.Forms.TextBox();
            this.partsInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.carWashGroup = new System.Windows.Forms.GroupBox();
            this.premWash = new System.Windows.Forms.RadioButton();
            this.fullWash = new System.Windows.Forms.RadioButton();
            this.compWash = new System.Windows.Forms.RadioButton();
            this.noWash = new System.Windows.Forms.RadioButton();
            this.flushGroup = new System.Windows.Forms.GroupBox();
            this.transFlush = new System.Windows.Forms.CheckBox();
            this.radFlush = new System.Windows.Forms.CheckBox();
            this.summaryGroup = new System.Windows.Forms.GroupBox();
            this.noWashLabel = new System.Windows.Forms.Label();
            this.grandTotalOutput = new System.Windows.Forms.Label();
            this.taxOnParts = new System.Windows.Forms.Label();
            this.partsTotalOutput = new System.Windows.Forms.Label();
            this.servLabOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeGroup.SuspendLayout();
            this.oilTypeGroup.SuspendLayout();
            this.miscGroup.SuspendLayout();
            this.partsLabGroup.SuspendLayout();
            this.carWashGroup.SuspendLayout();
            this.flushGroup.SuspendLayout();
            this.summaryGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLubeGroup
            // 
            this.oilLubeGroup.Controls.Add(this.lubeJob);
            this.oilLubeGroup.Controls.Add(this.oilChange);
            this.oilLubeGroup.Controls.Add(this.oilTypeGroup);
            this.oilLubeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilLubeGroup.Location = new System.Drawing.Point(32, 25);
            this.oilLubeGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oilLubeGroup.Name = "oilLubeGroup";
            this.oilLubeGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oilLubeGroup.Size = new System.Drawing.Size(225, 249);
            this.oilLubeGroup.TabIndex = 0;
            this.oilLubeGroup.TabStop = false;
            this.oilLubeGroup.Text = "Oil and Lube";
            // 
            // lubeJob
            // 
            this.lubeJob.AutoSize = true;
            this.lubeJob.Location = new System.Drawing.Point(14, 212);
            this.lubeJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lubeJob.Name = "lubeJob";
            this.lubeJob.Size = new System.Drawing.Size(144, 21);
            this.lubeJob.TabIndex = 4;
            this.lubeJob.Text = "Lube Job ($18.00)";
            this.lubeJob.UseVisualStyleBackColor = true;
            // 
            // oilChange
            // 
            this.oilChange.AutoSize = true;
            this.oilChange.Location = new System.Drawing.Point(14, 28);
            this.oilChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oilChange.Name = "oilChange";
            this.oilChange.Size = new System.Drawing.Size(155, 21);
            this.oilChange.TabIndex = 3;
            this.oilChange.Text = "Oil Change ($26.00)";
            this.oilChange.UseVisualStyleBackColor = true;
            // 
            // oilTypeGroup
            // 
            this.oilTypeGroup.Controls.Add(this.synthOil);
            this.oilTypeGroup.Controls.Add(this.mixedOil);
            this.oilTypeGroup.Controls.Add(this.regOil);
            this.oilTypeGroup.Location = new System.Drawing.Point(4, 58);
            this.oilTypeGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oilTypeGroup.Name = "oilTypeGroup";
            this.oilTypeGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oilTypeGroup.Size = new System.Drawing.Size(202, 131);
            this.oilTypeGroup.TabIndex = 2;
            this.oilTypeGroup.TabStop = false;
            this.oilTypeGroup.Text = "Oil Type";
            // 
            // synthOil
            // 
            this.synthOil.AutoSize = true;
            this.synthOil.Location = new System.Drawing.Point(10, 98);
            this.synthOil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.synthOil.Name = "synthOil";
            this.synthOil.Size = new System.Drawing.Size(168, 21);
            this.synthOil.TabIndex = 2;
            this.synthOil.TabStop = true;
            this.synthOil.Text = "Full Synthetic ($20.00)";
            this.synthOil.UseVisualStyleBackColor = true;
            // 
            // mixedOil
            // 
            this.mixedOil.AutoSize = true;
            this.mixedOil.Location = new System.Drawing.Point(10, 65);
            this.mixedOil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mixedOil.Name = "mixedOil";
            this.mixedOil.Size = new System.Drawing.Size(120, 21);
            this.mixedOil.TabIndex = 1;
            this.mixedOil.TabStop = true;
            this.mixedOil.Text = "Mixed ($10.00)";
            this.mixedOil.UseVisualStyleBackColor = true;
            // 
            // regOil
            // 
            this.regOil.AutoSize = true;
            this.regOil.Location = new System.Drawing.Point(10, 29);
            this.regOil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.regOil.Name = "regOil";
            this.regOil.Size = new System.Drawing.Size(126, 21);
            this.regOil.TabIndex = 0;
            this.regOil.TabStop = true;
            this.regOil.Text = "Regular ($0.00)";
            this.regOil.UseVisualStyleBackColor = true;
            // 
            // miscGroup
            // 
            this.miscGroup.Controls.Add(this.tireRot);
            this.miscGroup.Controls.Add(this.repMuffler);
            this.miscGroup.Controls.Add(this.inspection);
            this.miscGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscGroup.Location = new System.Drawing.Point(32, 280);
            this.miscGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.miscGroup.Name = "miscGroup";
            this.miscGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.miscGroup.Size = new System.Drawing.Size(225, 115);
            this.miscGroup.TabIndex = 1;
            this.miscGroup.TabStop = false;
            this.miscGroup.Text = "Misc.";
            // 
            // tireRot
            // 
            this.tireRot.AutoSize = true;
            this.tireRot.Location = new System.Drawing.Point(14, 80);
            this.tireRot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tireRot.Name = "tireRot";
            this.tireRot.Size = new System.Drawing.Size(167, 21);
            this.tireRot.TabIndex = 7;
            this.tireRot.Text = "Tire Rotation ($20.00)";
            this.tireRot.UseVisualStyleBackColor = true;
            // 
            // repMuffler
            // 
            this.repMuffler.AutoSize = true;
            this.repMuffler.Location = new System.Drawing.Point(14, 51);
            this.repMuffler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.repMuffler.Name = "repMuffler";
            this.repMuffler.Size = new System.Drawing.Size(192, 21);
            this.repMuffler.TabIndex = 6;
            this.repMuffler.Text = "Replace Muffler ($100.00)";
            this.repMuffler.UseVisualStyleBackColor = true;
            // 
            // inspection
            // 
            this.inspection.AutoSize = true;
            this.inspection.Location = new System.Drawing.Point(14, 23);
            this.inspection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inspection.Name = "inspection";
            this.inspection.Size = new System.Drawing.Size(149, 21);
            this.inspection.TabIndex = 5;
            this.inspection.Text = "Inspection ($15.00)";
            this.inspection.UseVisualStyleBackColor = true;
            // 
            // partsLabGroup
            // 
            this.partsLabGroup.Controls.Add(this.laborInput);
            this.partsLabGroup.Controls.Add(this.partsInput);
            this.partsLabGroup.Controls.Add(this.label2);
            this.partsLabGroup.Controls.Add(this.label1);
            this.partsLabGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabGroup.Location = new System.Drawing.Point(274, 280);
            this.partsLabGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partsLabGroup.Name = "partsLabGroup";
            this.partsLabGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partsLabGroup.Size = new System.Drawing.Size(236, 115);
            this.partsLabGroup.TabIndex = 2;
            this.partsLabGroup.TabStop = false;
            this.partsLabGroup.Text = "Parts and Labor";
            // 
            // laborInput
            // 
            this.laborInput.Location = new System.Drawing.Point(99, 74);
            this.laborInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.laborInput.Name = "laborInput";
            this.laborInput.Size = new System.Drawing.Size(76, 23);
            this.laborInput.TabIndex = 3;
            // 
            // partsInput
            // 
            this.partsInput.Location = new System.Drawing.Point(99, 37);
            this.partsInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partsInput.Name = "partsInput";
            this.partsInput.Size = new System.Drawing.Size(76, 23);
            this.partsInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor (Hrs):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts ($):";
            // 
            // carWashGroup
            // 
            this.carWashGroup.Controls.Add(this.premWash);
            this.carWashGroup.Controls.Add(this.fullWash);
            this.carWashGroup.Controls.Add(this.compWash);
            this.carWashGroup.Controls.Add(this.noWash);
            this.carWashGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carWashGroup.Location = new System.Drawing.Point(274, 25);
            this.carWashGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carWashGroup.Name = "carWashGroup";
            this.carWashGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carWashGroup.Size = new System.Drawing.Size(236, 151);
            this.carWashGroup.TabIndex = 3;
            this.carWashGroup.TabStop = false;
            this.carWashGroup.Text = "Carwash";
            // 
            // premWash
            // 
            this.premWash.AutoSize = true;
            this.premWash.Location = new System.Drawing.Point(17, 123);
            this.premWash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.premWash.Name = "premWash";
            this.premWash.Size = new System.Drawing.Size(131, 21);
            this.premWash.TabIndex = 4;
            this.premWash.TabStop = true;
            this.premWash.Text = "Premium ($9.00)";
            this.premWash.UseVisualStyleBackColor = true;
            // 
            // fullWash
            // 
            this.fullWash.AutoSize = true;
            this.fullWash.Location = new System.Drawing.Point(17, 92);
            this.fullWash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullWash.Name = "fullWash";
            this.fullWash.Size = new System.Drawing.Size(149, 21);
            this.fullWash.TabIndex = 3;
            this.fullWash.TabStop = true;
            this.fullWash.Text = "Full Service ($6.00)";
            this.fullWash.UseVisualStyleBackColor = true;
            // 
            // compWash
            // 
            this.compWash.AutoSize = true;
            this.compWash.Location = new System.Drawing.Point(17, 59);
            this.compWash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.compWash.Name = "compWash";
            this.compWash.Size = new System.Drawing.Size(169, 21);
            this.compWash.TabIndex = 2;
            this.compWash.TabStop = true;
            this.compWash.Text = "Complimentary ($0.00)";
            this.compWash.UseVisualStyleBackColor = true;
            // 
            // noWash
            // 
            this.noWash.AutoSize = true;
            this.noWash.Location = new System.Drawing.Point(17, 28);
            this.noWash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noWash.Name = "noWash";
            this.noWash.Size = new System.Drawing.Size(60, 21);
            this.noWash.TabIndex = 1;
            this.noWash.TabStop = true;
            this.noWash.Text = "None";
            this.noWash.UseVisualStyleBackColor = true;
            // 
            // flushGroup
            // 
            this.flushGroup.Controls.Add(this.transFlush);
            this.flushGroup.Controls.Add(this.radFlush);
            this.flushGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flushGroup.Location = new System.Drawing.Point(274, 181);
            this.flushGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flushGroup.Name = "flushGroup";
            this.flushGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flushGroup.Size = new System.Drawing.Size(236, 93);
            this.flushGroup.TabIndex = 4;
            this.flushGroup.TabStop = false;
            this.flushGroup.Text = "Flushes";
            // 
            // transFlush
            // 
            this.transFlush.AutoSize = true;
            this.transFlush.Location = new System.Drawing.Point(17, 56);
            this.transFlush.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transFlush.Name = "transFlush";
            this.transFlush.Size = new System.Drawing.Size(207, 21);
            this.transFlush.TabIndex = 6;
            this.transFlush.Text = "Transmission Flush ($80.00)";
            this.transFlush.UseVisualStyleBackColor = true;
            // 
            // radFlush
            // 
            this.radFlush.AutoSize = true;
            this.radFlush.Location = new System.Drawing.Point(17, 27);
            this.radFlush.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radFlush.Name = "radFlush";
            this.radFlush.Size = new System.Drawing.Size(177, 21);
            this.radFlush.TabIndex = 5;
            this.radFlush.Text = "Radiator Flush ($30.00)";
            this.radFlush.UseVisualStyleBackColor = true;
            // 
            // summaryGroup
            // 
            this.summaryGroup.Controls.Add(this.noWashLabel);
            this.summaryGroup.Controls.Add(this.grandTotalOutput);
            this.summaryGroup.Controls.Add(this.taxOnParts);
            this.summaryGroup.Controls.Add(this.partsTotalOutput);
            this.summaryGroup.Controls.Add(this.servLabOutput);
            this.summaryGroup.Controls.Add(this.label6);
            this.summaryGroup.Controls.Add(this.label5);
            this.summaryGroup.Controls.Add(this.label4);
            this.summaryGroup.Controls.Add(this.label3);
            this.summaryGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryGroup.Location = new System.Drawing.Point(32, 399);
            this.summaryGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summaryGroup.Name = "summaryGroup";
            this.summaryGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summaryGroup.Size = new System.Drawing.Size(478, 171);
            this.summaryGroup.TabIndex = 4;
            this.summaryGroup.TabStop = false;
            this.summaryGroup.Text = "Summary";
            // 
            // noWashLabel
            // 
            this.noWashLabel.AutoSize = true;
            this.noWashLabel.Location = new System.Drawing.Point(334, 123);
            this.noWashLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noWashLabel.Name = "noWashLabel";
            this.noWashLabel.Size = new System.Drawing.Size(97, 17);
            this.noWashLabel.TabIndex = 9;
            this.noWashLabel.Text = "*No Car Wash";
            // 
            // grandTotalOutput
            // 
            this.grandTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grandTotalOutput.Location = new System.Drawing.Point(186, 122);
            this.grandTotalOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.grandTotalOutput.Name = "grandTotalOutput";
            this.grandTotalOutput.Size = new System.Drawing.Size(143, 23);
            this.grandTotalOutput.TabIndex = 8;
            // 
            // taxOnParts
            // 
            this.taxOnParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxOnParts.Location = new System.Drawing.Point(186, 89);
            this.taxOnParts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxOnParts.Name = "taxOnParts";
            this.taxOnParts.Size = new System.Drawing.Size(143, 23);
            this.taxOnParts.TabIndex = 7;
            // 
            // partsTotalOutput
            // 
            this.partsTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsTotalOutput.Location = new System.Drawing.Point(186, 57);
            this.partsTotalOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partsTotalOutput.Name = "partsTotalOutput";
            this.partsTotalOutput.Size = new System.Drawing.Size(143, 23);
            this.partsTotalOutput.TabIndex = 6;
            // 
            // servLabOutput
            // 
            this.servLabOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servLabOutput.Location = new System.Drawing.Point(186, 22);
            this.servLabOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.servLabOutput.Name = "servLabOutput";
            this.servLabOutput.Size = new System.Drawing.Size(143, 23);
            this.servLabOutput.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tax (on parts):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Service and Labor:";
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(132, 586);
            this.calcButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(89, 31);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(233, 586);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 31);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(335, 586);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 31);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // automotiveShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 638);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.summaryGroup);
            this.Controls.Add(this.flushGroup);
            this.Controls.Add(this.carWashGroup);
            this.Controls.Add(this.partsLabGroup);
            this.Controls.Add(this.miscGroup);
            this.Controls.Add(this.oilLubeGroup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "automotiveShop";
            this.Text = "Automotive Shop";
            this.Load += new System.EventHandler(this.automotiveShop_Load);
            this.oilLubeGroup.ResumeLayout(false);
            this.oilLubeGroup.PerformLayout();
            this.oilTypeGroup.ResumeLayout(false);
            this.oilTypeGroup.PerformLayout();
            this.miscGroup.ResumeLayout(false);
            this.miscGroup.PerformLayout();
            this.partsLabGroup.ResumeLayout(false);
            this.partsLabGroup.PerformLayout();
            this.carWashGroup.ResumeLayout(false);
            this.carWashGroup.PerformLayout();
            this.flushGroup.ResumeLayout(false);
            this.flushGroup.PerformLayout();
            this.summaryGroup.ResumeLayout(false);
            this.summaryGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilLubeGroup;
        private System.Windows.Forms.GroupBox oilTypeGroup;
        private System.Windows.Forms.GroupBox miscGroup;
        private System.Windows.Forms.GroupBox partsLabGroup;
        private System.Windows.Forms.GroupBox carWashGroup;
        private System.Windows.Forms.GroupBox flushGroup;
        private System.Windows.Forms.GroupBox summaryGroup;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox lubeJob;
        private System.Windows.Forms.CheckBox oilChange;
        private System.Windows.Forms.RadioButton synthOil;
        private System.Windows.Forms.RadioButton mixedOil;
        private System.Windows.Forms.RadioButton regOil;
        private System.Windows.Forms.CheckBox tireRot;
        private System.Windows.Forms.CheckBox repMuffler;
        private System.Windows.Forms.CheckBox inspection;
        private System.Windows.Forms.RadioButton premWash;
        private System.Windows.Forms.RadioButton fullWash;
        private System.Windows.Forms.RadioButton compWash;
        private System.Windows.Forms.RadioButton noWash;
        private System.Windows.Forms.TextBox laborInput;
        private System.Windows.Forms.TextBox partsInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox transFlush;
        private System.Windows.Forms.CheckBox radFlush;
        private System.Windows.Forms.Label grandTotalOutput;
        private System.Windows.Forms.Label taxOnParts;
        private System.Windows.Forms.Label partsTotalOutput;
        private System.Windows.Forms.Label servLabOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noWashLabel;
    }
}

