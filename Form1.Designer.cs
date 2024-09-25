namespace MSSQLWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            this.btn_executeQuery = new System.Windows.Forms.Button();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tb_insertItem = new System.Windows.Forms.TextBox();
            this.btn_removeAll = new System.Windows.Forms.Button();
            this.btn_removeOne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.AccessTokenCallback = null;
            this.sqlConnection1.ConnectionString = "Server=localhost;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=T" +
    "rue;";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // btn_executeQuery
            // 
            this.btn_executeQuery.Location = new System.Drawing.Point(12, 15);
            this.btn_executeQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_executeQuery.Name = "btn_executeQuery";
            this.btn_executeQuery.Size = new System.Drawing.Size(125, 57);
            this.btn_executeQuery.TabIndex = 0;
            this.btn_executeQuery.Text = "execute Query";
            this.btn_executeQuery.UseVisualStyleBackColor = true;
            this.btn_executeQuery.Click += new System.EventHandler(this.btn_executeQuery_Click);
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(143, 15);
            this.tb_log.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ReadOnly = true;
            this.tb_log.Size = new System.Drawing.Size(221, 57);
            this.tb_log.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(352, 312);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(370, 111);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(135, 53);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Insert Item";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tb_insertItem
            // 
            this.tb_insertItem.Location = new System.Drawing.Point(370, 80);
            this.tb_insertItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_insertItem.Name = "tb_insertItem";
            this.tb_insertItem.Size = new System.Drawing.Size(135, 23);
            this.tb_insertItem.TabIndex = 4;
            // 
            // btn_removeAll
            // 
            this.btn_removeAll.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_removeAll.Location = new System.Drawing.Point(193, 399);
            this.btn_removeAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_removeAll.Name = "btn_removeAll";
            this.btn_removeAll.Size = new System.Drawing.Size(171, 97);
            this.btn_removeAll.TabIndex = 5;
            this.btn_removeAll.Text = "모든 아이템 제거";
            this.btn_removeAll.UseVisualStyleBackColor = true;
            this.btn_removeAll.Click += new System.EventHandler(this.btn_removeAll_Click);
            // 
            // btn_removeOne
            // 
            this.btn_removeOne.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_removeOne.Location = new System.Drawing.Point(12, 399);
            this.btn_removeOne.Name = "btn_removeOne";
            this.btn_removeOne.Size = new System.Drawing.Size(175, 97);
            this.btn_removeOne.TabIndex = 6;
            this.btn_removeOne.Text = "선택한 아이템 1개 제거";
            this.btn_removeOne.UseVisualStyleBackColor = true;
            this.btn_removeOne.Click += new System.EventHandler(this.btn_removeOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 509);
            this.Controls.Add(this.btn_removeOne);
            this.Controls.Add(this.btn_removeAll);
            this.Controls.Add(this.tb_insertItem);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.btn_executeQuery);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Button btn_executeQuery;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox tb_insertItem;
        private System.Windows.Forms.Button btn_removeAll;
        private System.Windows.Forms.Button btn_removeOne;
    }
}

