namespace SokobanLevelEditor
{
    partial class SokobanLevelEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SokobanLevelEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolWall = new System.Windows.Forms.ToolStripButton();
            this.statAbox = new System.Windows.Forms.ToolStripLabel();
            this.toolAbox = new System.Windows.Forms.ToolStripButton();
            this.statHere = new System.Windows.Forms.ToolStripLabel();
            this.toolHere = new System.Windows.Forms.ToolStripButton();
            this.toolDone = new System.Windows.Forms.ToolStripButton();
            this.toolNone = new System.Windows.Forms.ToolStripButton();
            this.toolUser = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolPrev = new System.Windows.Forms.ToolStripButton();
            this.toolNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxLabirintSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWall,
            this.statAbox,
            this.toolAbox,
            this.statHere,
            this.toolHere,
            this.toolDone,
            this.toolNone,
            this.toolUser,
            this.toolSave,
            this.toolPrev,
            this.toolNext,
            this.toolStripLabel1,
            this.toolStripTextBoxLabirintSize,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(631, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolWall
            // 
            this.toolWall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWall.Image = global::SokobanLevelEditor.Properties.Resources.wall;
            this.toolWall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolWall.Name = "toolWall";
            this.toolWall.Size = new System.Drawing.Size(36, 36);
            this.toolWall.Text = "toolStripButton1";
            this.toolWall.Click += new System.EventHandler(this.toolWall_Click);
            // 
            // statAbox
            // 
            this.statAbox.Name = "statAbox";
            this.statAbox.Size = new System.Drawing.Size(18, 36);
            this.statAbox.Text = "1х";
            // 
            // toolAbox
            // 
            this.toolAbox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbox.Image = global::SokobanLevelEditor.Properties.Resources.abox;
            this.toolAbox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbox.Name = "toolAbox";
            this.toolAbox.Size = new System.Drawing.Size(36, 36);
            this.toolAbox.Text = "toolStripButton2";
            this.toolAbox.Click += new System.EventHandler(this.toolAbox_Click);
            // 
            // statHere
            // 
            this.statHere.Name = "statHere";
            this.statHere.Size = new System.Drawing.Size(18, 36);
            this.statHere.Text = "2х";
            // 
            // toolHere
            // 
            this.toolHere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHere.Image = global::SokobanLevelEditor.Properties.Resources.here;
            this.toolHere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHere.Name = "toolHere";
            this.toolHere.Size = new System.Drawing.Size(36, 36);
            this.toolHere.Text = "toolStripButton3";
            this.toolHere.Click += new System.EventHandler(this.toolHere_Click);
            // 
            // toolDone
            // 
            this.toolDone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDone.Image = global::SokobanLevelEditor.Properties.Resources.done;
            this.toolDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(36, 36);
            this.toolDone.Text = "toolStripButton4";
            this.toolDone.Click += new System.EventHandler(this.toolDone_Click);
            // 
            // toolNone
            // 
            this.toolNone.Checked = true;
            this.toolNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNone.Image = global::SokobanLevelEditor.Properties.Resources.none;
            this.toolNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNone.Name = "toolNone";
            this.toolNone.Size = new System.Drawing.Size(36, 36);
            this.toolNone.Text = "toolStripButton5";
            this.toolNone.Click += new System.EventHandler(this.toolNone_Click);
            // 
            // toolUser
            // 
            this.toolUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUser.Image = global::SokobanLevelEditor.Properties.Resources.user;
            this.toolUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser.Name = "toolUser";
            this.toolUser.Size = new System.Drawing.Size(36, 36);
            this.toolUser.Text = "AddPlayer";
            this.toolUser.Click += new System.EventHandler(this.toolUser_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = global::SokobanLevelEditor.Properties.Resources.save;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(36, 36);
            this.toolSave.Text = "Save";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolPrev
            // 
            this.toolPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrev.Image = global::SokobanLevelEditor.Properties.Resources.prev;
            this.toolPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrev.Name = "toolPrev";
            this.toolPrev.Size = new System.Drawing.Size(36, 36);
            this.toolPrev.Text = "PreviousLevel";
            this.toolPrev.Click += new System.EventHandler(this.toolPrev_Click);
            // 
            // toolNext
            // 
            this.toolNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNext.Image = global::SokobanLevelEditor.Properties.Resources.next;
            this.toolNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNext.Name = "toolNext";
            this.toolNext.Size = new System.Drawing.Size(36, 36);
            this.toolNext.Text = "NextLevel";
            this.toolNext.Click += new System.EventHandler(this.toolNext_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 36);
            this.toolStripLabel1.Text = "Field size:";
            // 
            // toolStripTextBoxLabirintSize
            // 
            this.toolStripTextBoxLabirintSize.Name = "toolStripTextBoxLabirintSize";
            this.toolStripTextBoxLabirintSize.Size = new System.Drawing.Size(100, 39);
            this.toolStripTextBoxLabirintSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxLabirintSize_KeyDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SokobanLevelEditor.Properties.Resources.add_del;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "SetSize";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 39);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(631, 426);
            this.panel.TabIndex = 1;
            this.panel.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // SokobanEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 465);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SokobanEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sokoban - Level Editor";
            this.Load += new System.EventHandler(this.SokobanEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolWall;
        private System.Windows.Forms.ToolStripButton toolAbox;
        private System.Windows.Forms.ToolStripButton toolHere;
        private System.Windows.Forms.ToolStripButton toolDone;
        private System.Windows.Forms.ToolStripButton toolNone;
        private System.Windows.Forms.ToolStripButton toolUser;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolPrev;
        private System.Windows.Forms.ToolStripButton toolNext;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxLabirintSize;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel statAbox;
        private System.Windows.Forms.ToolStripLabel statHere;
    }
}

