
namespace MyCalendar
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
            this.dayLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.weekLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.thuLabel = new System.Windows.Forms.Label();
            this.friLabel = new System.Windows.Forms.Label();
            this.satLabel = new System.Windows.Forms.Label();
            this.wedLabel = new System.Windows.Forms.Label();
            this.sunLabel = new System.Windows.Forms.Label();
            this.monLabel = new System.Windows.Forms.Label();
            this.tuoLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.preBtn = new System.Windows.Forms.Button();
            this.weekLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayLayoutTable
            // 
            this.dayLayoutTable.ColumnCount = 7;
            this.dayLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dayLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.dayLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.dayLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.dayLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.dayLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.dayLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.dayLayoutTable.Location = new System.Drawing.Point(12, 182);
            this.dayLayoutTable.Name = "dayLayoutTable";
            this.dayLayoutTable.RowCount = 6;
            this.dayLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dayLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dayLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dayLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dayLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dayLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.dayLayoutTable.Size = new System.Drawing.Size(760, 317);
            this.dayLayoutTable.TabIndex = 0;
            // 
            // weekLayoutTable
            // 
            this.weekLayoutTable.BackColor = System.Drawing.SystemColors.Control;
            this.weekLayoutTable.ColumnCount = 7;
            this.weekLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.weekLayoutTable.Controls.Add(this.thuLabel, 0, 0);
            this.weekLayoutTable.Controls.Add(this.friLabel, 0, 0);
            this.weekLayoutTable.Controls.Add(this.satLabel, 0, 0);
            this.weekLayoutTable.Controls.Add(this.wedLabel, 0, 0);
            this.weekLayoutTable.Controls.Add(this.sunLabel, 0, 0);
            this.weekLayoutTable.Controls.Add(this.monLabel, 0, 0);
            this.weekLayoutTable.Controls.Add(this.tuoLabel, 0, 0);
            this.weekLayoutTable.Location = new System.Drawing.Point(12, 114);
            this.weekLayoutTable.Name = "weekLayoutTable";
            this.weekLayoutTable.RowCount = 1;
            this.weekLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.weekLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.weekLayoutTable.Size = new System.Drawing.Size(760, 62);
            this.weekLayoutTable.TabIndex = 1;
            // 
            // thuLabel
            // 
            this.thuLabel.AutoSize = true;
            this.thuLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.thuLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thuLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.thuLabel.ForeColor = System.Drawing.Color.White;
            this.thuLabel.Location = new System.Drawing.Point(433, 1);
            this.thuLabel.Margin = new System.Windows.Forms.Padding(1);
            this.thuLabel.Name = "thuLabel";
            this.thuLabel.Size = new System.Drawing.Size(106, 60);
            this.thuLabel.TabIndex = 6;
            this.thuLabel.Text = "목";
            this.thuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friLabel
            // 
            this.friLabel.AutoSize = true;
            this.friLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.friLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.friLabel.ForeColor = System.Drawing.Color.White;
            this.friLabel.Location = new System.Drawing.Point(541, 1);
            this.friLabel.Margin = new System.Windows.Forms.Padding(1);
            this.friLabel.Name = "friLabel";
            this.friLabel.Size = new System.Drawing.Size(106, 60);
            this.friLabel.TabIndex = 5;
            this.friLabel.Text = "금";
            this.friLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // satLabel
            // 
            this.satLabel.AutoSize = true;
            this.satLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.satLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.satLabel.ForeColor = System.Drawing.Color.White;
            this.satLabel.Location = new System.Drawing.Point(649, 1);
            this.satLabel.Margin = new System.Windows.Forms.Padding(1);
            this.satLabel.Name = "satLabel";
            this.satLabel.Size = new System.Drawing.Size(110, 60);
            this.satLabel.TabIndex = 4;
            this.satLabel.Text = "토";
            this.satLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wedLabel
            // 
            this.wedLabel.AutoSize = true;
            this.wedLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.wedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wedLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wedLabel.ForeColor = System.Drawing.Color.White;
            this.wedLabel.Location = new System.Drawing.Point(325, 1);
            this.wedLabel.Margin = new System.Windows.Forms.Padding(1);
            this.wedLabel.Name = "wedLabel";
            this.wedLabel.Size = new System.Drawing.Size(106, 60);
            this.wedLabel.TabIndex = 3;
            this.wedLabel.Text = "수";
            this.wedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunLabel
            // 
            this.sunLabel.AutoSize = true;
            this.sunLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sunLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sunLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sunLabel.ForeColor = System.Drawing.Color.White;
            this.sunLabel.Location = new System.Drawing.Point(1, 1);
            this.sunLabel.Margin = new System.Windows.Forms.Padding(1);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(106, 60);
            this.sunLabel.TabIndex = 2;
            this.sunLabel.Text = "일";
            this.sunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monLabel
            // 
            this.monLabel.AutoSize = true;
            this.monLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.monLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monLabel.ForeColor = System.Drawing.Color.White;
            this.monLabel.Location = new System.Drawing.Point(109, 1);
            this.monLabel.Margin = new System.Windows.Forms.Padding(1);
            this.monLabel.Name = "monLabel";
            this.monLabel.Size = new System.Drawing.Size(106, 60);
            this.monLabel.TabIndex = 1;
            this.monLabel.Text = "월";
            this.monLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tuoLabel
            // 
            this.tuoLabel.AutoSize = true;
            this.tuoLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tuoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tuoLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tuoLabel.ForeColor = System.Drawing.Color.White;
            this.tuoLabel.Location = new System.Drawing.Point(217, 1);
            this.tuoLabel.Margin = new System.Windows.Forms.Padding(1);
            this.tuoLabel.Name = "tuoLabel";
            this.tuoLabel.Size = new System.Drawing.Size(106, 60);
            this.tuoLabel.TabIndex = 0;
            this.tuoLabel.Text = "화";
            this.tuoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthLabel
            // 
            this.monthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.monthLabel.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monthLabel.Location = new System.Drawing.Point(333, 35);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(115, 76);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Mon";
            this.monthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            this.yearLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yearLabel.Location = new System.Drawing.Point(335, 35);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(108, 21);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nextBtn.Location = new System.Drawing.Point(452, 67);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(80, 25);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "다음 달";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextMonthBtn_Clicked);
            // 
            // preBtn
            // 
            this.preBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.preBtn.Location = new System.Drawing.Point(247, 67);
            this.preBtn.Name = "preBtn";
            this.preBtn.Size = new System.Drawing.Size(80, 25);
            this.preBtn.TabIndex = 5;
            this.preBtn.Text = "이전 달";
            this.preBtn.UseVisualStyleBackColor = true;
            this.preBtn.Click += new System.EventHandler(this.previousMonthBtn_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.preBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.weekLayoutTable);
            this.Controls.Add(this.dayLayoutTable);
            this.Name = "Form1";
            this.weekLayoutTable.ResumeLayout(false);
            this.weekLayoutTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dayLayoutTable;
        private System.Windows.Forms.TableLayoutPanel weekLayoutTable;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button preBtn;
        private System.Windows.Forms.Label thuLabel;
        private System.Windows.Forms.Label friLabel;
        private System.Windows.Forms.Label satLabel;
        private System.Windows.Forms.Label wedLabel;
        private System.Windows.Forms.Label sunLabel;
        private System.Windows.Forms.Label monLabel;
        private System.Windows.Forms.Label tuoLabel;
    }
}

