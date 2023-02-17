namespace Proje6
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();			this.proje6DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proje6DataSet = new Proje6.Proje6DataSet();
			this.proje6DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proje6DataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proje6DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proje6DataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.DataSource = this.proje6DataSetBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(953, 336);
			this.dataGridView1.TabIndex = 0;
			// 
			// proje6DataSet1
			// 

			// 
			// proje6DataSet1BindingSource

			// 
			// proje6DataSet
			// 
			this.proje6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// proje6DataSetBindingSource
			// 
			this.proje6DataSetBindingSource.DataSource = this.proje6DataSet;
			this.proje6DataSetBindingSource.Position = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 336);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Satışlar";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proje6DataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proje6DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proje6DataSetBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource proje6DataSet1BindingSource;
		private System.Windows.Forms.BindingSource proje6DataSetBindingSource;
		private Proje6DataSet proje6DataSet;
	}
}

