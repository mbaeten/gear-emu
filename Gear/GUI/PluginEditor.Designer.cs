/* --------------------------------------------------------------------------------
 * Gear: Parallax Inc. Propeller Debugger
 * Copyright 2007 - Robert Vandiver
 * --------------------------------------------------------------------------------
 *  This program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program; if not, write to the Free Software
 *  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 * --------------------------------------------------------------------------------
 */

namespace Gear.GUI
{
    partial class PluginEditor
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
            PluginEditor.defaultFont.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripLabel classNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginEditor));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsButton = new System.Windows.Forms.ToolStripButton();
            this.checkButton = new System.Windows.Forms.ToolStripButton();
            this.instanceName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.syntaxButton = new System.Windows.Forms.ToolStripButton();
            this.progressHighlight = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.EmbeddedCode = new System.Windows.Forms.ToolStripButton();
            this.referencePanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.referencesList = new System.Windows.Forms.ListBox();
            this.toolStripReferences = new System.Windows.Forms.ToolStrip();
            this.referenceName = new System.Windows.Forms.ToolStripTextBox();
            this.addReferenceButton = new System.Windows.Forms.ToolStripButton();
            this.removeReferenceButton = new System.Windows.Forms.ToolStripButton();
            this.errorListView = new System.Windows.Forms.ListView();
            this.codeEditorView = new System.Windows.Forms.RichTextBox();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.errorSplitter = new Gear.GUI.CollapsibleSplitter();
            this.referencesSplitter = new Gear.GUI.CollapsibleSplitter();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            classNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripMain.SuspendLayout();
            this.referencePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStripReferences.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // classNameLabel
            // 
            classNameLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            classNameLabel.Name = "classNameLabel";
            classNameLabel.Size = new System.Drawing.Size(99, 22);
            classNameLabel.Text = "Main Class Name";
            classNameLabel.ToolTipText = "Plugin Main Class Name";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveButton,
            this.saveAsButton,
            toolStripSeparator1,
            this.checkButton,
            this.instanceName,
            classNameLabel,
            this.toolStripSeparator2,
            this.syntaxButton,
            this.progressHighlight,
            this.toolStripSeparator3,
            this.EmbeddedCode});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(654, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(40, 22);
            this.openButton.Text = "Open";
            this.openButton.ToolTipText = "Open plugin";
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(35, 22);
            this.saveButton.Text = "Save";
            this.saveButton.ToolTipText = "Save plugin";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
            this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(57, 22);
            this.saveAsButton.Text = "Save As..";
            this.saveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.checkButton.Image = ((System.Drawing.Image)(resources.GetObject("checkButton.Image")));
            this.checkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 22);
            this.checkButton.Text = "Check Code";
            this.checkButton.ToolTipText = "Check code for errors";
            this.checkButton.Click += new System.EventHandler(this.CheckSource_Click);
            // 
            // instanceName
            // 
            this.instanceName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.instanceName.Name = "instanceName";
            this.instanceName.ReadOnly = true;
            this.instanceName.Size = new System.Drawing.Size(100, 25);
            this.instanceName.ToolTipText = "Name of the Class for the plugin\r\nMust be the same as the class inherited from Pl" +
    "uginBase.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // syntaxButton
            // 
            this.syntaxButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.syntaxButton.Image = ((System.Drawing.Image)(resources.GetObject("syntaxButton.Image")));
            this.syntaxButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.syntaxButton.Name = "syntaxButton";
            this.syntaxButton.Size = new System.Drawing.Size(98, 22);
            this.syntaxButton.Text = "Syntax Highlight";
            this.syntaxButton.ToolTipText = "Syntax Highlight the code";
            this.syntaxButton.Click += new System.EventHandler(this.syntaxButton_Click);
            // 
            // progressHighlight
            // 
            this.progressHighlight.Name = "progressHighlight";
            this.progressHighlight.Size = new System.Drawing.Size(80, 22);
            this.progressHighlight.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // EmbeddedCode
            // 
            this.EmbeddedCode.Checked = true;
            this.EmbeddedCode.CheckOnClick = true;
            this.EmbeddedCode.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.EmbeddedCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EmbeddedCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmbeddedCode.Name = "EmbeddedCode";
            this.EmbeddedCode.Size = new System.Drawing.Size(68, 22);
            this.EmbeddedCode.Text = "Embedded";
            this.EmbeddedCode.Click += new System.EventHandler(this.embeddedCode_Click);
            // 
            // referencePanel
            // 
            this.referencePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.referencePanel.Controls.Add(this.groupBox1);
            this.referencePanel.Controls.Add(this.toolStripReferences);
            this.referencePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.referencePanel.Location = new System.Drawing.Point(0, 0);
            this.referencePanel.Name = "referencePanel";
            this.referencePanel.Size = new System.Drawing.Size(200, 417);
            this.referencePanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.referencesList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 392);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "References List";
            // 
            // referencesList
            // 
            this.referencesList.ColumnWidth = 55;
            this.referencesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.referencesList.FormattingEnabled = true;
            this.referencesList.Location = new System.Drawing.Point(3, 16);
            this.referencesList.Name = "referencesList";
            this.referencesList.Size = new System.Drawing.Size(194, 373);
            this.referencesList.TabIndex = 1;
            // 
            // toolStripReferences
            // 
            this.toolStripReferences.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripReferences.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referenceName,
            this.addReferenceButton,
            this.removeReferenceButton});
            this.toolStripReferences.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripReferences.Location = new System.Drawing.Point(0, 392);
            this.toolStripReferences.Name = "toolStripReferences";
            this.toolStripReferences.Size = new System.Drawing.Size(200, 25);
            this.toolStripReferences.TabIndex = 0;
            this.toolStripReferences.Text = "toolStrip2";
            // 
            // referenceName
            // 
            this.referenceName.Name = "referenceName";
            this.referenceName.Size = new System.Drawing.Size(90, 25);
            this.referenceName.ToolTipText = "Reference Name to add/remove";
            // 
            // addReferenceButton
            // 
            this.addReferenceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addReferenceButton.Image = ((System.Drawing.Image)(resources.GetObject("addReferenceButton.Image")));
            this.addReferenceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addReferenceButton.Name = "addReferenceButton";
            this.addReferenceButton.Size = new System.Drawing.Size(33, 22);
            this.addReferenceButton.Text = "Add";
            this.addReferenceButton.ToolTipText = "Add a new Reference";
            this.addReferenceButton.Click += new System.EventHandler(this.addReferenceButton_Click);
            // 
            // removeReferenceButton
            // 
            this.removeReferenceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeReferenceButton.Image = ((System.Drawing.Image)(resources.GetObject("removeReferenceButton.Image")));
            this.removeReferenceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeReferenceButton.Name = "removeReferenceButton";
            this.removeReferenceButton.Size = new System.Drawing.Size(54, 22);
            this.removeReferenceButton.Text = "Remove";
            this.removeReferenceButton.ToolTipText = "Remove selected Reference";
            this.removeReferenceButton.Click += new System.EventHandler(this.RemoveReferenceButton_Click);
            // 
            // errorListView
            // 
            this.errorListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorListView.Location = new System.Drawing.Point(208, 345);
            this.errorListView.MultiSelect = false;
            this.errorListView.Name = "errorListView";
            this.errorListView.ShowItemToolTips = true;
            this.errorListView.Size = new System.Drawing.Size(446, 97);
            this.errorListView.TabIndex = 5;
            this.errorListView.UseCompatibleStateImageBehavior = false;
            this.errorListView.View = System.Windows.Forms.View.Details;
            this.errorListView.ItemActivate += new System.EventHandler(this.ErrorView_SelectedIndexChanged);
            this.errorListView.SelectedIndexChanged += new System.EventHandler(this.ErrorView_SelectedIndexChanged);
            // 
            // codeEditorView
            // 
            this.codeEditorView.AcceptsTab = true;
            this.codeEditorView.DetectUrls = false;
            this.codeEditorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditorView.HideSelection = false;
            this.codeEditorView.Location = new System.Drawing.Point(208, 25);
            this.codeEditorView.Name = "codeEditorView";
            this.codeEditorView.Size = new System.Drawing.Size(446, 312);
            this.codeEditorView.TabIndex = 7;
            this.codeEditorView.Text = "";
            this.codeEditorView.WordWrap = false;
            this.codeEditorView.TextChanged += new System.EventHandler(this.codeEditorView_TextChanged);
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.detailsPanel.Controls.Add(this.referencePanel);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 25);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(200, 417);
            this.detailsPanel.TabIndex = 2;
            // 
            // errorSplitter
            // 
            this.errorSplitter.AnimationDelay = 20;
            this.errorSplitter.AnimationStep = 20;
            this.errorSplitter.BorderStyle3D = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.errorSplitter.ControlToHide = this.errorListView;
            this.errorSplitter.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.errorSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorSplitter.ExpandParentForm = false;
            this.errorSplitter.Location = new System.Drawing.Point(208, 337);
            this.errorSplitter.Name = "collapsibleSplitter2";
            this.errorSplitter.TabIndex = 6;
            this.errorSplitter.TabStop = false;
            this.errorSplitter.UseAnimations = true;
            this.errorSplitter.VisualStyle = Gear.GUI.VisualStyles.Mozilla;
            // 
            // referencesSplitter
            // 
            this.referencesSplitter.AnimationDelay = 20;
            this.referencesSplitter.AnimationStep = 20;
            this.referencesSplitter.BorderStyle3D = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.referencesSplitter.ControlToHide = this.detailsPanel;
            this.referencesSplitter.ExpandParentForm = false;
            this.referencesSplitter.Location = new System.Drawing.Point(200, 25);
            this.referencesSplitter.Name = "collapsibleSplitter1";
            this.referencesSplitter.TabIndex = 3;
            this.referencesSplitter.TabStop = false;
            this.referencesSplitter.UseAnimations = true;
            this.referencesSplitter.VisualStyle = Gear.GUI.VisualStyles.Mozilla;
            // 
            // PluginEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 442);
            this.Controls.Add(this.codeEditorView);
            this.Controls.Add(this.errorSplitter);
            this.Controls.Add(this.errorListView);
            this.Controls.Add(this.referencesSplitter);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.toolStripMain);
            this.Name = "PluginEditor";
            this.Text = "Plugin Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PluginEditor_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.referencePanel.ResumeLayout(false);
            this.referencePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.toolStripReferences.ResumeLayout(false);
            this.toolStripReferences.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton checkButton;
        private System.Windows.Forms.Panel referencePanel;
        private System.Windows.Forms.ListBox referencesList;
        private System.Windows.Forms.ToolStrip toolStripReferences;
        private System.Windows.Forms.ToolStripTextBox referenceName;
        private System.Windows.Forms.ToolStripButton addReferenceButton;
        private CollapsibleSplitter referencesSplitter;
        private System.Windows.Forms.ToolStripTextBox instanceName;
        private System.Windows.Forms.ToolStripButton saveAsButton;
        private System.Windows.Forms.ToolStripButton removeReferenceButton;
        private System.Windows.Forms.ListView errorListView;
        private CollapsibleSplitter errorSplitter;
        private System.Windows.Forms.RichTextBox codeEditorView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton syntaxButton;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton EmbeddedCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripProgressBar progressHighlight;
    }
}
