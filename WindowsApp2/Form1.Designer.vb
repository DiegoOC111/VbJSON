<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cl1_Par1 = New System.Windows.Forms.TextBox()
        Me.Cl1_Par3 = New System.Windows.Forms.TextBox()
        Me.Cl1_Par2 = New System.Windows.Forms.TextBox()
        Me.Cl1_Par4 = New System.Windows.Forms.TextBox()
        Me.Cl2_Par4 = New System.Windows.Forms.TextBox()
        Me.Cl2_Par2 = New System.Windows.Forms.TextBox()
        Me.Cl2_Par3 = New System.Windows.Forms.TextBox()
        Me.Cl2_Par1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Guardar.Location = New System.Drawing.Point(0, 377)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(800, 73)
        Me.Guardar.TabIndex = 0
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Cl1_Par4)
        Me.Panel1.Controls.Add(Me.Cl1_Par2)
        Me.Panel1.Controls.Add(Me.Cl1_Par3)
        Me.Panel1.Controls.Add(Me.Cl1_Par1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 377)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Cl2_Par4)
        Me.Panel2.Controls.Add(Me.Cl2_Par3)
        Me.Panel2.Controls.Add(Me.Cl2_Par2)
        Me.Panel2.Controls.Add(Me.Cl2_Par1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(408, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(392, 377)
        Me.Panel2.TabIndex = 2
        '
        'Cl1_Par1
        '
        Me.Cl1_Par1.Location = New System.Drawing.Point(12, 73)
        Me.Cl1_Par1.Name = "Cl1_Par1"
        Me.Cl1_Par1.Size = New System.Drawing.Size(203, 22)
        Me.Cl1_Par1.TabIndex = 0
        '
        'Cl1_Par3
        '
        Me.Cl1_Par3.Location = New System.Drawing.Point(12, 226)
        Me.Cl1_Par3.Name = "Cl1_Par3"
        Me.Cl1_Par3.Size = New System.Drawing.Size(203, 22)
        Me.Cl1_Par3.TabIndex = 1
        '
        'Cl1_Par2
        '
        Me.Cl1_Par2.Location = New System.Drawing.Point(12, 149)
        Me.Cl1_Par2.Name = "Cl1_Par2"
        Me.Cl1_Par2.Size = New System.Drawing.Size(203, 22)
        Me.Cl1_Par2.TabIndex = 1
        '
        'Cl1_Par4
        '
        Me.Cl1_Par4.Location = New System.Drawing.Point(12, 305)
        Me.Cl1_Par4.Name = "Cl1_Par4"
        Me.Cl1_Par4.Size = New System.Drawing.Size(203, 22)
        Me.Cl1_Par4.TabIndex = 2
        '
        'Cl2_Par4
        '
        Me.Cl2_Par4.Location = New System.Drawing.Point(177, 305)
        Me.Cl2_Par4.Name = "Cl2_Par4"
        Me.Cl2_Par4.Size = New System.Drawing.Size(203, 22)
        Me.Cl2_Par4.TabIndex = 6
        '
        'Cl2_Par2
        '
        Me.Cl2_Par2.Location = New System.Drawing.Point(177, 149)
        Me.Cl2_Par2.Name = "Cl2_Par2"
        Me.Cl2_Par2.Size = New System.Drawing.Size(203, 22)
        Me.Cl2_Par2.TabIndex = 4
        '
        'Cl2_Par3
        '
        Me.Cl2_Par3.Location = New System.Drawing.Point(177, 226)
        Me.Cl2_Par3.Name = "Cl2_Par3"
        Me.Cl2_Par3.Size = New System.Drawing.Size(203, 22)
        Me.Cl2_Par3.TabIndex = 5
        '
        'Cl2_Par1
        '
        Me.Cl2_Par1.Location = New System.Drawing.Point(177, 73)
        Me.Cl2_Par1.Name = "Cl2_Par1"
        Me.Cl2_Par1.Size = New System.Drawing.Size(203, 22)
        Me.Cl2_Par1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "LISTA 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "LISTA 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guardar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cl1_Par4 As TextBox
    Friend WithEvents Cl1_Par2 As TextBox
    Friend WithEvents Cl1_Par3 As TextBox
    Friend WithEvents Cl1_Par1 As TextBox
    Friend WithEvents Cl2_Par4 As TextBox
    Friend WithEvents Cl2_Par3 As TextBox
    Friend WithEvents Cl2_Par2 As TextBox
    Friend WithEvents Cl2_Par1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
